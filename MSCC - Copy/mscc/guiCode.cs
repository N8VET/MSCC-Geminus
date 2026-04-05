using OmniaGUI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

//using FTD2XX_NET;

#region Master_Controls
public static class Master_Controls
{
    public static class Mouse_Controls
    {
        public const byte VOLUME_SLIDER = 0;
        public const byte VOLUME_BUTTON = 1;
        public const byte MAIN_FREQUENCY = 2;
        public const byte RIT = 3;
        public const byte MIC_GAIN_SLIDER = 4;
        public const byte MIC_GAIN_BUTTON = 5;
        public const byte COMPRESSION = 6;
        public const byte MAIN_POWER_SLIDER = 7;
        public const byte IQBD_SLIDER = 8;
        public const byte COMPRESSION_SLIDER = 9;
        public const byte NO_OP = 100;
        public static byte Mouse_Repeat_Button = 1;
        public static byte control_window = MAIN_FREQUENCY;
        public static int Mouse_Down_Count = 0;
        public static int Mouse_Interval = 500;
        public const int MOUSE_INTERVAL_MAX = 500;
        public static bool Allow_Frequency_Updates = true;
        public static bool Silent_Update = false;
        public static class Mouse_Buttons
        {
            public static byte mouse_button = 0;
            public const byte FREQ_UP = 0;
            public const byte FREQ_DOWN = 1;
            public const byte VOLUME_UP = 3;
            public const byte VOLUME_DOWN = 4;
            public const byte MIC_GAIN_UP = 5;
            public const byte MIC_GAIN_DOWN = 6;
            public const byte RIT_UP = 7;
            public const byte RIT_DOWN = 8;
            public const byte COMPRESSION_UP = 9;
            public const byte COMPRESSION_DOWN = 10;
        }
    }
    public static bool Time_Check_Box = false;
    public static bool Reset_Log_File = false;
    public static int previous_second = 0;
    public const short general_band = 200;
    public static short modeswitch = 0;
    public static bool monitor_suspend = false;
    public static long line_count = 0;
    public static bool Shutdown = false;
    public static bool Shutdown_By_User = false;
    public static int Main_frequency = 0;
    public static String proc_name;
    public static bool isLoading = false;
    public static int Main_volume = 0;
    public static int Previous_Main_frequency = 0;
    public static int Log_retry_count = 0;
    public static bool Transmit_Mode = false;
    public static bool PPT_Mode = false;
    public static bool Tuning_Mode = false;
    public static bool Two_Tone_Mode = false;
    public static bool transverter_warning_displayed = false;
    public static bool trans_on = false;
    public static bool transverter_warning_accepted = false;
    public static short band_stack_band = 20;
    public static short band_stack_element = 0;
    public static bool band_stack_updating = false;
    public static short FreqDigit = 0;
    public const byte CMD_RPI_SET_TEMPERATURE = 0x12;
    public const byte CMD_SET_DISPLAY_FREQ = 0xBB;
    public const byte CMD_SET_TX_SET_BY_SERVER = 0xBC;
    public const byte CMD_GET_SET_FIRMWARE_VERSION = 0xB2;
    public const byte CMD_GET_SET_MSSDR_VERSION = 0xB3;
    public const byte CMD_GET_SET_SDRCORE_RECV_VERSION = 0xB5;
    public const byte CMD_GET_SET_SDRCORE_TRANS_VERSION = 0xBD;
    public const byte CMD_MODE_SET_BY_SERVER = 0xA8;
    public const byte CMD_SET_TWO_TONE = 0x88;
    public const byte CMD_SET_PA_BYPASS = 0xF7;
    public const byte CMD_GET_OPTIONS_STATUS = 0xBE;
    public const byte CMD_GET_TRANSCEIVER_TEMP = 0xBF;
    public const byte CMD_SEND_GUI_STATUS = 0xFE;
    public const byte CMD_SET_FAN_CONTROL = 0xFC;
    public const byte CMD_SET_FAN_ON_TEMPERATURE = 0xFD;
    public const byte CMD_SET_ANTENNA_SENSE = 0x36;
    public const byte CMD_SET_CONFIGURATION = 0x24;
    public const short NO_STARTUP_BAND = 345;
    public static int Vertical_scroll_size;
    public static bool Socket_Error = false;
    public static bool Keep_Alive = false;
    public static short Keep_Alive_Counter = 0;
    //public static short Keep_Alive_Pulse = 0;
    public static bool Client_Update_Flag = false;
    public static bool Move_Windows = false;
    public static int Move_Window_Delay = 0;
    //public static bool Initialized = false;
    public static int Startup_Band = NO_STARTUP_BAND;
    public static bool Step_Sent = false;
    public static bool Network_Receive_Busy = false;
    public static bool MSSDR_running = false;
    public static bool GUI_check_status = true;
    public static int Check_Server_Status_Count = 0;
    public const int Check_Server_Limit = 20;
    public static bool Initialize_network_status = false;
    public static bool Get_Network_file = false;
    public static Point Main_Smeter_Position;
    public static bool FTP_File_Found = true;
    public static bool Main_Tab_Active = true;
    public static bool Post_Init = false;
    public static int Solidus_Fan_Control = 0;
    public static int Solidus_Fan_On_Temperature = 30;
    public static bool MonitorText_Busy = false;
    public static int MonitorText_Busy_count = 0;
    public static bool TX_By_Server = false;
    public static bool Previous_TX_By_Server = false;
    public static byte Manage_Controls_State = 0;
    public static string build_date;
    public static byte tab_index = 0;
    public static int popup_button_config = 1;
    public static byte Proficio_Calibrated_band = 0;
    public static bool Geminus_Calibrated_band = true;
    public static bool Band_Stack_Initialized = false;

    public static bool PA_Button_ON = false;
    public static bool QRP_Button_ON = false;
    public static byte PA_QRP_Caller = 0;
    public const byte PA_BUTTON = 0;
    public const byte QRP_BUTTON = 1;
    public static class Server_Configuration_Commands
    {
        public static bool Keyboard_displayed = false;
        public static bool Frequency_Entered = false;
        public static byte Number_Count = 0;
        public const byte MAX_NUMBER_COUNT = 8;
        public static int Frequency = 0;
        public const byte DIGITAL_AUDIO = 0;
        public const byte OPERATOR_AUDIO = 1;
        public const byte KEYBOARD_DISPLAY = 2;
        public const byte KEYBOARD_STOP = 3;
        public const byte KEYBOARD_DISPLAY_NUMPAD = 4;
        public const byte AUTO_START_ON = 5;
        public const byte AUTO_START_OFF = 6;
    }
    public static class Display_Colors
    {
        public static Color Button_Active_Foreground = Color.White;
        public static Color Button_Active_Background = Color.Red;

        public static Color Button_Default_Foreground = Color.Black;
        public static Color Button_Default_Background = Color.Gainsboro;

        public static Color Button_Success_Foreground = Color.Green;
        public static Color Button_Success_Background = Color.Gainsboro;

        public static Color Button_Error_Foreground = Color.Yellow;
        public static Color Button_Error_Background = Color.Gainsboro;

        public static Color Text = Color.White;
        public static Color Text_Border = Color.Black;
        public static Color Background = Color.Black;
    }
    public static class Extended_Commands
    {
        public const byte CMD_SET_EXTENDED_COMMAND = 0x0B;
        //Waterfall Commands
        public const byte CMD_SET_WATERFALL_DISPLAY = 0x00;
        public const byte CMD_SET_WATERFALL_GAIN = 0x01;
        public const byte CMD_SET_WATERFALL_GRID = 0x02;
        public const byte CMD_SET_WATERFALL_ZERO = 0x03;
        public const byte CMD_SET_WATERFALL_SPEED = 0x04;
        public const byte CMD_SET_WATERFALL_DIRECTION = 0x05;
        public const byte CMD_SET_WATERFALL_PALET = 0x06;
        public const byte CMD_SET_WATERFALL_WHEEL_STATUS = 0x07;
        //Solidus Commands
        public const byte CMD_SET_ANTENNA_SWITCH = 0x08;
        public const byte CMD_SET_IQBD_MONITOR = 0x09;
        public const byte CMD_SET_IQBD_DATA = 0x0A;
        public const byte CMD_SET_FORWARD_POWER = 0x0B;
        public const byte CMD_SET_REVERSE_POWER = 0x0C;
        public const byte CMD_SET_SWR = 0x0D;
        public const byte CMD_SET_SOLIDUS_STATUS = 0x0E;
        public const byte CMD_SET_FORTIS_DEVICES = 0x32;
        //RPi Commands
        public const byte CMD_SET_REBOOT = 0X40;
        public const byte CMD_SET_SHUTDOWN = 0X41;
        public const byte CMD_RESET_LOGS = 0X42;
        //Calibration Commands
        public const byte CMD_CALIBRATION_CANCEL = 0x12;
        // MFC Server Commands
        public const byte CMD_MFC_AUTO_ZERO = 0x13;
        public const byte CMD_MFC_SET_ZERO = 0x14;
        public const byte CMD_MFC_SET_BAND = 0x15;
        public const byte CMD_MFC_SET_FAVS = 0x16;
        public const byte CMD_MFC_SET_STEP = 0x17;
        public const byte CMD_MFC_SET_TUNE = 0x18;
        public const byte CMD_MFC_SET_MODE = 0x19;
        public const byte CMD_MFC_SET_RIT_MODE = 0x1A;
        public const byte CMD_MFC_SET_CW_BW = 0x1B;
        public const byte CMD_MFC_SET_HI_BW = 0x1C;
        public const byte CMD_MFC_SET_RIT = 0x1D;
        public const byte CMD_SET_GUI_STAR = 0x1E;
        public const byte Knob_switch_star = 0x10;
        public const byte Button_A_switch_star = 0x20;
        public const byte Button_B_switch_star = 0x30;
        public const byte Button_C_switch_star = 0x40;

        public const byte CMD_SET_KNOB_SWITCH = 0x20;
        public const byte CMD_SET_LEFT_SWITCH = 0x21;
        public const byte CMD_SET_MIDDLE_SWITCH = 0x22;
        public const byte CMD_SET_RIGHT_SWITCH = 0x23;
        public const byte CMD_SET_PTT_SWITCH = 0x24;
        public const byte CMD_SET_METER_HOLD = 0x26;
        public const byte CMD_SET_RIT_STEP = 0x27;
        // Server Messages
        public const byte CMD_SET_SERVER_ERROR = 0x30;
        public const byte CMD_SET_SERVER_MSG = 0x31;
    }
    // End Extended Commands
    public static bool TX_Inhibited = true;
    public static bool Out_Of_Band_Toggle = false;
    public static bool code_triggered = false;
    public static bool Startup_Label_Toggle = false;
    public static short Startup_Label_Tick_count = 0;
    public static bool Debug_Display = false;
    public static bool Two_Tone = false;
    public static bool QRP_Mode = true;
    public static bool QRP_Mode_test = true;
    public const byte QRP_MODE = 0;
    public const byte QRO_MODE = 1;
    public static bool QRP_Startup_Mode_Status = false;
    public static bool Transceiver_Warming = true;
    public static int Power_Bar_Value = 0;
    public static int Step_Index = 0;
    public static int Major_Version_Minimum = 121;
    public static int Major_Version_Maximum = 122;
    public static string Server_Message;
    public static bool Server_Message_Received = false;
    public static bool Server_Message_Blink_Toggle = false;
    public static class Auto_Tune
    {
        public static bool Band_Change_Toggle = false;
        public static byte Band_Change_On_Timer = 0;
        public static bool Band_Change_Tune_Called = false;
        public static byte Band_Change_Delay = 0;
        public static bool First_Pass = true;
        public static bool Inhibit = false;
        public static byte Auto_Tune_Mode = 1;
        public static bool Auto_Tune_Toggle = false;
        public static byte Auto_Tune_Time = 1;
        public static bool Show_Warning = true;
        public static byte Inhibit_Count = 0;
        public static int Band_Change_Tune = 0;
    }
    public struct Firmware_Version
    {
        public static int Major;
        public static int Minor;
    }
    public struct SDRcore_trans_verison
    {
        public static int Major;
        public static int Minor;
    }
    public struct SDRcore_recv_verison
    {
        public static int Major;
        public static int Minor;
    }
    public struct mssdr_verison
    {
        public static int Major;
        public static int Minor;
    }
    public struct Minimum_Firmware
    {
        public static readonly int Major = 119;
        public static readonly int Minor = 20;
    }
    public static TabPage Current_tab;
}
#endregion Master_Controls

#region Window_controls
public static class Window_controls
{
    public const int CMD_SET_X_POSITION = 0x3B;
    public const int CMD_SET_Y_POSITION = 0x3E;
    public struct Panadapter_New
    {
        public static bool form_displosed = false;
        public static int form_state = 0;
        public static bool display_form = true;
        public static bool window_created = false;
        public static bool window_displayed = false;
        public static bool window_visable = false;
        public static bool window_minimized = false;
        //public static bool spectrum_window_hidden = false;
        public static bool window_minimized_by_user = false;
        public static bool window_normallized_by_user = false;
        public static bool button_clicked = false;
        public static bool first_pass = true;

    }
    /*public struct Docking_Controls
    {
        //public static bool Docked = false;
        public static bool Previous_Docked = false;
        public struct Last_Sized
        {
            public static byte Order = 0;
            public const byte None = 0;
            public const byte Spectrum = 1;
            public const byte Waterfall = 2;
            public struct Window_Size
            {
                public static Size Spectrum = new Size(0, 0);
                public static Size Previous_Spectrum = new Size(0, 0);
                public static Size Waterfall = new Size(0, 0);
                public static Size Previous_Waterfall = new Size(0, 0);
            }
        }
        public static Size Main_docked_size;
        public static Point Main_location;
        public static Point Previous_Main_location = new Point(0, 0);
        public static Size Spectrum_docked_size;
        public static Point Spectrum_location;
        public static Size Waterfall_docked_size;
        public static Point Waterfall_location;
    }*/
    public struct Waterfall_Controls
    {
        public struct CW_Snap
        {
            public static bool CW_button = false;
            public static bool CW_check_box = false;
            public static bool CW_snap_status = false;
            public static System.Drawing.Color Button_Color = System.Drawing.Color.Black;
            public static bool button_clicked = false;
        }
        public struct Set_by_server
        {
            public static bool grid = false;
            public static bool direction = false;
            public static bool gain = false;
            public static bool zero = false;
            public static bool speed = false;
            public static bool pallet = false;
        }
        public struct Markers
        {
            public static int MARKER_OUT_OF_RANGE = 1000;
            public const int DISPLAY_BANDWIDTH = 72000;
            public static int STARTUP_MAX_PIXELS = 800;
            public static int Window_Size = 0;
            public static int Display_Center = 399;
            public static int band_marker_low = 1;
            public static int band_marker_high = 2;
            public static int band_center = 0;
            public static int CW_Offset = 0;
            public static Color cursor_color = Color.White;
            public static Pen cursor_pen;
            public static int Waterfall_Marker_Color_index = 0;
            public static Color Waterfall_Marker_Color = Color.Red;
        }
        public static bool form_displosed = false;
        public static Size new_size;
        public static int form_state = 0;
        public static bool display_form = true;
        public static bool window_created = false;
        public static bool window_displayed = false;
        public static bool window_visable = false;
        public static bool window_minimized = false;
        public static bool window_minimized_by_user = false;
        public static bool window_normallized_by_user = false;
        public static bool button_clicked = false;
        public static bool first_pass = true;
        //public static PictureBox Waterfall_picture_box;
        public static Graphics Pic_Waterfall_graphics;
        public static Graphics Waterfall_graphics;
        public static bool Start_toggle = false;
        public static bool Display_Operation_Complete = false;
        public static bool Waterfall_thread_running = false;
        public static bool direction_normal = true;
        public static int seconds = 0;
        public static byte Time_grid = 0;
        public static int window_speed = 1;
        public static int zero = 410;
        public static int gain = 3090;
        public static int picture_box_width = 764;
        public const int Window_delta_width = 36;
        public const int Window_delta_height = 67;
        public static int Display_width_delta = 20;
        public static bool Wheel_zoom_status = false;
        public static int Wheel_value = 0;
        public static bool Zoom_process = false;
        public static int pallet_index = 0;
        public static bool restore_size = false;
        public struct Display_Buffer
        {
            public static UInt16[] X_value = new UInt16[800];
            public static UInt16[] Y_value = new UInt16[800];
        }
    }
    public struct Panadapter_Controls
    {
        public static bool panadapter_form_displosed = false;
        public static int panadapter_form_state = 0;
        public static bool display_panadapter_form = true;
        public static bool panadapter_window_created = false;
        public static bool panadapter_window_displayed = false;
        public static bool update_init_files = false;
        public static panadapter_control Panadapter_Control_Window;
    }

    public static bool freq_form_displosed = false;
    public static int freq_form_state = 0;
    public static bool display_freq_form = true;
    public static bool monitor_form_displosed = false;
    public static int monitor_form_state = 0;
    public static bool display_monitor_form = true;
    public static bool smeter_created = false;
    public static bool smeter_first_pass = true;
    public static bool smeter_form_displosed = false;
    public static int smeter_form_state = 0;
    public static bool display_smeter_form = true;
    public static bool smeter_displayed = false;
    public static bool smeter_display_visable = false;
    public static bool smeter_minimized = false;
    public static bool smeter_window_minimized_by_user = false;
    public static bool smeter_window_normallized_by_user = false;
    public static bool smeter_button_clicked = false;
    public static bool Panadapter_Toggle = false;
    public static bool Smeter_Toggle = false;
    public static bool Waterfall_Toggle = false;
    public static bool Panadapter_On_By_Server = false;
    public static bool Smeter_On_By_Server = false;
    public static bool Waterfall_On_By_Server = false;
    public const byte CMD_SET_PANADAPTER_DISPLAY = 0xDF;
    public const byte CMD_SET_SMETER_DISPLAY = 0xCF;
}
#endregion Window_controls

#region Waterfall
public struct Waterfall_Controls
{
    public struct CW_Snap
    {
        public static bool CW_button = false;
        public static bool CW_check_box = false;
        public static bool CW_snap_status = false;
        public static System.Drawing.Color Button_Color = System.Drawing.Color.Black;
        public static bool button_clicked = false;
    }

    public struct Set_by_server
    {
        public static bool grid = false;
        public static bool direction = false;
        public static bool gain = false;
        public static bool zero = false;
        public static bool speed = false;
        public static bool pallet = false;
    }

    public struct Markers
    {
        public static int MARKER_OUT_OF_RANGE = 1000;
        public const int DISPLAY_BANDWIDTH = 72000;
        public static int STARTUP_MAX_PIXELS = 800;
        public const int AM_RX_OFFSET = -1;
        public static int Display_Center = 399;
        public static int band_marker_low = 1;
        public static int band_marker_high = 2;
        public static int band_center = 0;
        public static int CW_Offset = 0;
        public static Color cursor_color = Color.White;
        public static Pen cursor_pen;
        public static int Waterfall_Marker_Color_index = 0;
    }
    public static bool form_displosed = false;
    public static Size new_size;
    public static int form_state = 0;
    public static bool display_form = true;
    public static bool window_created = false;
    public static bool window_displayed = false;
    public static bool window_visable = false;
    public static bool window_minimized = false;
    public static bool window_minimized_by_user = false;
    public static bool window_normallized_by_user = false;
    public static bool button_clicked = false;
    public static bool first_pass = true;
    //public static PictureBox Waterfall_picture_box;
    public static Graphics Pic_Waterfall_graphics;
    public static Graphics Waterfall_graphics;
    public static bool Start_toggle = false;
    public static bool Display_Operation_Complete = false;
    public static bool Waterfall_thread_running = false;
    public static bool direction_normal = true;
    public static int seconds = 0;
    public static byte Time_grid = 0;
    public static int window_speed = 1;
    public static int zero = 410;
    public static int gain = 3090;
    public static int picture_box_width = 764;
    public const int Window_delta_width = 36;
    public const int Window_delta_height = 67;
    public static int Display_width_delta = 20;
    public static bool Wheel_zoom_status = false;
    public static int Wheel_value = 0;
    public static bool Zoom_process = false;
    public static int pallet_index = 0;
    public static bool restore_size = false;
    public static float[] new_waterfall_data;
    public static float[] current_waterfall_data;
    public static float[] waterfall_data;
    //public static int waterfall_width;
    public struct Display_Buffer
    {
        public static UInt16[] X_value = new UInt16[800];
        public static UInt16[] Y_value = new UInt16[800];
    }
}
public static class Waterfall_Master_Controls
{
    public static bool Debug_Display = false;
    public static bool Transmit_Mode = false;
    public static bool Monitor = false;
    public static int Log_retry_count = 0;
    public static long line_count = 0;
    public static byte No_Data_Received_Count = 0;
    public static bool No_Data = false;
    public const byte NO_DATA_LIMIT = 60;
    public static byte TX_On = 0;
    public static byte Previous_TX_On = 0;
    public static int Display_Delay_Count = 0;
    public static byte Init_Status_Count = 0;
    public const byte INIT_LIMIT = 2;
    public static string er;
    public static byte Delay_Start_Count = 0;
    public const byte DELAY_START_LIMIT = 254;
    public static bool System_Ready = true;
    public const int CMD_SET_X_POSITION = 0x3b;
    public const int CMD_SET_Y_POSITION = 0x3e;
    public static bool X_Position_Received = false;
    public static bool Y_Position_Received = false;
    public static int X_Position = 0;
    public static int Y_Position = 0;
    //public const byte TX_OFF = 0;
    //public const byte TX_ON = 1;
}
public static class Waterfall_oCode
{
    public static int DisplayFreq;
    public static short current_band = 20;
}
public static class Waterfall_Last_used
{
    public static char Current_mode = 'U';
    public static short Previous_Main_Band = 0;
    public struct B160
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B80
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B60
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B40
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B30
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B20
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B17
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B15
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B12
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B10
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct GEN
    {
        public static Int32 Freq = 10000000;
        public static char Mode = 'A';
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
    }
}
public static class Waterfall_Filter_control
{
    public static short Filter_High_Index = 4;
    public static short Filter_Low_Index = 4;
    public static short Previous_Filter_High_Index = 0;
    public static short Previous_Filter_Low_Index = 0;
    public static short Filter_TX_High_Index = 0;
    public static short Default_Filter_High_Index = 1;
    public static short Default_Filter_Low_Index = 4;
    public static short Default_Filter_CW_Index = 2;
    public static bool Band_Stack_Updating = false;
    public const byte CMD_SET_BW_LOCUT = 0xD0;
    public const byte CMD_SET_BW_HICUT = 0xD1;
    public const byte CMD_SET_CW_PITCH = 0xD2;
    public const byte CMD_SET_TX_HICUT = 0xD3;
    public const byte CMD_SET_CW_BW = 0xDB;
    public const byte CMD_SET_BW_LOCUT_DEFAULT = 0xDC;
    public const byte CMD_SET_BW_HICUT_DEFAULT = 0xDD;
    public const byte CMD_SET_CW_BW_DEFAULT = 0xDE;
    public static int CW_Pitch = 0;
    public static int CW_Bw = 0;
    public static int CW_Pitch_Index = 0;
}
public static class Waterfall_Panadapter_Controls
{
    public struct Buffer_0
    {
        public static UInt16[] X_value = new UInt16[800];
        public static UInt16[] Y_value = new UInt16[400];
    }
    public struct Buffer_1
    {
        public static UInt16[] X_value = new UInt16[800];
        public static UInt16[] Y_value = new UInt16[400];
    }
    public struct Display_Buffer
    {
        public static UInt16[] X_value = new UInt16[800];
        public static UInt16[] Y_value = new UInt16[800];
    }
    public static bool Monitor = false;
    public static bool GUI_Ready = false;
    public static int X_Scroll_Bar_value = 0;
    public const int Max_X = 400;
    public static char Previous_mode = 'B';
    public static bool Sequence_0_Complete = false;
    public static bool Sequence_1_Complete = true;
    public static bool Display_Operation_Complete = true;
    public static bool Display_buffer_ready = false;
    public static int XCVR_Freq = 0;
    public static int Display_freq;
    //public static int Updated_Frequency = 0;
    public static bool Freq_Set_By_Master = true;
    public static IPEndPoint txtarget;
    public static Socket txsocket;
    public static bool TX_Panadapter = false;
    public static bool Display_Panadatper = true;
    public static int Spectrum_Base_Line = 0;
    public static int Spectrum_Gain = 6000;
    public static int Drift = 0;
    public const byte CMD_SET_SPECTRUM_WATERFALL_FREQ = 0x91;
    public const byte CMD_SET_SPECTRUM_WATERFALL_MODE = 0x92;
    public const byte CMD_GET_SET_MSSDR_STATUS = 0xF5;
    public const byte CMD_SET_DISPLAY_FREQ = 0xBB;
    public const byte CMD_SET_MAIN_FREQ = 0xB6;
    public const byte CMD_GET_SET_PANADAPTER = 0xD5;
    public const byte CMD_SET_MAIN_MODE = 0xB7;
    public const byte CMD_SET_CW_PITCH = 0xD2;
    public const byte CMD_SET_STOP = 0xFF;
    public const byte CMD_SET_TX_ON = 0xBA;
    public const byte CMD_SET_DISPLAY_MODE = 0xB1;
    public const byte CMD_SET_MONITOR = 0x0D;
    /*public const byte CMD_GET_SET_PANADAPTER_SMOOTHING = 0xDA;
    public const byte CMD_GET_SET_PANADAPTER_STATUS = 0x83;
    public const byte CMD_GET_SET_PANADAPTER_FILL = 0x59;
    public const byte CMD_GET_SET_PANADAPTER_LINE = 0x5A;
    public const byte CMD_GET_SET_PANADAPTER_MARKER = 0x5B;
    public const byte CMD_GET_SET_PANADAPTER_BACKGROUND = 0x5D;
    public const byte CMD_GET_SET_PANADAPTER_CURSOR = 0x5E;
    public const byte CMD_GET_SET_PANADAPTER_REFRESH = 0x5F;
    public const byte CMD_GET_SET_PANADAPTER_GAIN = 0x85;
    public const byte CMD_GET_SET_PANADAPTER_BASE = 0x86;
    public const byte CMD_CW_SNAP_START = 0x6C;
    public const byte CMD_CW_SNAP_FINISHED = 0x6D;
    public const byte CMD_SET_CW_SNAP_FREQ = 0x67;
    public const byte CMD_SET_AUTO_SNAP_STATUS = 0xC9;
    public const byte CMD_SET_AUTO_SNAP_INDEX = 0xCA;
    public const byte CMD_SET_DRIFT = 0x35;*/

    public static byte Smoothing_Index = 0;
    public static byte Refresh_Index = 0;
    public static string Filter_Size_Name;
    public static string CW_Filter_Size_Name;
    public static int Filter_Index = 0;
    public static int Previous_Filter_Index = 0;
    public static double X_Position = 0;
    public static double Graph_Freq = 0;
    public static int Fine_Tune_Delta = 0;
    public static bool Fine_Tuning = false;
    public static bool view_grid = false;
    public static bool Reset_Freq = false;
    public static bool Anti_Alias = false;
    public static bool Previous_Anti_Alias = true;
    public static long Data_average = 0;
    public const int Data_recieve_limit = 50;
    public static bool Freq_zoom = false;
    public static bool Previous_Freq_zoom = false;
    public static bool Window_Minimized = false;
    public static int Width = 0;
    public static int Height = 0;
    public static int Start_X_Position = 0;
    public const byte WINDOW_STATE_NORMAL = 0;
    public const byte WINDOW_STATE_MINIMIZED = 1;
    public const byte WINDOW_BRING_TO_FRONT = 3;
    public const byte WINDOW_SEND_TO_BACK = 4;
    public const byte WINDOW_TOP_MOST = 2;
    public const byte WINDOW_MAIN_FULL_SCREEN = 5;
    public struct CW_Snap
    {
        public static bool CW_button = false;
        public static bool CW_check_box = false;
        public static bool CW_snap_status = false;
        public static System.Drawing.Color Button_Color = System.Drawing.Color.Black;
    }
    public struct Mouse_event
    {
        public static double x = 0;
        public static double y = 0;
        public static String Display_Freq;
        public static double User_Cursor_x = 0;
        public static double User_Cursor_y = 0;
        public static bool Mouse_Event = false;
    }
    public struct Freq_Bounds
    {
        public static int Low_Freq;
        public static int High_Freq;
        public static int Current_X_Min = 0;
        public static int Current_X_Max = 0;
    }
    public struct Auto_Snap
    {
        public static int Snap_Value = 0;
        public static bool Auto_Snap_Checkbox = false;
    }
}
#endregion Waterfall

#region Spectrum
public static class Spectrum_Panadapter_Controls
{
    public static UInt16[] Receive_buffer_0 = new UInt16[800];
    public static UInt16[] Receive_buffer_1 = new UInt16[800];
    public struct Buffer_0
    {
        public static UInt16[] X_value = new UInt16[800];
        public static UInt16[] Y_value = new UInt16[400];
    }
    public struct Buffer_1
    {
        public static UInt16[] X_value = new UInt16[800];
        public static UInt16[] Y_value = new UInt16[400];
    }
    public struct Display_Buffer
    {
        public static UInt16[] X_value = new UInt16[800];
        public static UInt16[] Y_value = new UInt16[800];
    }
    public struct Cursor_Controls
    {
        public static String Cursor_freq;
    }
    public struct Panadapter_Colors
    {
        public static System.Drawing.Color Line_Color;
        public static System.Drawing.Color Previous_Line_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Fill_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Previous_Fill_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Background_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Previous_Background_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Marker_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Previous_Marker_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Previous_Cursor_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Cursor_Color = System.Drawing.Color.Azure;
    }
    public static ulong Call_count = 0;
    public static Bitmap bm;
    public static bool GUI_Ready = false;
    public static int X_Scroll_Bar_value = 0;
    public static ulong Spectrum_Not_Complete = 0;
    public const int Max_X = 400;
    public static char Previous_mode = 'B';
    public static bool Sequence_0_Complete = false;
    public static bool Sequence_1_Complete = true;
    //public static bool Display_Operation_Complete = true;
    public static int Frequency = 0;
    public static int Display_freq;
    //public static int Updated_Frequency = 0;
    public static bool Freq_Set_By_Master = true;
    public static bool TX_Panadapter = false;
    public static bool Display_Panadatper = true;
    public static int Spectrum_Base_Line = 0;
    public static int Spectrum_Gain = 6000;
    public static int Drift = 0;
    public const byte CMD_SET_SPECTRUM_WATERFALL_FREQ = 0x91;
    public const byte CMD_SET_SPECTRUM_WATERFALL_MODE = 0x92;
    public const byte CMD_GET_SET_MSSDR_STATUS = 0xF5;
    public const byte CMD_GET_SET_PANADAPTER = 0xD5;
    public const byte CMD_SET_MAIN_MODE = 0xB7;
    public const byte CMD_SET_DISPLAY_FREQ = 0xBB;
    public const byte CMD_SET_MAIN_FREQ = 0xB6;
    public const byte CMD_SET_CW_PITCH = 0xD2;
    public const byte CMD_SET_STOP = 0xFF;
    public const byte CMD_SET_TX_ON = 0xBA;
    public const byte CMD_SET_DISPLAY_MODE = 0xB1;
    public const byte CMD_SET_SPECTRUM_VIEW_GRID = 0x21;
    public const byte CMD_SET_SPECTRUM_SHARP = 0x22;
    public const byte CMD_SET_STEP_VALUE = 0xCE;
    public const byte CMD_SET_MONITOR = 0x0D;
    public static bool Monitor = false;
    public static byte Smoothing_Index = 0;
    public static byte Refresh_Index = 0;
    public static string Filter_Size_Name;
    public static string CW_Filter_Size_Name;
    public static int Filter_Index = 0;
    public static int Previous_Filter_Index = 0;
    public static double X_Position = 0;
    public static double Graph_Freq = 0;
    public static int XCVR_Freq = 0;
    public static int XCVR_Scroll_Freq = 0;
    public static byte XCVR_Step_Index = 0;
    public static int XCVR_Freq_Multiplier = 0;
    public static int Fine_Tune_Delta = 0;
    public static bool Fine_Tuning = false;
    public static bool view_grid = false;
    public static bool Reset_Freq = false;
    public static bool Anti_Alias = false;
    public static bool Previous_Anti_Alias = true;
    public static long Data_average = 0;
    public const int Data_recieve_limit = 50;
    public static bool Freq_zoom = false;
    public static bool Previous_Freq_zoom = false;
    public static int max_y = 0;
    public static bool Display_Cursor = false;
    public static int Width = 0;
    public static int Height = 0;
    public static int Start_X_Position = 0;
    public static bool Cursor_Moved = false;
    public static bool Pan_Graph = false;
    public const byte WINDOW_STATE_NORMAL = 0;
    public const byte WINDOW_STATE_MINIMIZED = 1;
    public const byte WINDOW_BRING_TO_FRONT = 3;
    public const byte WINDOW_SEND_TO_BACK = 4;
    public const byte WINDOW_TOP_MOST = 2;
    public const byte WINDOW_MAIN_FULL_SCREEN = 5;
    public struct CW_Snap
    {
        public static bool CW_button = false;
        public static bool CW_check_box = false;
        public static bool CW_snap_status = false;
        public static System.Drawing.Color Button_Color = System.Drawing.Color.Black;
    }
    public struct Mouse_event
    {
        public static double x = 0;
        public static double y = 0;
        public static String Display_Freq;
        public static double User_Cursor_x = 0;
        public static double User_Cursor_y = 0;
        public static bool Mouse_Event = false;
    }
    public struct Freq_Bounds
    {
        public static int Low_Freq;
        public static int High_Freq;
        public static int Current_X_Min = 0;
        public static int Current_X_Max = 0;
    }
    public struct Auto_Snap
    {
        public static int Snap_Value = 0;
        public static bool Auto_Snap_Checkbox = false;
    }
}
public static class Spectrum_Master_Controls
{
    public static bool Debug_Display = false;
    public static bool Transmit_Mode = false;
    public static int Log_retry_count = 0;
    public static long line_count = 0;
    public static byte No_Data_Received_Count = 0;
    public static bool No_Data = false;
    public const byte NO_DATA_LIMIT = 60;
    public static byte TX_On = 0;
    public static byte Previous_TX_On = 0;
    public static int Display_Delay_Count = 0;
    public static ulong Display_Spectrum_BG_Count = 0;
    public static ulong Previous_Display_Spectrum_BG_Count = 0;
    public static bool spectrum_initialized = false;
    public static bool Log_File_Busy = false;
    public static byte Init_Retry = 0;
    public const byte INIT_RETRY_LIMIT = 2;
    public static string er;
    public static byte Delay_Start_Count = 0;
    public const byte DELAY_START_LIMIT = 254;
    public static bool System_Ready = true;
    public const int CMD_SET_X_POSITION = 0x3b;
    public const int CMD_SET_Y_POSITION = 0x3e;
    public static bool X_Position_Received = false;
    public static bool Y_Position_Received = false;
    public static int X_Position = 0;
    public static int Y_Position = 0;
}
public static class Spectrum_oCode
{
    public static int DisplayFreq;
    public static short current_band = 20;
    public struct iniStates
    {
        public static int DLL_PORT;
        public static int GUI_PORT;
        public static string DLL_IP;
        public static string GUI_IP;
    }
}
public static class Spectrum_Last_used
{
    public static char Current_mode = 'U';
    public static short Previous_Main_Band = 0;
    public struct B160
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B80
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B60
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B40
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B30
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B20
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B17
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B15
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B12
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct B10
    {
        public static Int32 Freq;
        public static char Mode;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public static short AM_power = 50;
        public static short SSB_power = 50;
        public static short CW_power = 50;
    }
    public struct GEN
    {
        public static Int32 Freq = 10000000;
        public static char Mode = 'A';
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
    }
}
public static class Spectrum_Filter_control
{
    //These are the default filter values
    public static short Filter_High_Index = 4;
    public static short Filter_Low_Index = 4;
    public static short Previous_Filter_High_Index = 0;
    public static short Previous_Filter_Low_Index = 0;
    public static short Filter_TX_High_Index = 1;
    public static short Default_Filter_High_Index = 1;
    public static short Default_Filter_Low_Index = 4;
    public static short Default_Filter_CW_Index = 2;
    public static bool Band_Stack_Updating = false;
    public const byte CMD_SET_BW_LOCUT = 0xD0;
    public const byte CMD_SET_BW_HICUT = 0xD1;
    public const byte CMD_SET_CW_PITCH = 0xD2;
    public const byte CMD_SET_TX_HICUT = 0xD3;
    //#define CMD_SET_BW_HICUT 0xD1
    public const byte CMD_SET_CW_BW = 0xDB;
    public const byte CMD_SET_BW_LOCUT_DEFAULT = 0xDC;
    public const byte CMD_SET_BW_HICUT_DEFAULT = 0xDD;
    public const byte CMD_SET_CW_BW_DEFAULT = 0xDE;
    public static int CW_Pitch = 0;
    public static int CW_Bw = 0;
    public static int CW_Pitch_Index = 0;
 public struct Markers
    {
        public static int MARKER_OUT_OF_RANGE = 1000;
        public static int DISPLAY_BANDWIDTH = 72000;
        public static int TX_DISPLAY_BANDWITH = 5500;
        public const int AM_RX_OFFSET = -2;
        public static int STARTUP_MAX_PIXELS = 800;
        public static int Display_Center = 399;
        public static int band_marker_low = 1;
        public static int band_marker_high = 2;
        public static int band_center = 0;
        public static int CW_Offset = 0;
        public static Color cursor_color = Color.White;
        public static Pen cursor_pen;
        public static int Waterfall_Marker_Color_index = 0;
        public static int Window_Size = 0;
        public static int G_band_marker_low = 1;
        public static int G_band_marker_high = 2;
        public static int G_band_center = 0;

    }
}
#endregion Spectrum

#region Solidus Controls
public static class Solidus_Settings
{
    public const byte CMD_SET_DISPLAY_MODE = 0xB1;
    public const byte WINDOW_STATE_NORMAL = 0;
    public const byte WINDOW_STATE_MINIMIZED = 1;
    public const byte WINDOW_BRING_TO_FRONT = 3;
    public const byte WINDOW_SEND_TO_BACK = 4;
    public const byte WINDOW_TOP_MOST = 2;
    public const byte WINDOW_MAIN_FULL_SCREEN = 5;

    //Attached Transceiver
    public const byte TRANCEIVER_SOLIDUS = 1;
    public const byte FORTIS_MFC = 3;
    public const byte FORTIS_METER = 4;
    public const byte FORTIS_MFC_METER = 5;
    public const byte GEMINUS = 6;
    public const byte MSCC_PC = 7;

    //Attached Hardware devices
    public const byte MSCC_PC_MFC = 8;
    public const byte MSCC_PC_METER = 9;
    public const byte MSCC_PC_MFC_METER = 10;
    public static bool Potentia = false;

    public static byte Transceiver_Type = 0;
    public static byte Hardware_Devices = 0;
    public static byte Previous_Hardware_Devices = 0;
    public static bool Geminus = false;
    public static byte Previous_Tranceiver_Type = 10;
    public static bool Solidus_Status = false;
    public static bool Solidus_Status_Set = false;
    public static bool Mia_Status = false;
    public static bool Mia_Status_Set = false;
    public static int QRP_Tune_Power = 0;
    public static int Previous_Freq_Step = 0;
    public static int Freq_Step = 0;
    public static short Freq_Digit = 30;

    public static byte Shutdown = 0;
    public static int Time_Display = 0;
    public static bool RPi_Configured = false;
    public static int Band_Change_Tune = 0;
    public static int Auto_Zero = 0;
    public static bool New_Freq_Pointer = false;
    public static int Auto_Start = 0;
    public static class Antenna_Switch_Control
    {
        public class Switch_State
        {
            public static bool M160 = false;
            public static bool M80 = false;
            public static bool M60 = false;
            public static bool M40 = false;
            public static bool M30 = false;
            public static bool M20 = false;
            public static bool M17 = false;
            public static bool M15 = false;
            public static bool M12 = false;
            public static bool M10 = false;
            public static bool M630 = false;
            public static bool M2200 = false;
        }
        public static bool State_Change = false;
        public static byte Previous_Band = 0;
        public static byte Antenna_Switch_Value = 0;
        public static short GEN_Antenna_Switch = 0;
        public static byte GEN_Antenna_Value = 160;
    }
    public static class Stop_States
    {
        public const byte STOP_NORMAL = 0;
        public const byte STOP_PROFICIO = 1;
        public const byte STOP_MFC = 2;
        public const byte STOP_SHUTDOWN = 3;
        public const byte STOP_PROFICIO_COMMS = 4;
        public const byte STOP_LOGFILE_FAILED = 5;
        public const byte STOP_PROFICIO_SERIAL_NUMBER = 6;
    }
    public static class Volume_Settings
    {
        public static int Volume_ATTN_Index = 0;
        public static int Temp = 50;
        public static int Digital_Volume_ATTN_index = 0;
        public static int Previous_Speaker_Volume = 0;
        public static int Master_Speaker_Volume = 0;
        public static int Speaker_Volume = 0;
        public static int Speaker_Mute = 0;
        public static bool Speaker_MutED = false;
        public static int Speaker_Voice_Volume = 0;
        public static int Mic_Volume = 0;
        public static int Mic_Voice_Volume = 0;
        public static int Mic_Digital_Volume = 0;
        public static int Mic_Mute = 0;
        //public static int Mic_Pre_Gain = 0;
        public static int Mic_Mode = 0;
        public static bool Mic_Is_Digital = false;
        public static int Previous_Mode = 0;
        public static bool Set_By_Server = false;
    }
    public static class Amplifier_Values
    {
        public static int Power_Output = 0;
        public static int Previous_Power_Output = 0;
        public static int Power_Calibration = 0;
        public static int Previous_Power_Calibration = 0;
    }
}
#endregion Solidus_Settings

#region Band_Bank Controls
public static class Band_Bank
{
    public static byte Selected_Bank = 0;
    public const byte HAM_BANK = 0;
    public const byte GEN_BANK = 1;
    public const byte GEMINUS_BANK = 2;
    public static byte Main_Band_Button_Index = 0;
    public static class HAM_Last_Used
    {
        public static Int32 Freq = 2500000;
        public static char Mode = 'A';
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
    }
    public static class General_Bank
    {
        public static bool General_Bank_Selected = false;
        public static byte Band = 0;
        public static byte Antenna_ON_OFF = 0;
        public const byte WWV2_5 = 0;
        public const byte WWV5 = 1;
        public const byte WWV10 = 2;
        public const byte WWV20 = 3;
        public const byte WWV15 = 8;
        public const byte CHU1 = 4;
        public const byte CHU2 = 5;
        public const byte RWM = 6;
        public const byte GEN = 7;
        public static class Last_Used
        {
            public static class WWV2_5
            {
                public const Int32 Freq = 2500000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
            }
            public static class WWV5
            {
                public const Int32 Freq = 5000000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
            }
            public static class WWV10
            {
                public const Int32 Freq = 10000000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
            }

            public static class WWV15
            {
                public const Int32 Freq = 15000000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
            }
            public static class WWV20
            {
                public const Int32 Freq = 20000000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
            }
            public static class CHU1
            {
                public const Int32 Freq = 3330000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
            }
            public static class CHU2
            {
                public const Int32 Freq = 7850000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
            }
            public static class RWM
            {
                public const Int32 Freq = 9996000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
            }
            public static class GEN
            {
                public static Int32 Freq = 10000000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
            }
        }
    }
    public static class Geminus_Bank
    {
        public static bool Geminus_Selected = true;
        public static byte Band = 0;
        public static byte Normal_Band = 0;
        public static byte Antenna_ON_OFF = 0;
        public static byte Current_Band = 0;
        public const byte B2200 = 0;
        public const byte B630 = 1;
        public const byte GEN = 2;
        public const byte BCN = 3;
        public static byte Becon_Band = 0;
        public static byte Stack_Index = 0;
        public static class Last_Used
        {
            public static class B2200
            {
                public static Int32 Freq = 135750;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
                //public static Int32 Freq_A = 1407600;
                //public static Int32 Freq_B = 1407600;
                //public static Int32 Freq_C = 1407600;
            }
            public static class B630
            {
                public static Int32 Freq = 477000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
                public static Int32 Freq_A = 1407600;
                public static Int32 Freq_B = 1407600;
                public static Int32 Freq_C = 1407600;
            }
            public static class GEN
            {
                public static Int32 Freq = 477000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
                public static Int32 Freq_A = 1407600;
                public static Int32 Freq_B = 1407600;
                public static Int32 Freq_C = 1407600;
            }
            public static class Beacon_0
            {
                public static Int32 Freq = 198000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
                public static Int32 Freq_A = 1407600;
                public static Int32 Freq_B = 1407600;
                public static Int32 Freq_C = 1407600;
            }
            public static class Beacon_1
            {
                public static Int32 Freq = 660000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
                public static Int32 Freq_A = 1407600;
                public static Int32 Freq_B = 1407600;
                public static Int32 Freq_C = 1407600;
            }
            public static class Beacon_2
            {
                public static Int32 Freq = 880000;
                public static char Mode = 'A';
                public static short Filter_High_Index = 2;
                public static short Filter_Low_Index = 4;
                public static short Filter_CW_index = 2;
                public static short Antenna_Switch = 0;
                public static Int32 Freq_A = 1407600;
                public static Int32 Freq_B = 1407600;
                public static Int32 Freq_C = 1407600;
            }
        }
    }
}
#endregion 

#region VFO Controls
public static class VFO_Controls
{
    public const byte VFOA = 0;
    public const byte VFOB = 1;
    public const byte CMD_SET_VFO = 0xF2;
    public const byte CMD_SET_SPLIT = 0x31;
    public const byte CMD_SET_SPLIT_RX_FREQ = 0x34;
    public const byte CMD_SET_SPLIT_TX_FREQ = 0x39;
    public static bool VFO_toggle = true;
    public static byte vfo = VFOA;
    public static byte previous_vfo = VFOA;
    public static bool Update_VFO_Equal = false;
    public static byte Update_Tic = 0;
    public const byte UPDATE_TIC_LIMIT = 2;
    public const short B160 = 160;
    public const short B80 = 80;
    public const short B60 = 60;
    public const short B40 = 40;
    public const short B30 = 30;
    public const short B20 = 20;
    public const short B17 = 17;
    public const short B15 = 15;
    public const short B12 = 12;
    public const short B10 = 10;
    public class Current_Band_Set
    {
        public static byte vfo = 0;
        public static int band = 0;
    }
    public class Split
    {
        public static bool Split_toggle = false;
        public static Int32 RX_freq = 0;
        public static Int32 TX_freq = 0;
        public static short RX_band = 0;
        public static short TX_band = 0;
    }
}
public class VFOA_Master_Controls
{
    public static int oldTransverter = 0;
    public static bool transverter_warning_accepted = false;
    public static bool transverter_warning_displayed = false;
    public static bool trans_on = false;
    public static short current_band = 0;
    public static short previous_main_band = 200;
    public static bool gen_band_active = false;
    public static bool gem_band_active = false;
    public static Int32 DisplayFreq = 1407600;
    public static short Freq_Tune_Index = 0;
    public static short Last_band = 0;
}
public class VFOB_Master_Controls
{
    public static int oldTransverter = 0;
    public static bool transverter_warning_accepted = false;
    public static bool transverter_warning_displayed = false;
    public static bool trans_on = false;
    public static short current_band = 0;
    public static short previous_main_band = 200;
    public static bool gen_band_active = false;
    public static bool gem_band_active = false;
    public static Int32 DisplayFreq = 1407600;
    public static short Freq_Tune_Index = 0;
    public static short Last_band = 0;
}
#endregion

#region Frequency Controls
public class VFOA_Last_Used
{
    public static bool Update_Band_Stack = false;
    public struct Last_used
    {
        public static char Current_mode;
        public struct B160
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 1800000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 1900000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 2000000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
        public struct B80
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 3500000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 3800000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 4000000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
        public struct B60
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 5330500;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 5357000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 5403500;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
        public struct B40
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 7000000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 7175000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 7300000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
        public struct B30
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 10100000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 10125000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 10150000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
        public struct B20
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 14000000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 14225000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 14300000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
        public struct B17
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 18068000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 18110000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 18168000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
        public struct B15
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 21000000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 21275000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 21450000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
        public struct B12
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 24890000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 24930000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 24990000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
        public struct B10
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 28000000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 28300000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 29700000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
        public struct GEN
        {
            public static Int32 Freq = 10000000;
            public static char Mode = 'A';
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public struct Stacks
            {
                public static byte Stack_Add_Index = 0;
                public static byte Stack_Select_Index = 0;
                public struct Stack_0
                {
                    public static Int32 Freq = 1800000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_1
                {
                    public static Int32 Freq = 1900000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
                public struct Stack_2
                {
                    public static Int32 Freq = 2000000;
                    public static short Filter_High_Index = 2;
                    public static short Filter_Low_Index = 4;
                    public static short Filter_CW_index = 2;
                    public static char Mode;
                }
            }
        }
    }
}
public class VFOB_Last_Used
{
    public static bool Update_Band_Stack = false;
    public static bool Update_VFO_Equal = false;
    public static class Last_used
    {
        public static char Current_mode;
        public static short Previous_Main_Band = 0;
        public static byte Stack_Index = 0;
        public static short Filter_High_Index = 2;
        public static short Filter_Low_Index = 4;
        public static short Filter_CW_index = 2;
        public struct B160
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
        }
        public struct B80
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
        }
        public struct B60
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
            public static byte Stack_Index = 0;
        }
        public struct B40
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
        }
        public struct B30
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
        }
        public struct B20
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
        }
        public struct B17
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
        }
        public struct B15
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
        }
        public struct B12
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
        }
        public struct B10
        {
            public static Int32 Freq;
            public static char Mode;
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
            public static short AM_power = 50;
            public static short SSB_power = 50;
            public static short CW_power = 50;
            public static short TX_HI_Cut_Index = 1;
        }
        public struct GEN
        {
            public static Int32 Freq = 10000000;
            public static char Mode = 'A';
            public static short Filter_High_Index = 2;
            public static short Filter_Low_Index = 4;
            public static short Filter_CW_index = 2;
        }
    }
}
#endregion 

#region Transceiver_Model_Settings
public static class Transceiver_Model_Settings
{
    public const byte CMD_SET_DISPLAY_MODE = 0xB1;
    public const byte TRANCEIVER_SOLIDUS = 1;
    public const byte TRANSCEIVER_FORTIS = 2;
    public const byte FORTIS_MFC = 3;
    public const byte FORTIS_METER = 4;
    public const byte FORTIS_MFC_METER = 5;
    public const byte FORTIS_GEMINUS = 6;
    public const byte MKII = 10;
    public static byte Transceiver_Type = 0;
    public static byte Fortis_Devices = 0;
    public static byte Previous_Fortis_Devices = 0;
    public static bool Geminus = false;
    public static byte Previous_Tranceiver_Type = 10;
    public static bool Solidus_Status = false;
    public static bool Solidus_Status_Set = false;
    public static bool Options_Status = false;
    public static bool Mia_Status_Set = false;
    public static int QRP_Tune_Power = 0;
    public static int Previous_Freq_Step = 0;
    public static int Freq_Step = 0;
    public static short Freq_Digit = 30;
    public static byte Shutdown = 0;
    public static int Time_Display = 0;
    public static bool Client_Initialized = false;
    public static int Auto_Zero = 0;
    public static bool New_Freq_Pointer = false;
    public static int Auto_Start = 0;
    public static class Antenna_Switch_Control
    {
        public class Switch_State
        {
            public static bool M160 = false;
            public static bool M80 = false;
            public static bool M60 = false;
            public static bool M40 = false;
            public static bool M30 = false;
            public static bool M20 = false;
            public static bool M17 = false;
            public static bool M15 = false;
            public static bool M12 = false;
            public static bool M10 = false;
            public static bool M630 = false;
            public static bool M2200 = false;
        }
        public static bool State_Change = false;
        public static byte Previous_Band = 0;
        public static byte Antenna_Switch_Value = 0;
        public static short GEN_Antenna_Switch = 0;
        public static byte GEN_Antenna_Value = 160;
    }
    public static class Stop_States
    {
        public const byte STOP_NORMAL = 0;
        public const byte STOP_PROFICIO = 1;
        public const byte STOP_MFC = 2;
        public const byte STOP_SHUTDOWN = 3;
        public const byte STOP_PROFICIO_COMMS = 4;
        public const byte STOP_LOGFILE_FAILED = 5;
        public const byte STOP_PROFICIO_SERIAL_NUMBER = 6;
    }
    public static class Volume_Settings
    {
        public static int Volume_ATTN_Index = 0;
        public static int Temp = 50;
        public static int Digital_Volume_ATTN_index = 0;
        public static int Previous_Speaker_Volume = 0;
        public static int Master_Speaker_Volume = 0;
        public static int Speaker_Volume = 0;
        public static int Speaker_Mute = 0;
        public static bool Speaker_MutED = false;
        public static int Speaker_Voice_Volume = 0;
        public static int Mic_Volume = 0;
        public static int Mic_Voice_Volume = 0;
        public static int Mic_Digital_Volume = 0;
        public static int Mic_Mute = 0;
        public static int Mic_Pre_Gain = 0;
        public static int Mic_Digital_Pre_Gain = 0;
        public static int Mic_Mode = 0;
        public static bool Mic_Is_Digital = false;
        public static int Previous_Mode = 0;
        public static bool Set_By_Server = false;
    }
    public static class Amplifier_Values
    {
        public static int Power_Output = 0;
        public static int Previous_Power_Output = 0;
        public static int Power_Calibration = 0;
        public static int Previous_Power_Calibration = 0;
    }
}
#endregion Transceiver_Model_Settings

#region MFC_Controls
public static class Tuning_Knob_Controls
{
    public static int VERSION = 1;
    public static bool MFC_Initialized = false;
    public static bool Continue = true;
    public static byte Initialize_State = 0;
    public static byte Initialize_Count = 0;
    public static byte Send_State = 0;
    public static bool Send_Finished = false;
    //public static FTDI Device = new FTDI();
    //public static FTDI.FT_STATUS Status;
    public static bool encoder_A = false;
    public static bool encoder_B = false;
    public static UInt16 store = 0;
    public static byte prevNextCode = 0;
    public static sbyte[] rec_enc_table = { 0, 1, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, 0 };
    //public static sbyte[] switch_table = { 20, 20, 20, 20 };
    public static sbyte[] previous_switch_table = { 0, 0, 0, 0, 0 };
    public const sbyte KNOB_SWITCH = 0;
    public const sbyte LEFT_SWITCH = 1;
    public const sbyte MIDDLE_SWITCH = 2;
    public const sbyte RIGHT_SWITCH = 3;
    public const sbyte PTT_SWITCH = 4;

    public static bool Open = false;
    public static byte[] sentBytes = new byte[2];
    public static bool On = false;
    public static uint Received_Bytes = 0;
    public static bool Write_failure = false;
    public static bool Read_failure = false;
    public static byte Previous_relays_States = 0;
    public static int loop_count = 0;
    public static int previous_loop_count = 0;
    public static int loop_count_limit = 20;
    public static int Freq = 0;
    //public static int Volume = 0;

    //public static bool MFC_volume_active = false;
    public static byte Set_Band_loop_count = 0;
    public static byte Switches_Control = 0;
    public const byte CMD_SET_TRANSCEIVER_DISPLAY = 0xCC;
    public const byte CMD_SET_STAR = 0xCD;
    public const byte CMD_SET_STEP_VALUE = 0xCE;

    public static byte Knob_switch_function = 0;
    public static byte Knob_switch = 0x80;

    public static byte Button_left_function = 0;
    public const byte Button_left_switch = 0x10;

    public static byte Button_middle_function = 0;
    public const byte Button_middle_switch = 0x08;

    public static byte Button_right_function = 0;
    public const byte Button_right_switch = 0x04;

    public static byte PTT_switch_function = 0;
    public const byte PTT_switch = 0x01;

    public static class Initialize
    {
        public static int version = 0;
        public static int knob_switch = 0;
        public static int left_switch = 0;
        public static int middle_switch = 0;
        public static int right_switch = 0;
        public static int ptt_switch = Tuning_Knob_Controls.Button_Function_List.PTT_REAR_CONNECTOR;
        public static int state = 0;
    }
    public static class Button_Text
    {
        public static string Button_left_text;
        public static string Button_middle_text;
        public static string Button_right_text;
        public static string Knob_text;
    }
    public static class Freq_Queue
    {
        public const int MAX_COMMAND_QUEUE = 1000;
        public const int QUEUE_FAILED = 2000;
        public const byte QUEUE_SUCCESS = 1;
        public const byte QUEUE_BUSY = 2;
        public const byte QUEUE_CHECK_DELAY = 1;
        public const byte QUEUE_PROCESS_DELAY = 25;
        public const byte DISPLAY_COUNT = 2;
        public static int[] E_freq_queue = new int[MAX_COMMAND_QUEUE];
        public static int E_freq_queue_front = -1;
        public static int E_freq_queue_rear = -1;
        public static int E_queue_count = 0;
        public static bool E_queue_busy = false;
    }
    public static class Star_Position
    {
        public static byte Knob = 0;
        public static byte Left = 0;
        public static byte Middle = 0;
        public static byte Right = 0;
    }
    public static class Button_Function_List
    {
        public const byte NONE = 0;
        public const byte STEP = 1;
        public const byte PTT = 2;
        public const byte TUNE = 3;
        public const byte MODE = 4;
        public const byte RIT_MODE = 5;
        public const byte BAND = 6;
        public const byte FREQ_VOLUME = 7;
        public const byte CW_BW = 8;
        public const byte HI_CUT = 9;
        public const byte FAVORITES = 10;
        public const byte PTT_REAR_CONNECTOR = 12;
        public const byte MAX_FUNCTIONS = 11;
        //public const byte VOLUME = 12;
    }
    public static class Active_Functions
    {
        public static bool Freq_Active = false;
        public static bool RIT_Offset_Active = false;
        public static bool Volume_Active = false;
    }
    public static class RIT_OFFSET_Function
    {
        public static bool Switch_Toggle = false;
        public static bool Action_Toggle = false;
        public static bool RIT_Active = false;
        public static bool RIT_Slider_Active = false;
        public static int RIT_Offset_Value = 0;
        public static int RIT_Main_Offset_Value = 0;
        public static int RIT_Max_Offset_Value = 0;
        public static int RIT_Min_Offset_Value = 0;
        public static int RIT_Step = 0;
    }
    public static class Freq_Function
    {
        public static bool Switch_Toggle = false;
        public static bool Action_Toggle = false;
        public static bool Active = false;
        public static bool First_Pass = true;
    }
    public static class Favs_Function
    {
        public static bool Switch_Toggle = false;
        public static bool Action_Toggle = false;
    }
    public static class Step_Function
    {
        public static bool Switch_Toggle = false;
        public static int Step_increment = 0;
        public static int Multiplier = 0;
    }
    public static class CW_BW_Function
    {
        public static bool Switch_Toggle = false;
        public static int BW_index = 0;
    }
    public static class CW_HI_CUT_Function
    {
        public static bool Switch_Toggle = false;
        public static int HI_CUT_index = 0;
    }
    public static class Band_Function
    {
        public static bool Switch_Toggle = false;
    }
    public static class Tune_Function
    {
        public static bool Switch_Toggle = false;
        public static bool Action_Toggle = false;
    }
    public static class PTT_Function
    {
        public static bool Switch_Toggle = false;
        public static bool Action_Toggle = false;
    }
    public static class PTT_Function_Rear
    {
        public static bool Switch_Toggle = false;
        public static bool Action_Toggle = false;
    }
    public static class RIT_Function
    {
        public static bool Switch_Toggle = false;
        public static bool Action_Toggle = false;
    }
    public static class Mode_Function
    {
        public static bool Switch_Toggle = false;
    }
    public static class Volume_Function
    {
        public static bool Switch_Toggle = false;
        public static bool Action_Toggle = true;
        public static bool Volume_Slider_Active = false;
        public static int Volume = 0;
        public static bool Volume_active = false;
        public static int Max_volume = 0;
    }
}
#endregion MFC_Controls

#region Relay_Board_Controls
public static class Relay_Board_Controls
{
    //public static FTDI Device = new FTDI();
    //public static FTDI.FT_STATUS Status;
    public static bool Open = false;
    public static byte[] sentBytes = new byte[2];
    public static bool On = false;
    public static byte Previous_Relay = 0;
    public static uint Received_Bytes = 0;
    public static bool Write_failure = false;
}
#endregion

#region Noise_Controls
public static class NB_Controls
{
    public static bool NB_Button_On = false;
    public static bool NB_Main_Button_On = false;
    public static int NB_Pulse_Width = 0;
    public static int NB_Threshold = 0;
    public const byte NB_ENABLE = 0x80;
    public const byte NB_PULSE_WIDTH = 0x81;
    public const byte NB_THRESHOLD = 0x82;
}

public static class NR_Controls
{
    public static bool NR_Button_On = false;
    public static int NR_Value = 0;
}
#endregion

#region Favorites_Controls
public static class Favorites_Controls
{
    public static String Fav_Name;
    public const byte CMD_SET_FAVS_UPDATE = 0xC1;
    public const byte CMD_GET_FAVS = 0xC2;
    public const byte CMD_SET_FAVS_DELETE = 0xC4;
    public const byte CMD_SET_FAVS_NAME = 0xC8;
    public static bool Name_Entered = false;
    public static bool Display_Keyboard = false;
    public static bool Keyboard_displayed = false;
    public static bool Sorted = false;
    public static bool Delete = false;
    public static bool Update = false;
    public static bool Auto_Tune_Inhibit = false;
    public static int Previous_Auto_Tune_Band = 20;
    public static class Band_Defines
    {
        public const int B10 = 0;
        public const int B12 = 1;
        public const int B15 = 2;
        public const int B17 = 3;
        public const int B20 = 4;
        public const int B30 = 5;
        public const int B40 = 6;
        public const int B60 = 7;
        public const int B80 = 8;
        public const int B160 = 9;
    }
    public struct Record
    {
        public String name;
        public String freq;
        public String mode;
        public int hi_cut;
        public int cw_bw;
        public int tx_hi_cut;
        public int index;
    }
    public static class Favs_Records
    {
        //public static Record[] Fav_Record = new Favorites_Controls.Record[10];
        public static Record[] B160;
        public static Record[] B80;
        public static Record[] B60;
        public static Record[] B40;
        public static Record[] B30;
        public static Record[] B20;
        public static Record[] B15;
        public static Record[] B17;
        public static Record[] B12;
        public static Record[] B10;
    }
    public static int B10_Count = 0;
    public static int B12_Count = 0;
    public static int B15_Count = 0;
    public static int B17_Count = 0;
    public static int B20_Count = 0;
    public static int B30_Count = 0;
    public static int B40_Count = 0;
    public static int B60_Count = 0;
    public static int B80_Count = 0;
    public static int B160_Count = 0;
    public static int Index_Count = 0;
}
#endregion Favorites_Controls

#region Rit_Controls

public class RIT
{
    public static class Rit_Controls
    {
        public static int Offset = 0;
        public static bool Update_RIT = true;
        public static int RIT_Scroll_Bar_Value = 0;
        public const int RIT_SCROLL_BAR_MAX_VALUE = 1000;
        public const int RIT_SCROLL_BAR_MIN_VALUE = -1000;
        public static int RIT_Freq;
        public static bool RIT_On = false;
        public const byte CMD_SET_RIT_FREQ = 0x89;
        public const byte CMD_SET_RIT_STATUS = 0x8A;
        public static int RIT_Step_Index = 0;
        public static int RIT_Limits = 0;
        public static int RIT_Offset_From_Server = 0;
        public static int Previous_Rit_Offset_From_Server = 0;
        public static bool RIT_Scroll_Bar_Status = true;
    }
}
#endregion

#region Panadapter_Controls
public static class Panadapter_Controls
{
    public struct Buffer_0
    {
        public static UInt16[] X_value = new UInt16[800];
        public static UInt16[] Y_value = new UInt16[400];
    }
    public struct Buffer_1
    {
        public static UInt16[] X_value = new UInt16[800];
        public static UInt16[] Y_value = new UInt16[400];
    }
    public struct Display_Buffer
    {
        public static UInt16[] X_value = new UInt16[800];
        public static UInt16[] Y_value = new UInt16[800];
    }
    public struct Filter_Markers
    {
        public static int MARKER_OUT_OF_RANGE = 1000;
        public static int DISPLAY_BANDWIDTH = 72000;
        public static int STARTUP_MAX_PIXELS = 800;
        public static int Window_Size = 0;
        public static int Display_Center = 399;
        public static int G_band_marker_low = 1;
        public static int G_band_marker_high = 2;
        public static int G_band_center = 0;
        public static int CW_Offset = 0;
    }

    public struct Panadapter_Colors
    {
        public static System.Drawing.Color Line_Color;
        public static System.Drawing.Color Previous_Line_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Fill_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Previous_Fill_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Background_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Previous_Background_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Marker_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Previous_Marker_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Previous_Cursor_Color = System.Drawing.Color.Azure;
        public static System.Drawing.Color Cursor_Color = System.Drawing.Color.Azure;
    }
    public static int X_Scroll_Bar_value = 0;
    public static int Max_X = 400;
    public static char Previous_mode = 'B';
    public static bool Sequence_0_Complete = false;
    public static bool Sequence_1_Complete = true;
    public static bool Display_Operation_Complete = true;
    public static bool Display_buffer_ready = false;
    public static int Frequency = 0;
    public static int Display_freq;
    //public static int Updated_Frequency = 0;
    public static bool Freq_Set_By_Master = true;
    public static IPEndPoint txtarget;
    public static Socket txsocket;
    public static bool TX_Panadapter = false;
    public static bool Display_Panadatper = true;
    public static int Spectrum_Base_Line = 0;
    public static int Spectrum_Gain = 6000;
    public static int Drift = 0;
    public const byte CMD_GET_SET_PANADAPTER = 0xD5;
    public const byte CMD_GET_SET_PANADAPTER_SMOOTHING = 0xDA;
    public const byte CMD_GET_SET_PANADAPTER_STATUS = 0x83;
    public const byte CMD_GET_SET_PANADAPTER_FILL = 0x59;
    public const byte CMD_GET_SET_PANADAPTER_LINE = 0x5A;
    public const byte CMD_GET_SET_PANADAPTER_MARKER = 0x5B;
    public const byte CMD_GET_SET_PANADAPTER_BACKGROUND = 0x5D;
    public const byte CMD_GET_SET_PANADAPTER_CURSOR = 0x5E;
    public const byte CMD_GET_SET_PANADAPTER_REFRESH = 0x5F;
    public const byte CMD_GET_SET_PANADAPTER_GAIN = 0x85;
    public const byte CMD_GET_SET_PANADAPTER_BASE = 0x86;
    public const byte CMD_SET_SPECTRUM_VIEW_GRID = 0x21;
    public const byte CMD_SET_SPECTRUM_SHARP = 0x22;
    public const byte CMD_CW_SNAP_START = 0x6C;
    public const byte CMD_CW_SNAP_FINISHED = 0x6D;
    public const byte CMD_SET_CW_SNAP_FREQ = 0x67;
    public const byte CMD_SET_AUTO_SNAP_STATUS = 0xC9;
    public const byte CMD_SET_AUTO_SNAP_INDEX = 0xCA;
    public const byte CMD_SET_DRIFT = 0x35;

    public static byte Smoothing_Index = 0;
    public static byte Refresh_Index = 0;
    public static byte Refresh_Value = 1;
    public static string Filter_Size_Name;
    public static string CW_Filter_Size_Name;
    public static int Filter_Index = 0;
    public static int Previous_Filter_Index = 0;
    public static double X_Position = 0;
    public static double Graph_Freq = 0;
    public static int Fine_Tune_Delta = 0;
    public static bool Fine_Tuning = false;
    public static bool view_grid = false;
    public static bool Reset_Freq = false;
    public static bool Anti_Alias = false;
    public static bool Previous_Anti_Alias = true;
    public static long Data_average = 0;
    public const int Data_recieve_limit = 50;
    public static bool Freq_zoom = false;
    public static bool Previous_Freq_zoom = false;

    public struct CW_Snap
    {
        public static bool CW_button = false;
        public static bool CW_check_box = false;
        public static bool CW_snap_status = false;
        public static System.Drawing.Color Button_Color = System.Drawing.Color.Black;
    }
    public struct Mouse_event
    {
        public static double x = 0;
        public static double y = 0;
        public static String Display_Freq;
        public static double User_Cursor_x = 0;
        public static double User_Cursor_y = 0;
        public static bool Mouse_Event = false;
    }
    public struct Freq_Bounds
    {
        public static int Low_Freq;
        public static int High_Freq;
        public static int Current_X_Min = 0;
        public static int Current_X_Max = 0;
    }
    public struct Auto_Snap
    {
        public static int Snap_Value = 0;
        public static bool Auto_Snap_Checkbox = false;
    }
}
#endregion Panadapter_Controls

#region Power_Calibration_Controls
public static class Power_Calibration_Controls
{
    public struct Calibrated_Bands
    {
        public static byte B_160 = 0;
        public static byte B_80 = 0;
        public static byte B_60 = 0;
        public static byte B_40 = 0;
        public static byte B_30 = 0;
        public static byte B_20 = 0;
        public static byte B_17 = 0;
        public static byte B_15 = 0;
        public static byte B_12 = 0;
        public static byte B_10 = 0;
        public static byte B_2200 = 0;
        public static byte B_630 = 0;
    }
    public static int New_Power_Value = 0;
    public static bool TX_button = false;
    public static int High_Power = 0;
    public static int Previous_High_Power = 0;
    public static int Low_Power_Threshold = 0;
    public const int LOW_POWER_THRESHOLD_LIMIT = 3;
    public static int Old_Power_Value = 0;
    public static int Received_Power_Value = 0;
    public static int Calibration_Power_Watts = 0;
    public static int Calibration_Power_Watts_Decimal = 0;
    public static int Previous_Received_Power_Value = 0;
    public const int CALIBRATION_MAX_POWER = 5;
    public const int CALIBRATION_MAX_POWER_DECIMAL = 10;
    public static int Band = 0;
    public static int Previous_Band = 0;
    public static bool Band_Is_Selected = false;
    public static bool Tuning_Mode = false;
    public static bool Tune_Toggle = false;
    public static bool Warning_Accepted = false;
    public static bool Applied_Button_Active = false;
    public static bool Power_Tab_Active = false;
    public const byte CMD_CALIBRATION_MASTER_RESET = 0xAB;
    public const byte CMD_CALIBRATION_TUNE = 0xAC;
    public const byte CMD_SET_COMMIT_POWER_VALUES = 0xAD;
    public static bool Update_Pending = false;
    public static bool Committing = false;
    public static bool Factory_Defaults = false;
    public static bool QRP_Mode = false;
    public static bool Transceiver_mode = false;
    public static int Step = 0;
    public const int STEP_START = 15;
    public const int STEP_MAX = 45;
    public static bool First_Pass = true;
    public static bool Calibrating = false;
    public static bool Manual_Calibrate = false;
    public static int Tune_Power = 0;
}
#endregion

#region Amplifier_Power_Controls
public static class Amplifier_Power_Controls
{
    public static int Master_Power_Value = 0;
    public static int Band = 0;
    public static bool Band_Is_Selected = false;
    public static bool Tuning_Mode = false;
    public static bool Applied_Button_Active = false;
    public static bool Tab_Active = false;
    public static bool PA_Band_Selected = false;
    public static bool Solidus_IQ_Band_Selected = false;
    public static int PA_Power = 0;
    public static int PA_Calibration_Increment = -99;
    public static int Step_Display = 0;
    //public const int PA_CALIBRATION_POWER_LIMIT = 105;
    public static int PA_Calibration_Power_Limit = 50;
    public const int PA_MAX_CALIBRATION_COUNT = -1;
    public static int PA_Calibrated_Value = 0;
    public static bool PA_Calibrated = false;
    public static int PA_Not_Calibrated_Count = 0;
    public static bool PA_Calibrating = false;
    public const byte CMD_SET_BIAS = 0x35;
    public const byte CMD_GET_AMP_POWER = 0x05;
    public const byte CMD_GET_POTENTIA_TEMPERATURE = 0x06;
    public const byte CMD_GET_POTENTIA_BIAS = 0x07;
    public const byte CMD_SET_POTENTIA_CALIBRATION = 0x08;
    public const byte CMD_SET_AMPLIFIER_INITIALIZE = 0xF9;
    public const byte CMD_SET_AMPLIFIER_POWER = 0xFA;
    public const byte CMD_GET_AMPLIFIER_POWER = 0xFB;
    public const byte CMD_SET_AMPLIFIER_CALIBRATION_RESET = 0x10;
    public static bool Factory_Defaults = false;
    public static int Previous_Tune_power = 0;
    public static bool Display_Wait = false;
    public static short Display_Wait_count = 0;
    public static short Display_Wait_count_limit = 5;
    public static bool Tune_Inhibit = false;
    public static bool Bias_On = false;
    //public static int Calibration_Value = 0;
    public static int Current_Calibration_Value = 0;
    public static bool Overtemp_Flag = false;
    public static bool Bias_ON_OFF = false;
    public static bool Manual_Calibrate = true;
    public static bool Calibration_Type_Toggle = true;
    public const byte BIAS_OPERATION_FAILED = 0;
    public const byte BIAS_OPERATION_SUCCESS = 1;
    public const byte BIAS_OPERATION_UNCALIBRATED = 2;
    public const byte BIAS_OPERATION_CALIBRATED = 3;
    public const byte BIAS_OPERATION_WARMING = 4;
    public const byte BIAS_OPERATION_COOLING = 5;
    public const byte BIAS_OPERATION_CALIBRATING = 6;
    //public const byte WIPER_0 = 0x00;
    //public const byte WIPER_1 = 0x01;
}
#endregion

#region Frequency_Calibration_controls
public struct Signal_Average_data
{
    public const int AVERAGE_LIMIT = 100;
    public static int[] S_Value_Array = new int[AVERAGE_LIMIT];
    public static int Average_Count = 0;
    public static int Average = 0;
    public static int Smeter_Average = 0;
    public static int i = 0;
}
public static class Frequency_Calibration_controls
{
    //public const byte CMD_SET_CALIBRATION_START = 0x60;
    //public const byte CMD_SET_CALIBRATION_DATA = 0x61;
    public const byte CMD_SET_CALIBRATION_FINISHED = 0x62;
    public const byte CMD_SET_CAL_LOOSE = 0x63;
    public const byte CMD_SET_CAL_SET_COARSE = 0xC3;
    public const byte CMD_SET_CAL_SET_FINE = 0xAE;
    public const byte CMD_SET_CAL_DATA_PROCESSED = 0x66;
    public const byte CMD_SET_CAL_RESET = 0x68;
    public const byte CMD_SET_CAL_MODE = 0x69;
    public const byte CMD_SET_CALIBRATIION_PROGRESS = 0x6A;
    public const byte CMD_GET_SET_CAL_FREQ_DELTA = 0x6B;
    public const byte CMD_SET_FREQ_CAL_CHECK = 0x8C;
    public const byte CMD_START_CALIBRATE = 0xA7;
    public const byte CMD_SET_STANDARD_CARRIER = 0xAF;
    public const byte CMD_SET_FORCE_CALIBRATION = 0xC5;
    public const int CALIBRATION_OFFSET_POSITIVE = 1000;
    public const int CALIBRATION_OFFSET_NEGATIVE = 2000;
    public static bool Manual_Calibration_Button_Toggle = false;
    public static bool Manual_Calibration = false;
    public static bool Calibration_Offset_Positive = false;
    public static int Calibration_Delta_Value = 0;
    public static bool freq_text_box_cleared = false;
    public static bool Fine_Calibration = false;
    public static bool Coarse_Calibration = false;
    public static bool Calibration_In_Progress = false;
    public static Int32 Dial_frequency = 0;
    public static Int32 Target_Calibration_Frequency = 0;
    public static bool Check_only = false;
    public static bool Calibration_Checked = true;
    public static bool Freq_Cal_Loose = true;
    public static bool Reset = false;
    public static int Frequency_Calibrated = 0;
    public static bool Freq_Calibration_reported = false;
    public static int Gem_Frequency_Calibrated = 0;
    public static bool Reset_pressed = false;
    public static bool Keyboard_Displayed = false;
    public static bool Dial_Selected = false;
    public static bool Target_Selected = false;
    public static bool Frequency_Target_Selected = false;
    public static bool Progress_Toggle = false;
    public static int Progress_Value = 0;
    public static int Calibration_Status = 0;
    public static bool Calibration_Status_toggle = false;
    public static bool Freq_reported = false;
    public static Int32 Delta = 0;
    public static bool Message_Displayed = false;
}
#endregion

#region Comm_Port_Controls
public static class Comm_Port_Controls
{
    public const int Value_Not_Set = 200;
    public struct Box_indexes
    {
        public static int Baud_Rate = Value_Not_Set;
        public static int Parity = Value_Not_Set;
        public static int Stop_Bits = Value_Not_Set;
        public static int Data_Bits = Value_Not_Set;
        public static int Comm_Name_Index = Value_Not_Set;
        public static int Previous_Index = 0;
        public static int Comm_Port_Pins = Value_Not_Set;
        public static bool Set_By_Server = false;
    }
    public static bool Comm_Port_Open = false;
    public static bool Button_Toggle = false;
    public static byte DCD_Selected = 0;
    public static byte CTS_Selected = 0;

    public struct HR50_Controls
    {
        public static bool Comm_Port_Open = false;
        public static int Comm_Name_Index = 200;
        public static bool Button_Toggle = false;
        public static bool Set_By_Server = false;
        public static bool Pass_Thru = false;
        public static short PTT_Mode = 1;
        public static bool Comm_Port_Selected = false;
        public static bool Comm_Port_Open_by_server = false;
    }

    public const byte CMD_GET_SET_COMM_PORT = 0x40;
    public const byte CMD_GET_SET_COMM_BAUD_RATE = 0x41;
    public const byte CMD_GET_SET_COMM_PARITY = 0x42;
    public const byte CMD_GET_SET_COMM_DATA_BITS = 0x43;
    public const byte CMD_GET_SET_COMM_STOP_BITS = 0x44;
    public const byte CMD_GET_SET_COMM_START = 0x45;
    public const byte CMD_GET_SET_COMM_NAME_INDEX = 0x46;
    public const byte CMD_DELETE_COMM_PORT_INIT = 0x47;
    public const byte CMD_GET_SET_COMM_PORT_PINS = 0x48;
    public const byte CMD_GET_SET_HR50_COMM_NAME_INDEX = 0x49;
    public const byte CMD_GET_SET_HR50_COMM_PORT = 0x4A;
    public const byte CMD_GET_SET_HR50_COMM_SEND_BAND_INFO = 0x4B;
    public const byte CMD_GET_SET_HR50_COMM_START = 0x4C;
    public const byte CMD_GET_SET_HR50_COMM_SEND_FREQ_INFO = 0x4D;
    public const byte CMD_GET_SET_HR50_COMM_PASS_THRU = 0x4E;
}
#endregion

#region AGC_ALC_Notch_Controls
public static class AGC_ALC_Notch_Controls
{
    public static bool Notch_Button_On = false;
    public static int AGC_Level = 0;
    public static int AGC_SLOW = 0;
    public static int AGC_MED = 1;
    public static int AGC_FAST = 2;
    public static int AGC_Release = 1;
    public const byte CMD_GET_SET_AGC = 0x87;
    public const byte CMD_GET_SET_AUTO_NOTCH = 0x8E;
    public const byte CMD_SET_AGC_FAST_LEVEL = 0xCB;
    public const byte CMD_SET_ALC = 0x4F;
    public const byte CMD_SET_ALC_MULTIPLIER = 0x23;
    public static int ALC_Value = 11;
    public static bool ALC_STATE = false;
}
#endregion

#region IQ_Controls
public static class IQ_Controls
{
    public const byte CMD_SET_IQ_OFFSET = 0x52;
    public const byte IQ_CALIBRATION_TUNE = 0x54;
    public const byte IQ_CALIBRATION_RX_TX = 0x55;
    public const byte IQ_OPERATION_COMPLETE = 0x56;
    public const byte CMD_GET_IQ_VALUE = 0x8B;
    public const byte CMD_SET_COMMIT_IQ = 0x57;
    public const byte CMD_SET_IQ_BAND = 0x58;
    public const byte CMD_SET_IQ_DEFAULTS = 0x8D;
    public const byte CMD_REPORT_IMAGE_VALUE = 0xC6;
    public const byte CMD_START_STOP_IMAGE_VALUE = 0xC7;
    public const short IQ_INVALID_BAND = 150;
    public static bool IQBD_MONITOR = false;
    public const byte RX_IQBD = 0;
    public const byte TX_IQBD = 1;

    public static Point IQ_Active_Location = new Point(5, 15);
    public static Point IQ_Default_Location = new Point(0, 0);
    public static int IQ_Offset = 0;
    public static int IQ_Offset_Total = 0;
    public static int Previous_IQ_Offset = 0;
    public static byte IQBD_Calibrated = 0;
    public static bool IQBD_Committed = false;
    public static bool Calibrating = false;
    public static bool All_Bands_Calibrated = false;
    public static short Calibration_Band_Count = 0;
    public static int Selected_Band = 0;
    public static short Band_Selection_Index = 0;
    public static bool IQ_Band_Selected = false;
    public static int IQBD_Value = 0;
    public static int Previous_IQBD_Value = 0;
    public static byte Cool_Down = 0;
    public static bool Geminus_band_toggle = true;
    public const byte B2200 = 11;
    public const byte B630 = 10;
    public const short B160 = 9;
    public const short B80 = 8;
    public const short B60 = 7;
    public const short B40 = 6;
    public const short B30 = 5;
    public const short B20 = 4;
    public const short B17 = 3;
    public const short B15 = 2;
    public const short B12 = 1;
    public const short B10 = 0;
    public static bool band_selected = false;
    public static bool Tuning_Mode = false;
    public static short Previous_band = 200;
    public static bool IQ_TX_ON = false;
    public static bool IQ_tx_mode_active = false;
    public static bool IQ_RX_MODE_ACTIVE = false;
    public static bool IQ_Server_Calibrating = false;
    public static byte Multiplier = 0;
    public static bool RX_toggle = false;
    public static bool TX_toggle = false;
    public static bool Called_From_RX_Button = false;
    public static short Current_TX_Band = 150;
    public static short Current_RX_Band = 150;
    public static short Previous_RX_Band = 150;
    public static short Tune_power = 50;
    public static short Previous_Tune_power = 0;
    public static bool Up_24KHz = false;
    public static int IQ_RX_Freq = 0;
    public const int IQ_RX_Up_24K_freq = 24000;
    public static int IQ_RX_Offset = 0;
    public static int[] iq_calibration_freqs = { 28010000, 24900000, 21200000, 18110000,
        14150000, 10110000, 7010000, 5330500, 3510000, 1810000, 475000,135750 };
    public static bool Previous_QRP_Mode = false;
    public static Int32 Image_Value = 0;
    public static Int32 Previous_Image_Value = 0;
    public static int Graph_Display_Value = 0;
    public static class RPi
    {
        public static int Calibration_Slider_Value = 0;
        public static int Previous_Calibration_Slider_Value = 0;
    }
}
#endregion IQ_Controls

#region Band_Stack_Controls
public static class Band_Stack_Controls
{
    public static int Frequency = 0;
    public static short Band = 0;
    public static char Mode = 'N';
    public static short Band_Stack_Complete = 0;
    public struct band_stack
    {
        public static int freq;
        public static char mode;
        public static short band;
    }
}
#endregion

#region SDRprocesses
public static class SDRprocesses
{
    public static Process sdrcore_recv;
    public static Process sdrcore_trans;
    public static Process ms_sdr;
    public static Process initializer;
    public static Process waterfall;
    public static Process spectrum;
    public static Process init_files_process;
    public static Process sound_init_process;
    public static bool ms_sdr_running = true;
    public static bool sdrcore_recv_running = true;
    public static bool sdrcore_trans_running = true;
}
#endregion

#region Audio_Device_Controls
public static class Audio_Device_Controls
{
    public static short Selected_Speaker = 0;
    public static short Default_Speaker = 0;
    public static short Selected_Mic = 0;
    public static short Default_Mic = 0;
    public const byte CMD_DELETE_SDRCORE_INIT = 0xEC;
    public const byte CMD_SET_MICROPHONE_STATUS = 0x8F;
    public static bool Device_Reset_Button_Active = false;
    public static bool Update_Microphone_Status = false;
    public static bool Update_Speaker_Status = false;
    public static bool Overdriven_Alert = false;
    public static bool Microphone_Status = false;
}
#endregion

#region Volume_Controls
public static class Volume_Controls
{
    //public static short Speaker_Volume = 50;
    public static short Speaker_SSB_Value = 0;
    public static short Speaker_CW_Value = 0;
    //public static short Speaker_TUNE_Value = 0;
    public static short Speaker_AM_Value = 0;
    //public static bool Speaker_MutED = false;
    public static short Mic_Volume = 50;
    public static bool Mic_MutED = false;
    public static bool Monitor_Status = false;
    public const byte CMD_SET_MIC_GAIN = 0xE0;
    public const byte CMD_SET_DIGITAL_MIC_GAIN = 0x93;
    public const byte CMD_SET_VOLUME_ATTN = 0xE1;
    public const byte CMD_SET_MIC_VOLUME = 0xE6;
    public const byte CMD_SET_SPEAKER_MUTE = 0xE7;
    public const byte CMD_SET_SPEAKER_VOLUME = 0xE5;
    public const byte CMD_SET_MIC_MUTE = 0xE8;
    public const byte CMD_SET_OVERDRIVEN = 0xED;
    public const byte CMD_SET_COMPRESSION_STATE = 0xEE;
    public const byte CMD_SET_COMPRESSION_LEVEL = 0xEF;
    public const byte CMD_SET_MONITOR = 0x0D;
    public const byte CMD_SET_VOLUME_BY_SERVER = 0x0E;
    public static bool Overdriven_Warning = false;
    public static bool Overdriven_Warning_Toggle = true;
    public static short Compression_State = 0;
    public static short Compresson_Value = 0;
    public static short Previous_Compression_Value = 0;
    public static bool Label_Normal = true;
    public static bool Voice_Digital_Toggle = false;
    //public static byte Volume_Slider_Mode = 0;
    //public static byte Previous_Slider_Mode = 0;
    public const byte SLIDER_AM_MODE = 0;
    public const byte SLIDER_SSB_MODE = 1;
    public const byte SLIDER_CW_MODE = 2;
    public const byte SLIDER_TUNE_MODE = 3;
}
#endregion

#region Power_Controls
public static class Power_Controls
{
    public static short Main_Power = 0;
    public static short modeswitch = 0;
    public static short CW_Power = 0;
    public static short AM_Power = 0;
    public static short TUNE_Power = 50;
    public static short Main_Tab_Power = 100;
    public static bool Tx_BW_Warning = false;
    public static bool Full_power = false;
    public const byte CMD_SET_MAIN_POWER = 0xE2;
    public const byte CMD_SET_AM_POWER = 0xE3;
    public const byte CMD_SET_TUNE_POWER = 0xE9;
    public const byte CMD_SET_CW_POWER = 0xE4;
    public static int Previous_Tune_power = 0;
    public static class Mode
    {
        public const short AM_mode = 0;
        public const short LSB_mode = 1;
        public const short USB_mode = 2;
        public const short CW_mode = 3;
        public const short TUNE_mode = 4;
    }
}
#endregion

#region Smeter_controls
public static class Smeter_controls
{
    
    public const byte ALC_MODE = 0;
    public const byte SWR_MODE = 1;
    public const byte POWER_MODE = 2;
    public const byte I_MODE = 3;
    public const byte TEMPERATURE_MODE = 4;
    public const byte S_METER_MODE = 10;
    public const byte CMD_GET_SET_SMETER = 0xD4;
    public const byte CMD_SET_SMETER_AVERAGE = 0x37;
    public const byte CMD_SET_METER_HILO = 0x0A;
    public const byte CMD_MENSURO_CALIBRATE = 0x3b;
    public static class meter_colors
    {
        public static Color led1_off;
        public static Color led1_on;
        public static Color led2_off;
        public static Color led2_on;
        public static Color led3_off;
        public static Color led3_on;
    }
    public static class Smeter
    {
        public static String[] smeter_dial = new String[9];
        public static String[] alc_dial = new string[10];
        public static String[] swr_dial = new string[8];
        public static String[] power_dial_QRP = new string[7];
        public static String[] power_dial_QRO = new string[7];
        public static String[] I_dial = new string[8];
        public static String[] temperature_dial = new string[7];
    }
    public static bool Meter_Peak_Needle = false;
    public static byte Meter_Peak_Hold = 0;
    public static byte Meter_Peak_Needle_Color = 0;
    public static byte Meter_Peak_Needle_Color_Index = 0;
    public static int Peak_Needle_Delay_Index = 0;
    //public static int Peak_Needle_Color_Index = 0;
    public static int Peak_Needle = 0;
    public static int Meter_Hold = 0;
    public static int Meter_Background_Color = 0;
    public static int Meter_Mode = 0;
    public static int Power_Meter_Max_Level = 110;
    public static int Preferred_Temperature_Mode = 0;
    public const int PREFERRED_TEMPERATURE_AMPLIFIER = 0;
    public const int PREFERRED_TEMPERATURE_PROFICIO = 1;
    public static int Preferred_Mode = 0;
    public static int Previous_Mode = 0;
    public static int Previous_Meter_Configuration = 0;
    public static bool ALC_Blink_Toggle = false;
    public static bool ALC_Blink_Display = false;
    public static byte selected_mode = 0;
    public static byte SWR_Meter_Hold = 0;
    public static int smeter_hold_time = 30;
    public static int smeter_hold = 0;
    public static int smeter_hold_time_index = 2;
    public static int smeter_value = 250;
    public static bool Smeter_Hold_On = true;
    public static int Previous_Low = 0;
    public static int Previous_High = 0;
    public static int Smeter_decrement = 1;
    public static int Display_Mode = 20;
    public static int smeter_display_value = 0;
    public static int Power_Value = 0;
    public static bool Display_Power_Value = false;
    public static bool Display_Smeter_Value = false;
    public static bool Display_Smeter_Toggle = false;
    
    //public const byte SMETER_VALUE_DISPLAY_MODE = 5;
    //public static float Smeter_scaling = 1.0f;
    //public static float Smeter_base = 2.6f;
   
    //public static bool Smeter_convert = false;
    public static float SWR_Value = 0;
    public static double SWR_Fraction = 0;
    public static int SWR_Fraction_Part = 0;
    public static byte Smeter_Average = 0;
    public static int Meter_I_Value = 0;
    public static bool Text_Display_Dbm_mode = false;
    public static int Proficio_temperature;
    public static int Meter_Background_Color_Index = 0;
    public static byte Mensuro_Hi_Lo = 0;
    public static byte Previous_Mensuro_Hi_Lo = 100;
    public static bool Mensuro_Attached = false;
    public static bool Use_Mensuro = false;
    public static bool Mensuro_Calibrated = false;
    public static bool Mensure_Calibration_Message = false;
    public static bool Mensure_Message_Reported = false;
    public struct VU
    {
        public static int Previous_Low = 0;
        public static int VU_Value = 0;
        public static int Blink = 1;
        public static int Ignore_Count = 0;
        public const int IGNORE_LIMIT = 2;
        public static bool New_Session = false;
    }
}
#endregion Smeter_controls

#region Main_Smeter_controls
public static class Main_Smeter_controls
{
    public static int SMeter_value = 0;
    public static int VU_Meter_value = 0;
}
#endregion

#region Udp_data
public static class Udp_data
{
    public static UdpClient rxsocket;
    public static IPEndPoint rxtarget;
}
#endregion

#region Filter_control
public static class Filter_control
{
    public static short Filter_High_Index = 1;
    public static short Previous_Filter_High_Index = 0;
    public static short Filter_Low_Index = 4;
    public static short Previous_Filter_Low_Index = 0;
    public static short Filter_TX_High_Index = 0;
    public static short Default_Filter_High_Index = 1;
    public static short Default_Filter_Low_Index = 4;
    public static short Default_Filter_CW_Index = 2;
    public static short Previous_TX_Bandwidth = 1;
    public static short TX_Bandwidth = 1;
    public static bool Band_Stack_Updating = false;
    public const byte CMD_SET_BW_LOCUT = 0xD0;
    public const byte CMD_SET_BW_HICUT = 0xD1;
    public const byte CMD_SET_CW_PITCH = 0xD2;
    public const byte CMD_SET_TX_HICUT = 0xD3;
    public const byte CMD_SET_CW_BW = 0xDB;
    public const byte CMD_SET_BW_LOCUT_DEFAULT = 0xDC;
    public const byte CMD_SET_BW_HICUT_DEFAULT = 0xDD;
    public const byte CMD_SET_CW_BW_DEFAULT = 0xDE;
    public static short CW_Filter_Index = 0;
    public static short Previous_CW_Filter_Index = 0;
    public static int CW_Bw = 0;
    public static int CW_Pitch = 0;
    public static int CW_Pitch_Index = 0;
  
    public const byte CW_PITCH_400_INDEX = 0;
    public const byte CW_PITCH_600_INDEX = 1;
    public const byte CW_PITCH_800_INDEX = 2;
    public const byte CW_PITCH_1000_INDEX = 3;
    public const byte CW_FILTER_1800_INDEX = 0;
    public const byte CW_FILTER_400_INDEX = 1;
    public const byte CW_FILTER_200_INDEX = 2;
    public struct Defaults
    {
        public static int Lo_Cut_Default;
        public static int Hi_Cut_Default;
        public static int CW_Default;
    }
}
#endregion Filter_controls

#region CW_Parameters
public static class CW_Parameters
{
    public const byte SET_CW_MODE = 0x70;
    public const byte SET_KEYER_MODE = 0x71;
    public const byte SET_LAG = 0x72;
    public const byte SET_CW_PADDLE = 0x73;
    public const byte SET_IAMBIC_TYPE = 0x74;
    public const byte SET_SPACING = 0x75;
    public const byte SET_MEMORY_TYPE = 0x76;
    public const byte SET_WEIGHT = 0x77;
    public const byte SET_TX_HOLD = 0x7A;
    public const byte SET_WPM = 0x7B;
    public const byte SET_SEMI_BREAKIN = 0x78;
    public const byte SET_SIDE_TONE_VOLUME = 0x7F;
    public const byte SET_QSK = 0x72;
    public const byte CMD_CW_DISPLAY_CAL = 0x3E; //For testing

    public static short CW_Firmware_Option;
    public static short Keyer_Installed = 0;
    public static short Keyer_Mode = 0;
    public static short Restore_Defaults;
    public static short _Iambic_Mode_On_Off;
    //public static short CW_Iambic_Type;
    public static short Iambic_Calibrate;
    public static short Memory;
    public static short Spacing;
    public static short Paddle;
    public static short Weight;
    public static short Tx_Hold;
    public static short Speed;
    public static short QSK = 0;
    public static short Lag = 0; //Was CW_Semi_Control
    public static short Side_Tone_Volume;
    public static short Phones = 0;
}
#endregion

#region oCode
public static class oCode
{  
    public const byte CMD_SET_RELOAD_FILE = 0xA5;
    public const byte CMD_SET_RIG_TUNE = 0xA6;
    public const byte CMD_SET_TRANSVERTER = 0xA9;
    public const byte CMD_SET_BAND_POWER_BAND = 0xA1;
    public const byte CMD_SET_BAND_POWER_POWER = 0xA2;
    public const byte CMD_SET_BAND_POWER_DEFAULTS = 0xAA;
    public const byte CMD_GET_BAND_POWER = 0xB4;

    public const byte CMD_GET_SET_LAST_USED_FREQ = 0xD7;
    public const byte CMD_GET_SET_LAST_USED_MODE = 0xD8;
    public const byte CMD_GET_SET_LAST_USED_BAND = 0xD9;

    //Audio Device Control
    public const byte CMD_GET_SET_SPEAKER_DEVICE = 0xEA;
    public const byte CMD_GET_SET_MIC_DEVICE = 0xEB;

    public const byte CMD_GET_FREQ_INIT = 0xB0;
    public const byte CMD_SET_MAIN_FREQ = 0xB6;
    public const byte CMD_SET_MAIN_MODE = 0xB7;
    public const byte CMD_GET_MODE_INIT = 0xB8;
    public const byte CMD_GET_BAND_INIT = 0xB9;
    public const byte CMD_SET_TX_ON = 0xBA;

    public const byte CMD_SET_HDSDR_STATUS = 0xF0;
    public const byte CMD_GET_HDSDR_STATUS = 0xF1;
    public const byte CMD_SET_POWER_MODE_STATE = 0xF2;
    public const byte CMD_SET_KEEP_ALIVE = 0xF4;
    public const byte CMD_GET_SET_MSSDR_STATUS = 0xF5;
    public const byte CMD_GET_SET_STARTUP_BAND = 0xF6;
    public const byte CMD_GUI_RUNNING = 0xFE;
    public const byte CMD_SET_STOP = 0xFF;

    public struct iniStates
    {
        /*public static short CW_Firmware_Option;
        public static short CW_Restore_Defaults;
        public static short CW_Iambic_Mode_On_Off;
        public static short CW_Iambic_Type;
        public static short CW_Iambic_Calibrate;
        public static short CW_Memory;
        public static short CW_Spacing;
        public static short CW_Paddle;
        public static short CW_Weight;
        public static short CW_Tx_Hold;
        public static short CW_Speed;
        public static short CW_Semi_Break_In;
        public static short CW_Semi_Control;
        public static short CW_Side_Tone_Volume;
        */
        public static int DLL_PORT;
        public static int GUI_PORT;
        public static string DLL_IP;
        public static string GUI_IP;
    }
    public static void guiCode_Write_Debug_Message(String Message)
    {
        var thisForm2 = Application.OpenForms.OfType<Main_form>().Single();
        thisForm2.Write_Message(Message);
    }
    public static void SendCommand(Socket s, IPEndPoint target, Byte opcode, short data)
    {
        Byte[] msg = new Byte[3];
        Byte[] sbytes = new Byte[2];
        String Message;
        //int send_retry = 0;
        //bool message_sent = false;

        Message = " Send Command called -> opcode: " + String.Format("#{0:X}", opcode);
        //guiCode_Write_Debug_Message(Message);
        if (Master_Controls.Initialize_network_status)
        {
            msg[0] = opcode;
            sbytes = BitConverter.GetBytes(data);
            msg[1] = sbytes[0];
            msg[2] = sbytes[1];

            try
            {
                s.SendTo(msg, target);
                //s.BeginSendTo(msg, 0, 3, SocketFlags.None, target, null, null);
            }
            catch (SocketException e)
            {
                if (!Master_Controls.Socket_Error)
                {
                    Master_Controls.Socket_Error = true;
                    MessageBox.Show("Network Error: " + e.ToString() + " MSCC will stop", "MSCC",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
        msg = null;
        sbytes = null;
    }
    public static void SendCommand32(Socket s, IPEndPoint target, Byte opcode, int data)
    {
        Byte[] msg = new Byte[5];
        Byte[] sbytes = new Byte[4];

        msg[0] = opcode;
        sbytes = BitConverter.GetBytes(data);
        msg[1] = sbytes[0];
        msg[2] = sbytes[1];
        msg[3] = sbytes[2];
        msg[4] = sbytes[3];

        s.SendTo(msg, target);

        msg = null;
        sbytes = null;
    }
    public static void SendCommand_String(Socket s, IPEndPoint target, Byte opcode, String name_data, int length)
    {
        int i = 0;
        Byte[] msg = new Byte[length + 1];

        byte[] msg_data = Encoding.ASCII.GetBytes(name_data);
        msg[0] = opcode;
        for (i = 1; i <= length; i++)
        {
            msg[i] = msg_data[(i - 1)];
        }

        s.SendTo(msg, target);
        msg = null;
    }
    public static void SendCommand_MultiByte(Socket s, IPEndPoint target, Byte opcode, byte[] name_data, int length)
    {
        int i = 0;
        Byte[] msg = new Byte[length + 1];

        byte[] msg_data = name_data;
        msg[0] = opcode;
        for (i = 1; i <= length; i++)
        {
            msg[i] = msg_data[(i - 1)];
        }

        s.SendTo(msg, target);
        msg = null;
    }
    public static bool getIniStates()
    {
        String path, line;
        System.IO.StreamReader file;
        //int p;

        // get path to local Appdata folder
        path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        // add our folder and file name
#if RPI
        path += "/mscc-GEMINUS/mscc.ini";
#else
        path += "\\multus-sdr-client\\Multus_mscc.ini";
#endif
        guiCode_Write_Debug_Message(" getIiniStates -> ini file: " + path);

        // try to open the file
        try
        {
            //file = new System.IO.StreamReader(path);
            file = new System.IO.StreamReader(File.OpenRead(path));
        }

        // if the file open fails, whine prettily and return false
        catch (IOException e)
        {
            string er = e.Message;
            MessageBox.Show("IO Exception opening INI file." + er + " Have you run the INI creation utility?", "MSCC", MessageBoxButtons.OK,
                                                                                MessageBoxIcon.Exclamation);
            return false;
        }
        if (!System.IO.File.Exists(path))
        {
            MessageBox.Show("IO Exception opening INI file. \r\n Have you run the INI creation utility?", "MSCC", MessageBoxButtons.OK,
                                                                               MessageBoxIcon.Exclamation);
            return false;
        }


        iniStates.GUI_PORT = 0;
        iniStates.DLL_PORT = 0;
        // Parse the INI file. Doing it this way eliminates the requirement that the parameters be stored in any particular order.
        // The parms are stored in a public static struct, which can be reached by the form-level GUI code.
        while ((line = file.ReadLine()) != null)
        {
#if !RPI
            if (line.Contains("CW_Firmware_Option")) CW_Parameters.CW_Firmware_Option = getIntFromIniString(line);
            if (line.Contains("CW_Restore_Defaults")) CW_Parameters.CW_Restore_Defaults = getIntFromIniString(line);
            if (line.Contains("CW_Iambic_Mode_On_Off")) CW_Parameters.CW_Iambic_Mode_On_Off = getIntFromIniString(line);
            if (line.Contains("CW_Iambic_Type")) CW_Parameters.CW_Iambic_Type = getIntFromIniString(line);
            if (line.Contains("CW_Iambic_Calibrate")) CW_Parameters.CW_Iambic_Calibrate = getIntFromIniString(line);
            if (line.Contains("CW_Memory")) CW_Parameters.CW_Memory = getIntFromIniString(line);
            if (line.Contains("CW_Spacing")) CW_Parameters.CW_Spacing = getIntFromIniString(line);
            if (line.Contains("CW_Paddle")) CW_Parameters.CW_Paddle = getIntFromIniString(line);
            if (line.Contains("CW_Weight")) CW_Parameters.CW_Weight = getIntFromIniString(line);
            if (line.Contains("CW_Tx_Hold")) CW_Parameters.CW_Tx_Hold = getIntFromIniString(line);
            if (line.Contains("CW_Speed")) CW_Parameters.CW_Speed = getIntFromIniString(line);
            if (line.Contains("CW_Semi_Break_In")) CW_Parameters.CW_Semi_Break_In = getIntFromIniString(line);
            //if (line.Contains("CW_Semi_Control")) CW_Parameters.CW_Semi_Control = getIntFromIniString(line);
            if (line.Contains("CW_Side_Tone_Volume")) CW_Parameters.CW_Side_Tone_Volume = getIntFromIniString(line);
#endif
            if (line.Contains("MSCC_PORT")) iniStates.GUI_PORT = getIntFromIni32String(line);
            if (line.Contains("PROFICIO_DLL_PORT")) iniStates.DLL_PORT = getIntFromIni32String(line);
            if (line.Contains("MSCC_IP")) iniStates.GUI_IP = getStringFromIniString(line);
            if (line.Contains("PROFICIO_DLL_IP")) iniStates.DLL_IP = getStringFromIniString(line);
        }

        file.Close();
        return true;

    }
    public static bool Get_CW_Params()
    {
        String path, line;
        System.IO.StreamReader file;
        //int p;

        // get path to local Appdata folder
        path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        // add our folder and file name

        path += "/mscc-GEMINUS/cw.ini";
        guiCode_Write_Debug_Message(" Get_CW_Params -> ini file: " + path);

        // try to open the file
        try
        {
            //file = new System.IO.StreamReader(path);
            file = new System.IO.StreamReader(File.OpenRead(path));
        }

        // if the file open fails, whine prettily and return false
        catch (IOException e)
        {
            string er = e.Message;
            MessageBox.Show("IO Exception opening Multus_mscc.ini file." + er +
                " Have you run the INI creation utility?", "MSCC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        if (!System.IO.File.Exists(path))
        {
            MessageBox.Show("IO Exception opening Multus_mscc.ini file. \r\n Have you run the INI creation utility?",
                "MSCC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        // Parse the INI file. Doing it this way eliminates the requirement that the parameters be stored in any particular order.
        // The parms are stored in a public static struct, which can be reached by the form-level GUI code.
        while ((line = file.ReadLine()) != null)
        {
            //if (line.Contains("CW_Firmware_Option")) CW_Parameters.CW_Firmware_Option = getIntFromIniString(line);
            //if (line.Contains("CW_Restore_Defaults")) CW_Parameters.CW_Restore_Defaults = getIntFromIniString(line);
            //if (line.Contains("CW_Iambic_Mode_On_Off")) CW_Parameters.CW_Iambic_Mode_On_Off = getIntFromIniString(line);
            //if (line.Contains("CW_Iambic_Type")) CW_Parameters.CW_Iambic_Type = getIntFromIniString(line);
            //if (line.Contains("CW_Iambic_Calibrate")) CW_Parameters.CW_Iambic_Calibrate = getIntFromIniString(line);
            if (line.Contains("CW_Keyer_Installed")) CW_Parameters.Keyer_Installed = getIntFromIniString(line);
            if (line.Contains("CW_Keyer_Mode")) CW_Parameters.Keyer_Mode = getIntFromIniString(line);
            if (line.Contains("CW_Memory")) CW_Parameters.Memory = getIntFromIniString(line);
            if (line.Contains("CW_Spacing")) CW_Parameters.Spacing = getIntFromIniString(line);
            if (line.Contains("CW_Paddle")) CW_Parameters.Paddle = getIntFromIniString(line);
            if (line.Contains("CW_Weight")) CW_Parameters.Weight = getIntFromIniString(line);
            if (line.Contains("CW_Tx_Hold")) CW_Parameters.Tx_Hold = getIntFromIniString(line);
            if (line.Contains("CW_Speed")) CW_Parameters.Speed = getIntFromIniString(line);
            //if (line.Contains("CW_Semi_Break_In")) CW_Parameters.CW_QSK = getIntFromIniString(line);
            //if (line.Contains("CW_Semi_Control")) CW_Parameters.CW_Lag = getIntFromIniString(line);
            //if (line.Contains("CW_Side_Tone_Volume")) CW_Parameters.CW_Side_Tone_Volume = getIntFromIniString(line);
        }
        file.Close();
        return true;

    }
    public static string getStringFromIniString(string str)
    {
        int eqpos;
        string nstr;


        if (str.Contains("=") == false) return null;       // ain't no dang equals sign in the string
        eqpos = str.IndexOf("=");                       // get the position of the equals sign in the string
        nstr = str.Substring(eqpos + 1, str.Length - eqpos - 2);   // parse everything between the "=" and the ";" into another string
        return nstr;
    }
    public static short getIntFromIniString(string str)
    {
        int eqpos;
        short output;
        string nstr;


        if (str.Contains("=") == false) return 0;       // ain't no dang equals sign in the string
        eqpos = str.IndexOf("=");                       // get the position of the equals sign in the string
        nstr = str.Substring(eqpos + 1, str.Length - eqpos - 2);   // parse everything between the "=" and the ";" into another string
        Int16.TryParse(nstr, out output);               // a complicated, but best-practice way to extract a short from a string
        return output;
    }
    public static int getIntFromIni32String(string str)
    {
        int eqpos;
        int output;
        string nstr;
        string oput;

        if (str.Contains("=") == false) return 0;       // ain't no dang equals sign in the string
        eqpos = str.IndexOf("=");                       // get the position of the equals sign in the string
        nstr = str.Substring(eqpos + 1, str.Length - eqpos - 2);   // parse everything between the "=" and the ";" into another string
        int.TryParse(nstr, out output);               // a complicated, but best-practice way to extract a short from a string
        oput = Convert.ToString(output);
        return output;
    }
    public static bool Run_Initialization(int step)
    {
        bool status = true;
        String path;
        String bat_file_path;
        String init_file_path;

        path = AppDomain.CurrentDomain.BaseDirectory;
        bat_file_path = (path + "/initialize.bat");
        init_file_path = (path + "/mscc-init.exe");

        switch (step) {
            case 0:
                SDRprocesses.init_files_process = new Process();
            try
            {
                SDRprocesses.init_files_process.StartInfo.UseShellExecute = false;
                SDRprocesses.init_files_process.StartInfo.FileName = bat_file_path;
                SDRprocesses.init_files_process.StartInfo.CreateNoWindow = false;
                SDRprocesses.init_files_process.StartInfo.Arguments = "test";
                SDRprocesses.init_files_process.Start();
            }
            catch (Exception e)
            {
                DialogResult ret = MessageBox.Show("initialize.bat did not start. \r\n" + e.Message, "MSCC",
                                                                                          MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                status = false;
            }
                break;
            case 1:
                SDRprocesses.sound_init_process = new Process();
                try
                {
                    SDRprocesses.sound_init_process.StartInfo.UseShellExecute = false;
                    SDRprocesses.sound_init_process.StartInfo.FileName = bat_file_path;
                    SDRprocesses.sound_init_process.StartInfo.CreateNoWindow = false;
                    SDRprocesses.sound_init_process.StartInfo.Arguments = "test";
                    SDRprocesses.sound_init_process.Start();
                }
                catch (Exception e)
                {
                    DialogResult ret = MessageBox.Show("mscc-init.exe did not start. \r\n" + e.Message, "MSCC",
                                                                                              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    status = false;
                }
                break;
        }
        return status;
    }
    public static bool Start_subsystem(int start_stop)
    {
        String Ms_sdr_path;
        String path;
        String Sdr_core_recv_path;
        String SDR_core_trans_path;
        String Waterfall_path;
        String Spectrum_path;
        bool subsystem_started = true;

        if (start_stop == 1)
        {
            //oCode.Platform = (int)Environment.OSVersion.Platform;
            path = AppDomain.CurrentDomain.BaseDirectory;
            // A kludge to check for non Windows OS.  
            //These values may change in the future.

#if RPI
            Ms_sdr_path = (path + "/ms-sdr-geminus.exe");
            Sdr_core_recv_path = (path + "/mscc-recv.exe");
            SDR_core_trans_path = (path + "/mscc-trans.exe");
            Waterfall_path = (path + "/MSCC-Waterfall.exe");
            Spectrum_path = (path + "/MSCC-Spectrum.exe");
#endif
            SDRprocesses.sdrcore_trans = new Process();
            try
            {
                SDRprocesses.sdrcore_trans.StartInfo.UseShellExecute = false;
                SDRprocesses.sdrcore_trans.StartInfo.FileName = SDR_core_trans_path;
                SDRprocesses.sdrcore_trans.StartInfo.CreateNoWindow = true;
                SDRprocesses.sdrcore_trans.StartInfo.Arguments = "test";
                SDRprocesses.sdrcore_trans.Start();
            }
            catch (Exception e)
            {
                Master_Controls.MSSDR_running = false;
                SDRprocesses.sdrcore_trans_running = false;
                DialogResult ret = MessageBox.Show("SDRcore-trans did not start. \r\n" + e.Message, "MSCC",
                                                                                          MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                subsystem_started = false;
            }

            SDRprocesses.sdrcore_recv = new Process();
            try
            {
                SDRprocesses.sdrcore_recv.StartInfo.UseShellExecute = false;
                SDRprocesses.sdrcore_recv.StartInfo.FileName = Sdr_core_recv_path;
                SDRprocesses.sdrcore_recv.StartInfo.CreateNoWindow = true;
                SDRprocesses.sdrcore_recv.StartInfo.Arguments = "test";
                SDRprocesses.sdrcore_recv.Start();
            }
            catch (Exception e)
            {
                Master_Controls.MSSDR_running = false;
                SDRprocesses.sdrcore_recv_running = false;
                DialogResult ret = MessageBox.Show("SDRcore-recv did not start. \r\n" + e.Message, "MSCC",
                                                                                          MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                subsystem_started = false;
            }

            SDRprocesses.ms_sdr = new Process();
            try
            {
                SDRprocesses.ms_sdr.StartInfo.UseShellExecute = false;
                SDRprocesses.ms_sdr.StartInfo.FileName = Ms_sdr_path;
                SDRprocesses.ms_sdr.StartInfo.CreateNoWindow = true;
                SDRprocesses.ms_sdr.StartInfo.Arguments = "test";
                SDRprocesses.ms_sdr.Start();
            }
            catch (Exception e)
            {
                Master_Controls.MSSDR_running = false;
                SDRprocesses.ms_sdr_running = false;
                DialogResult ret = MessageBox.Show("MS-SDR did not start.\r\n" + e.Message + "\r\n" + path + "\r\n", "MSCC",
                                                                                          MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                subsystem_started = false;
            }

        }
        return subsystem_started;
    }
}
#endregion oCode



