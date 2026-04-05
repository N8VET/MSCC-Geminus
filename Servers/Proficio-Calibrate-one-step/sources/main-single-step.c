#include "extern.h"
#include "ExtIODll.h"
#include "usbavrcmd.h"
#include "SRDLL.h"
#include "port_defines.h"
#include "lusb0_usb.h"
#include <WinBase.h>

#define TRUE 1
#define FALSE 0
#define MULTUS_VID 0x16C0
#define MULTUS_PID 0x05DC
#define PA_SAMPLE_TYPE      paFloat32
#define NO_OUPUT_DEVICE 100
#define MAX_NULL 38
#define MAX_INPUT_DEVICES 50
#define CMD_SET_XTAL_DEC  0x3A
#define CMD_SET_XTAL_INT  0x33
#define N_DECIMAL_POINTS_PRECISION (100)

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

int32_t G_dial_freq;
int line_number = 0;
INT32 delta = 0;
int8_t G_int_default = -21;
int8_t G_dec_default = -50;
int8_t G_int_part = 0;
int8_t G_dec_part = 0;


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

#define usbHandle  ((usb_dev_handle*)srUsbHandle)

/*BOOL srIsOpen()
{
        return srUsbHandle != NULL;
}*/


void srClose() {
    if (usbHandle != NULL) {
        usb_release_interface(usbHandle, 0);
        usb_close(usbHandle);
    }
    srUsbHandle = NULL;
}

static int usbGetStringAscii(usb_dev_handle *dev, int index, int langid, TCHAR *buf, int buflen) {
    char buffer[256];
    int rval, i;

    if ((rval = usb_control_msg(dev, USB_ENDPOINT_IN, USB_REQ_GET_DESCRIPTOR, (USB_DT_STRING << 8) + index, langid, buffer, sizeof (buffer), 1000)) < 0)
        return rval;

    if (buffer[1] != USB_DT_STRING)
        return 0;

    if ((unsigned char) buffer[0] < rval)
        rval = (unsigned char) buffer[0];

    rval /= 2;

    //lossy conversion to ISO Latin1 
    for (i = 1; i < rval; i++) {
        if (i > buflen) // destination buffer overflow 
            break;
        buf[i - 1] = buffer[2 * i];
        if (buffer[2 * i + 1] != 0) // outside of ISO Latin1 range 
            buf[i - 1] = '?';
    }

    buf[i - 1] = 0;

    return rval;
}

static BOOL testUsbString(int ID, TCHAR* pStr, int iLen, const TCHAR* pTest) {
    *pStr = '\0';

    if (ID > 0) {
        usbGetStringAscii(usbHandle, ID, 0x0409, pStr, iLen);
    }

    if (pTest != NULL)
    {
        if (wcsncmp(pTest, pStr, iLen) != 0)
        {
            return FALSE;
        }
    }
    return TRUE;
}

int srOpen(int vid, int pid, const TCHAR* pManufacturer, const TCHAR* pProduct, const TCHAR* pSerialNumber, int iDevNum, int *status) {
    struct usb_bus *bus;
    struct usb_device *dev;
    //char l_converted_buffer[80] = { 0 };
    char l_temp[80] = {0};
    uint8_t i;
    uint8_t l_count = 0;
    int error = 0;
    int return_status = -1;
    int local_status = 0;

    local_status = *status;
    if (pManufacturer != NULL && pManufacturer[0] == '\0') pManufacturer = NULL;
    if (pProduct != NULL && pProduct[0] == '\0') pProduct = NULL;
    if (pSerialNumber != NULL && pSerialNumber[0] == '\0') pSerialNumber = NULL;
    usb_init();
    usb_find_busses(); // find all busses
    usb_find_devices(); // find all connected devices

    for (bus = usb_get_busses(); bus; bus = bus->next) {
        for (dev = bus->devices; dev; dev = dev->next) {
            if (dev->descriptor.idVendor == vid && dev->descriptor.idProduct == pid) {
                //print_time(0);
                fprintf(stdout, "TRANSCEIVER FOUND\n");
                return_status = 0;
                if ((srUsbHandle = usb_open(dev)) != NULL) {
                    if (iDevNum == -1 || iDevNum == dev->devnum) {
                        if (testUsbString(dev->descriptor.iManufacturer, srUsbInfo.Manufacturer, sizeof (srUsbInfo.Manufacturer), pManufacturer)
                                && testUsbString(dev->descriptor.iProduct, srUsbInfo.Product, sizeof (srUsbInfo.Product), pProduct)
                                && testUsbString(dev->descriptor.iSerialNumber, srUsbInfo.SerialNumber, sizeof (srUsbInfo.SerialNumber), pSerialNumber)) {
                            srUsbInfo.VID = vid;
                            srUsbInfo.PID = pid;
                            if (error = usb_claim_interface(usbHandle, 0) < 0) {
                                srClose();
                                return_status = -1;
                                printf("srOpen -> usb_claim_interface FAILED: %d \n", error);
                            }
                            else {
                                *status = usbGetStringAscii(srUsbHandle, dev->descriptor.iSerialNumber, 0x0409, G_serial_number, 
                                    sizeof(G_serial_number));
                                if (*status > 0) {
                                    //print_time(0);
                                    //printf("srOpen -> G_serial_number: %s, status: %d\n", (char*)G_serial_number, local_status);
                                    memcpy(l_temp, G_serial_number, sizeof(l_temp));
                                    for (i = 0; i < (*status * 2); i++) {
                                        if (l_temp[i] != '\0') {
                                            G_Usb_serial_number[l_count++] = l_temp[i];
                                        }
                                    }
                                    G_Usb_serial_number[l_count] = 0;
                                    printf("TRANSCEIVER SERIAL NUMBER: %s\n",
                                        G_Usb_serial_number);
                                }
                            }
                        }
                    }
                    //srClose();
                }
            }
        }
    }
    return return_status;
}

int usbControlMsgOUT(int cmd, int value, int index, char* buffer, int buflen) {
    int r = -1;
    if (usbHandle != NULL) {
        r = usb_control_msg(usbHandle,
            USB_TYPE_VENDOR | USB_RECIP_DEVICE | USB_ENDPOINT_OUT,
            cmd,
            value, index, buffer, buflen, srUsbTimeout);
    }
    return r;
}

int usbControlMsgIN(int cmd, int value, int index, char* buffer, int buflen) {
    int r = -1;
    
    //print_time(0);
    //fprintf(G_fp_logfile, "[%d] usbControlMsgIN called \n", line_number++);
    if (usbHandle != NULL) {
        r = usb_control_msg(usbHandle,
            USB_TYPE_VENDOR | USB_RECIP_DEVICE | USB_ENDPOINT_IN,
            cmd,
            value, index, buffer, buflen, srUsbTimeout);
    }
    //print_time(0);
    //fprintf(G_fp_logfile, "[%d] usbControlMsgIN Finished . return status %d \n", line_number++,r);
    return r;
}

int cw_receive_parameters(int command, int* value, int print) {
    int status = 0;
    int retry_count = 4;
    int size = 0;
    int failed = FALSE;
    int receive_value = 0;

    size = 4;
    printf("[%d] cw_receive_parameters called. Opcode: 0x%X, Size: %d\n", line_number++,
        command, size);
    printf("[%d] cw_receive_parameters. Calling usbControlMsgOUT\n", line_number++);
    while (retry_count-- > 0 && status != size) {
        status = usbControlMsgIN(command, 0x0700 + 27, 0, (char*)(&receive_value), size);
        Sleep(50);
    }
    if (retry_count == 0) {
        printf("[%d] cw_receive_parameters. retry_count EXCEEDED: %d, status: %d \n",
            line_number++, retry_count, status);
        failed = TRUE;
    }
    /*else {
        if (status != size) {
            printf("[%d] cw_receive_parameters. usbControlMsgIN FAILED. Status: %d \n",
                line_number++, status);
            failed = TRUE;
        }
    }*/
    *value = receive_value;
    printf("[%d] cw_receive_parameters Opcode: 0x%X, value: %d, receive_value: %d, status: %d\n", line_number++,
        command, *value,receive_value,status);
    return failed;
}

int cw_send_parameters(int command, int cmd_value, int print) {
    int status = 0;
    int retry_count = 4;
    int size = 0;
    int failed = FALSE;

    size = sizeof(cmd_value);

    printf("[%d] cw_send_parameters called. Opcode: 0x%X, Value: %d, Size: %d\n", line_number++,
        command, cmd_value, size);
    printf("[%d] cw_send_parameters. Calling usbControlMsgOUT\n", line_number++);
    while (retry_count-- > 0 && status != size) {
        status = usbControlMsgOUT(command, 0x0700 + 27, 0, (char*)(&cmd_value), size);
        Sleep(50);
    }
    if (retry_count == 0) {
        printf("[%d] cw_send_parameters. retry_count EXCEEDED: %d, status: %d \n",
            line_number++, retry_count, status);
        failed = TRUE;
    }
    else {
        if (status != size) {
            printf("[%d] cw_send_parameters. usbControlMsgOUT FAILED. Status: %d \n",
                line_number++, status);
            failed = TRUE;
        }
    }
    return status;
}

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
        strcat(G_l_path, "/multus");
        //printf("getenv: %s\n", G_l_path);
    }
    //$HOME = G_l_path;
    return G_l_path;
}

float calculate_ppm(uint32_t frequency) {
    int32_t real_Hz = 0;
    float f_ppm = 0.0f;
    int delta = 0;

    real_Hz = frequency;
    delta = real_Hz - G_dial_freq;
    delta = (delta * -1);
    printf("[%d] calculate_ppm. Real Frequency: %d, Dial Frequency: %d, delta: %d\n",
        line_number++, real_Hz, G_dial_freq, delta);
    f_ppm = (float)((float)((1000000 * delta)) / (float)G_dial_freq);
    printf("[%d] calculate_ppm. f_ppm: %.3f \n",
        line_number++, f_ppm);
    printf("[%d] calculate_ppm. Finished\n", line_number++);
    return f_ppm;
}



int Freq_Set_Transceiver_Calibration(int int_part, int dec_part) {
    //This is used to adjust the Si5351 frequency. The value is in Hertz. The value is stored in the PSoC EEPROM
    int r0, r1 = 0;

  
    printf("[%d] Freq_Set_Transceiver_Calibration. Calling cw_send_parameters. int_part:%d\n",
        line_number++, int_part);
    r0 = cw_send_parameters(CMD_SET_XTAL_INT, int_part, 1);
    printf("[%d] Freq_Set_Transceiver_Calibration. Calling cw_send_parameters. dec_part: %d\n",
        line_number++, dec_part);
    r1 = cw_send_parameters(CMD_SET_XTAL_DEC, dec_part, 1);
    printf("[%d] Freq_Set_Transceiver_Calibration. int_part: %d, dec_part: %d, FINISHED\n", line_number++,
        int_part, dec_part);
    return ((r0 | r1));
}

void Convert_PPM_To_Int(float ppm_f, int* int_part, int* dec_part) {
    float temp_ppm = 0.0;

    printf("[%d] Convert_PPM_To_Int. fppm: %f \n", line_number++, ppm_f);
    *int_part = (int)ppm_f;
    temp_ppm = ppm_f - (float)*int_part;
    if (temp_ppm < 0.00000) {
        temp_ppm = temp_ppm * -1;
    }
    if (temp_ppm < 0.10000000) {
        *dec_part = 0;
    }
    else {
        *dec_part = ((INT32)(ppm_f * N_DECIMAL_POINTS_PRECISION) % N_DECIMAL_POINTS_PRECISION);
    }
    printf("[%d] Convert_PPM_To_Int. ppm_f: %.3f integer_part %d, decimal_part %d\n",
        line_number++, ppm_f, *int_part, *dec_part);
    printf("[%d] Convert_PPM_To_Int. Finished\n", line_number++);
}

float Convert_PPM_To_Float(int Int_part, int Dec_part) {
    float ppm_value = 0.0f;

    printf("[%d] Convert_PPM_To_Float. Int_part: %d, Dec_part: %d \n",
        line_number++, Int_part, Dec_part);
    ppm_value = (float)Int_part;
    ppm_value = ppm_value + (float)((float)Dec_part / 100.0f);
    printf("[%d] Convert_PPM_To_Float. Finished. ppm_value: %f, Int_part: %d, Dec_part: %d \n",
        line_number++, ppm_value, Int_part, Dec_part);
    return ppm_value;
}

int Calibrate_Si5351_Set_PPM(uint32_t frequency) {//This is called by Process_Frequency_Calibration()
    int status = 0;
    float coarse_ppm = 0.0f;
    float fine_ppm = 0.0f;
    float total_ppm = 0.0f;
    int int_part = 0;
    int dec_part = 0;
    int r = 0;

    printf("[%d] Calibrate_Si5351_Set_PPM. offset freq: %d\n", line_number++, frequency);
    coarse_ppm = Convert_PPM_To_Float(G_int_default, G_dec_default);
    fine_ppm = calculate_ppm(frequency);
    total_ppm = coarse_ppm + fine_ppm;
    printf("[%d] Calibrate_Si5351_Set_PPM. coarse_ppm: %f, fine_ppm: %f, total_ppm: %f\n",
        line_number++, coarse_ppm, fine_ppm, total_ppm);
    Convert_PPM_To_Int(total_ppm, &int_part, &dec_part);
    status = Freq_Set_Transceiver_Calibration(int_part, dec_part);
    printf("[%d] Calibrate_Si5351_Set_PPM. total_int_part: %d,total_dec_part: %d\n", line_number++,
        int_part, dec_part);
    printf("[%d] Calibrate_Si5351_Set_PPM. FINISHED\n", line_number++);
    return status;
}
int Fine_calibration() {
    int status = 0;
    int ret = 0;

    printf("[%d] Fine_calibration.  ENTER +/- TO INCREASE/DECREASE FINE CALIBRATION. ANY OTHER KEY TO QUIT: \n",
        line_number++);
    ret = getchar();
    ret = getchar();
    ret = toupper(ret);
    while (ret == '+' || ret == '-') {
        if (ret == '+') {
            if (G_dec_part <= 122) {
                G_dec_part = G_dec_part + 5;
            }
            else {
                G_int_part = G_int_part + 1;
                G_dec_part = 0;
            }
        }
        else {
            if (G_dec_part >= -123) {
                G_dec_part = G_dec_part - 5;
            }
            else {
                G_int_part = G_int_part - 1;
                G_dec_part = 0;
            }
        }
        status = Freq_Set_Transceiver_Calibration(G_int_part, G_dec_part);
        printf("\n[%d] Fine_calibration.  ENTER +/- : ", line_number++);
        ret = getchar();
        ret = getchar();
        ret = toupper(ret);
    }
    printf("\n[%d] Fine_calibration. FINISHED\n", line_number++);
    return status;
}


int main(int argc, char **argv) {
    int status = 0;
    int usb_status;
    int exit_status = 0;
    int ret = 0;
    int scan_status = 0;
    int dec_value = 0;
    int int_value = 0;
    uint16_t dial = 0;
    uint8_t mfc = 0;
    uint8_t meter = 0;
    int16_t delta_value = 0;
    WSADATA dll_wsa;
    uint8_t selected_sound_device = 0;
    uint8_t selected_comm_port = 0;
    int transceiver_type = 7;

    printf("\nproficio-calibrate: THIS PROGRAM CALIBRATES THE PROFICIO OSCILLATOR.\n");
    status = srOpen(MULTUS_VID, MULTUS_PID,L"", L"", L"", -1, &usb_status);
    //printf("srOpen status: %d \n", status);
    if (status >= 0) {
        G_mscc_port = MSCC_PORT;
        G_server_port = MS_SDR_PORT;
        G_string_mscc_IP[0] = 'N';
        if (WSAStartup(MAKEWORD(2, 2), &dll_wsa) != NO_ERROR)
        {
            printf("proficio-calibrate: Initializing Winsock: Failed. Error Code : %d\n",WSAGetLastError());
            exit(1);
        }
        ret = gethostname(G_string_server_IP, sizeof (G_string_server_IP));
        strcpy(G_mscc_RPI_IP, G_string_server_IP);
        strcpy(G_string_mscc_IP, G_string_server_IP);
        printf("HOSTNAME: %s\n", G_string_server_IP);
        G_PCB_Version = 0;
        printf("TRANCEIVER IS ATTACHED\n");
        printf("CALIBRATE THE TRANSCEIVER ? ENTER: Y (ANY OTHER KEY TO QUIT): ");
        ret = getchar();         
        ret = toupper(ret);
        if (ret == 'Y') {
            printf("RESETTING THE CALIBRATION\n");
            Freq_Set_Transceiver_Calibration(G_int_default, G_dec_default);
            //usleep(5000);
            printf("ENTER THE DIAL FREQUENCY: ");
            scan_status = scanf("%d", &G_dial_freq);
            if (G_dial_freq >= 1) {
                printf("ENTER THE DIFFERENCE FROM THE DIAL FREQUENCY: ");
                scan_status = scanf("%hd", &delta_value);
                printf("VALUES ENTERED: %d , %d \n", G_dial_freq, delta_value);
                Calibrate_Si5351_Set_PPM(G_dial_freq + delta_value);
                printf("CONTINUE WITH FINE CALIBRATION? Y/N: ");
                ret = getchar();
                ret = getchar();
                ret = toupper(ret);
                if (ret == 'Y') {
                    Fine_calibration();
                }
                printf("\nTHE TRANSCEIVER HAS BEEN CALIBRATED \n");
            }
        }
        else {
            printf("CALIBRATION NOT RUN \n");
        }

    } else {
        printf("TRANSCEIVER INITIALIZATION FAILED.  TRANSCEIVER NOT ATTACHED TO USB PORT OR THE TRANSCEIVER IS IN USE\n");
        exit_status = 5;
    }
    printf("ENTER ANY KEY TO QUIT: ");
    ret = getchar();
    ret = getchar();
    return exit_status;
}