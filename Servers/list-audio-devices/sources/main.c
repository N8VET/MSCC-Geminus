#include "extern.h"
#include "ExtIODll.h"
#include "usbavrcmd.h"
#include "SRDLL.h"
#include "port_defines.h"
#include "lusb0_usb.h"
#include "portaudio.h"
#include <WinBase.h>

#define TRUE 1
#define FALSE 0
#define MULTUS_VID 0x16C0
#define MULTUS_PID 0x05DC
#define PA_SAMPLE_TYPE      paFloat32
#define NO_OUPUT_DEVICE 100
#define MAX_NULL 38
#define MAX_DEVICES 50

typedef float SAMPLE;
int modeChanged = FALSE;
int inputchannels = 0;
int myAudioAPItype = 0;
sp_float* inbuffer, * outbuffer;
sp_float wold = 0;
sp_cplx incplx[4097];
sp_cplx outcplx[4096];
float volumeLevel = -0.0f; //Start with the volume muted.
int G_input_device_index = NO_OUPUT_DEVICE;
int G_output_device_index = NO_OUPUT_DEVICE;

struct input_devices {
    int record_number;
    int device_index;
    char name[512];
    int num_channels;
    int default_input_device;
    int selected_input_device;
};

struct output_devices {
    int record_number;
    int device_index;
    char name[512];
    int num_channels;
    int default_output_device;
    int selected_output_device;
};

struct input_devices G_input_devices[MAX_DEVICES];
struct output_devices G_output_devices[MAX_DEVICES];
int num_input_devices_found = 0;
int num_output_devices_found = 0;
state mystate;
PaStream* stream;

const PaDeviceInfo* lpInfo;
PaStreamParameters inputParameters, outputParameters;

static uint8_t Multus_rig = FALSE;
void* srUsbHandle = NULL;
int srUsbTimeout = 500;
static srUsbInfo_t srUsbInfo;
TCHAR G_serial_number[MAX_PATH] = {0};
static char G_Multus_serial_number[MAX_PATH] = {0};
static char G_Usb_serial_number[MAX_PATH] = {0};
char G_string_mscc_port[16];
char G_string_mscc_IP[MAX_PATH];
char G_mscc_RPI_IP[MAX_PATH];
char G_string_server_port[16];
char G_string_server_IP[MAX_PATH];
int G_mscc_port = 0;
int G_server_port = 0;
char G_Sound_Init_File[] = "/.local/share/mscc/sound-device.ini";
char comm_ports[256] = { 0 };

uint8_t G_PCB_Version;
char Sound_device[MAX_PATH] = {0};
const char *homedir;
char G_l_path[MAX_PATH] = { 0 };
int G_sound_status = 0;
int G_recording_default = 0;
int G_playback_default = 0;


char* My_getenv(char* myenv) {

    //FILE* Multus_ini;
    WCHAR path[MAX_PATH] = { 0 };
    PWSTR lpPath = path;
    int lenght = 0;

    memset(G_l_path, 0, sizeof(G_l_path));

    HRESULT hr = SHGetKnownFolderPath(&FOLDERID_LocalAppData, 0, NULL, &lpPath);
    //fprintf("get_serial_number -> Get folder path \n");
    if (SUCCEEDED(hr)) {
        WideCharToMultiByte(CP_ACP, WC_COMPOSITECHECK, lpPath, -1, G_l_path, sizeof(G_l_path), NULL, NULL);
        strcat(G_l_path, "/MSCC-PW");
        //printf("getenv: %s\n", G_l_path);
    }
    //$HOME = G_l_path;
    return G_l_path;
}

int init_ini() {
    int status = 01;
    FILE *Multus_ini;
    char l_path[MAX_PATH] = {0};
    //char directry[PATH_MAX] = {0};

    if ((homedir = My_getenv("HOME")) != NULL) {
        strcpy(l_path, homedir);
        strcat(l_path, "Multus_mscc.ini");
        Multus_ini = fopen(l_path, "w");
        if (Multus_ini != NULL) {
            fprintf(Multus_ini, "PROFICIO_SERIAL_NUMBER=%s;\n", G_Usb_serial_number);
            fprintf(Multus_ini, "MSCC_PORT=%d;\n", G_mscc_port);
            fprintf(Multus_ini, "MSCC_IP=%s;\n", G_string_mscc_IP);
            fprintf(Multus_ini, "PROFICIO_DLL_PORT=%d;\n", G_server_port);
            fprintf(Multus_ini, "PROFICIO_DLL_IP=%s;\n", G_string_server_IP);
            fprintf(Multus_ini, "PCB_VERSION=%d;\n", G_PCB_Version);
            fputs("CW_Restore_Defaults=0;\n", Multus_ini);
            fputs("CW_Iambic_Mode_On_Off=0;\n", Multus_ini);
            fputs("CW_Iambic_Type=0;\n", Multus_ini);
            fputs("CW_Iambic_Calibrate=120;\n", Multus_ini);
            fputs("CW_Memory=3;\n", Multus_ini);
            fputs("CW_Spacing=1;\n", Multus_ini);
            fputs("CW_Paddle=0;\n", Multus_ini);
            fputs("CW_Weight=50;\n", Multus_ini);
            fputs("CW_Tx_Hold=10;\n", Multus_ini);
            fputs("CW_Speed=18;\n", Multus_ini);
            fputs("CW_Semi_Break_In=0;\n", Multus_ini);
            fputs("CW_Semi_Control=0;\n", Multus_ini);
            fputs("CW_Side_Tone=1;\n", Multus_ini);
            fputs("Highlimit=3000;\n", Multus_ini);
            fflush(Multus_ini);
            fclose(Multus_ini);
        } else status = -1;
    } else status = -1;
    return status;
}



int build_output_devices(int device_index) {
    static int index = 0;
    int ret = 0;
    char temp_string[MAX_PATH] = { 0 };
    char* multus_found = NULL;
    int default_device = 0;

    if (index < MAX_DEVICES) {
        strcpy(temp_string, lpInfo->name);
        strcpy(G_input_devices[index].name, temp_string);
        G_output_devices[index].device_index = device_index;
        G_output_devices[index].num_channels = lpInfo->maxOutputChannels;
        G_output_devices[index].record_number = index;
        multus_found = strstr(temp_string, "Multus");
        if (device_index == Pa_GetHostApiInfo(lpInfo->hostApi)->defaultOutputDevice) {
            G_output_devices[index].default_output_device = 1;
            default_device = 1;
            G_playback_default = 1;
            if (multus_found != NULL && default_device == 1) {
                printf("Multus device set as default\n");
                G_sound_status = 1;
            }
        }
        printf("build_output_devices. Name: %s,index: %d, channels: %d, default: %d\n",
                                            G_input_devices[index].name, G_output_devices[index].device_index, 
                                                G_output_devices->num_channels, default_device);
        num_output_devices_found = index;
    }
    else {
        printf("Number of output devices exceed permitted limit\n");
    }
    return default_device;
}

int build_input_devices(int device_index) {
    static int index = 0;
    int default_device = 0;
    int ret = 0;
    char temp_string[MAX_PATH] = { 0 };
    char* multus_found = NULL;
  
    if (index < MAX_DEVICES) {
        strcpy(temp_string, lpInfo->name);
        strcpy(G_input_devices[index].name, temp_string);
        G_input_devices[index].device_index = device_index;
        G_input_devices[index].num_channels = lpInfo->maxInputChannels;
        G_input_devices[index].record_number = index;
        multus_found = strstr(temp_string, "Multus");
        if (device_index == Pa_GetHostApiInfo(lpInfo->hostApi)->defaultInputDevice) {
            G_input_devices[index].default_input_device = 1;
            default_device = 1;
            G_recording_default = 1;
            if (multus_found != NULL && default_device == 1) {
                printf("Multus device set as default\n");
                G_sound_status = 1;
            }
        }
        printf("build_input_devices. Name: %s,index: %d, channels: %d, default: %d\n",
            G_input_devices[index].name, G_input_devices[index].device_index, G_input_devices->num_channels, 
            default_device);
        num_input_devices_found = index;
    }
    else {
        printf("Number of input devices exceed permitted limit\n");
    }
    return default_device;
}
void Get_Playback_Audio_Device() {

    PaDeviceIndex devCount = Pa_GetDeviceCount();
    PaDeviceIndex recordDevice = 0;
    PaDeviceIndex playDevice = 0;
    int j = 0;
    int build_status = 0;

    // Get # of host API's supported on THIS machine at THIS time.
    const PaHostApiInfo* lpApiInfo;
    PaHostApiIndex hostApiCount;
    int apiTypeMME = 9999;
    int apiTypeDSOUND = 9999;
    int apiTypeWDMKS = 9999;
    int apiTypeWASAPI = 9999;
    int apiTypeASIO = 9999;
    int apiTypeALSA = 9999;

    hostApiCount = Pa_GetHostApiCount();

    for (j = 0; j < hostApiCount; j++) {
        lpApiInfo = Pa_GetHostApiInfo(j);
        if (!strncmp("MME", lpApiInfo->name, 3)) {
            apiTypeALSA = j;
        }
    }

    for (int j = 0; j < devCount; j++) {
        lpInfo = Pa_GetDeviceInfo((PaDeviceIndex)j);
        if (lpInfo->hostApi == apiTypeALSA) {
            if (lpInfo->maxOutputChannels >= 1) {
                //printf("Get_Speaker_Audio_Device. Index: %d, lpInfo: %s\n", (PaDeviceIndex)j, lpInfo->name);
                build_status = build_output_devices((PaDeviceIndex)j);
            }
        }
    }
    printf("\n");
}

void Get_Recording_Audio_Device() {

    PaDeviceIndex devCount = Pa_GetDeviceCount();
    PaDeviceIndex recordDevice = 0;
    PaDeviceIndex playDevice = 0;
    int j = 0;


    // Get # of host API's supported on THIS machine at THIS time.
    const PaHostApiInfo* lpApiInfo;
    PaHostApiIndex hostApiCount;
    int apiTypeMME = 9999;
    int apiTypeDSOUND = 9999;
    int apiTypeWDMKS = 9999;
    int apiTypeWASAPI = 9999;
    int apiTypeASIO = 9999;
    int apiTypeALSA = 9999;
    int build_status = 0;

    hostApiCount = Pa_GetHostApiCount();

    for (j = 0; j < hostApiCount; j++) {
        lpApiInfo = Pa_GetHostApiInfo(j);
        if (!strncmp("MME", lpApiInfo->name, 3)) {
            apiTypeALSA = j;
        }
    }

    for (int j = 0; j < devCount; j++) {
        lpInfo = Pa_GetDeviceInfo((PaDeviceIndex)j);
        if (lpInfo->hostApi == apiTypeALSA) {
            if (lpInfo->maxInputChannels >= 1) {
                build_status = build_input_devices((PaDeviceIndex)j);
            }
        }
    }
    printf("\n");
}

int Update_Speaker_Config(int record) {
    int status = 0;
    FILE* Multus_ini;
    char l_path[MAX_PATH] = { 0 };
    char directry[MAX_PATH] = { 0 };
    char device_number[2] = { 0 };

    if ((homedir = My_getenv("HOME")) != NULL) {
        strcpy(l_path, homedir);
        strcat(l_path, "/speaker-sound-device.ini");
        Multus_ini = fopen(l_path, "w");
        if (Multus_ini != NULL) {
            _itoa(record, device_number, 10);
            fprintf(Multus_ini,"%s\n", device_number);
            fflush(Multus_ini);
            fclose(Multus_ini);
        }
        else
        {
            status = -1;
            printf("Open FAILED. %s: \n", l_path);
        }
    }
    else {
        status = -1;
        printf("My_getevn FAILED. %s: \n", homedir);
    }
    return status;
}

int Update_Microphone_Config(int record) {
    int status = 0;
    FILE* Multus_ini;
    char l_path[MAX_PATH] = { 0 };
    char directry[MAX_PATH] = { 0 };
    char device_number[2] = { 0 };

    if ((homedir = My_getenv("HOME")) != NULL) {
        strcpy(l_path, homedir);
        strcat(l_path, "/microphone-sound-device.ini");
        Multus_ini = fopen(l_path, "w");
        if (Multus_ini != NULL) {
            _itoa(record, device_number, 10);
            fprintf(Multus_ini, "%s\n", device_number);
            fflush(Multus_ini);
            fclose(Multus_ini);
        }
        else
        {
            status = -1;
            printf("Open FAILED. %s: \n", l_path);
        }
    }
    else {
        status = -1;
        printf("My_getevn FAILED. %s: \n", homedir);
    }
    return status;
}


int main(int argc, char **argv) {
    int status = 0;
    //int usb_status;
    int exit_status = 0;
    int ret = 0;
    int scan_status = 0;
    uint8_t rego = 0;
    uint8_t mfc = 0;
    uint8_t meter = 0;
    uint8_t mfc_serial_port = 254;
    //WSADATA dll_wsa;
    uint8_t selected_sound_device = 0;
    uint8_t selected_comm_port = 0;
    int transceiver_type = 7;
    PaError err;
    
    err = Pa_Initialize();
    Get_Recording_Audio_Device();
    Get_Playback_Audio_Device();
    if (G_sound_status == 0) {
        if (G_recording_default == 0 ) {
            G_sound_status = 2;
        }
        if (G_playback_default == 0) {
            G_sound_status = 3;
        }
    }
    printf("G_sound_status: %d\n", G_sound_status);
    exit_status = G_sound_status;
    //rego = getchar();
    //exit_status = 1;
    return exit_status;
}