using System;
using System.Threading;
using System.Windows.Forms;
using OmniaGUI.Properties;
using System.IO;
namespace OmniaGUI
{
    partial class Main_form
    {
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// Form stop = new shutdown();
        protected override void Dispose(bool disposing)
        {
            if (Monitor_window != null) Monitor_window.Close();

            if (Window_controls.Panadapter_Controls.Panadapter_Control_Window != null)
            {
                if (Window_controls.Panadapter_Controls.Panadapter_Control_Window.WindowState != FormWindowState.Minimized)
                {
                    Settings.Default.Panadapter_Control_Location =
                        Window_controls.Panadapter_Controls.Panadapter_Control_Window.Location;
                }
                Window_controls.Panadapter_Controls.Panadapter_Control_Window.Close();
            }        
            Settings.Default.Save();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.powertabControl1 = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.GEM_Group_Box = new System.Windows.Forms.GroupBox();
            this.GEM_BCN_Button = new System.Windows.Forms.RadioButton();
            this.GEM_GEN_Butt = new System.Windows.Forms.RadioButton();
            this.MF_Button = new System.Windows.Forms.RadioButton();
            this.LF_Button = new System.Windows.Forms.RadioButton();
            this.picWaterfall = new System.Windows.Forms.PictureBox();
            this.picSpectrum = new System.Windows.Forms.PictureBox();
            this.Freq_Add_Stack_Button = new System.Windows.Forms.Button();
            this.Freq_Stack_button = new System.Windows.Forms.Button();
            this.MIC_Gain_Down_button = new System.Windows.Forms.Button();
            this.MIC_Gain_UP_button = new System.Windows.Forms.Button();
            this.Volume_Down_button = new System.Windows.Forms.Button();
            this.Volume_UP_button = new System.Windows.Forms.Button();
            this.NR_button3 = new System.Windows.Forms.Button();
            this.RIT_groupBox4 = new System.Windows.Forms.GroupBox();
            this.StartUP_label44 = new System.Windows.Forms.Label();
            this.RIT_Up_button = new System.Windows.Forms.Button();
            this.RIT_Down_button = new System.Windows.Forms.Button();
            this.ritfreqtextBox1 = new System.Windows.Forms.TextBox();
            this.buttReset = new System.Windows.Forms.Button();
            this.ritbutton1 = new System.Windows.Forms.Button();
            this.ritScroll = new System.Windows.Forms.HScrollBar();
            this.Error_Message_label = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.GEN_button = new System.Windows.Forms.Button();
            this.Meter_Temperature_button8 = new System.Windows.Forms.Button();
            this.Meter_ALC_button8 = new System.Windows.Forms.Button();
            this.Meter_I_button8 = new System.Windows.Forms.Button();
            this.Meter_SWR_button8 = new System.Windows.Forms.Button();
            this.Meter_Power_button8 = new System.Windows.Forms.Button();
            this.Dbm_label9 = new System.Windows.Forms.Label();
            this.PA_button = new System.Windows.Forms.Button();
            this.Dbm_Value_label9 = new System.Windows.Forms.Label();
            this.Power_Value_label2 = new System.Windows.Forms.Label();
            this.CW_Filter_button8 = new System.Windows.Forms.Button();
            this.Low_Cut_Filter_button8 = new System.Windows.Forms.Button();
            this.High_Cut_button8 = new System.Windows.Forms.Button();
            this.Step_button8 = new System.Windows.Forms.Button();
            this.Microphone_textBox2 = new System.Windows.Forms.Label();
            this.Volume_textBox2 = new System.Windows.Forms.Label();
            this.UTC_Date_label46 = new System.Windows.Forms.Label();
            this.Time_display_UTC_label34 = new System.Windows.Forms.Label();
            this.Minimize_checkBox2 = new System.Windows.Forms.CheckBox();
            this.Audio_Digital_button3 = new System.Windows.Forms.Button();
            this.Split_Button = new System.Windows.Forms.Button();
            this.Spectrum_Controls_button3 = new System.Windows.Forms.Button();
            this.VFO_button = new System.Windows.Forms.Button();
            this.ACG_button = new System.Windows.Forms.Button();
            this.Compression_button4 = new System.Windows.Forms.Button();
            this.Auto_Zero_checkBox2 = new System.Windows.Forms.CheckBox();
            this.Local_Date_label46 = new System.Windows.Forms.Label();
            this.NB_button2 = new System.Windows.Forms.Button();
            this.Time_display_label33 = new System.Windows.Forms.Label();
            this.TX_Mute_button2 = new System.Windows.Forms.Button();
            this.Volume_Mute_button2 = new System.Windows.Forms.Button();
            this.MicVolume_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Volume_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Freqbutton3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainmodebutton2 = new System.Windows.Forms.Button();
            this.buttTune = new System.Windows.Forms.Button();
            this.Band_Change_Auto_Tune_checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Message_button = new System.Windows.Forms.Button();
            this.VFOB_Active_button = new System.Windows.Forms.Button();
            this.VFOB_TX_Indicator_button = new System.Windows.Forms.Button();
            this.Out_Of_Band_button = new System.Windows.Forms.Button();
            this.Main_Freq_KB_button = new System.Windows.Forms.Button();
            this.Freq_Up_button = new System.Windows.Forms.Button();
            this.Freq_Down_button = new System.Windows.Forms.Button();
            this.Freq_Pointer_7 = new System.Windows.Forms.Label();
            this.Freq_Pointer_6 = new System.Windows.Forms.Label();
            this.Freq_Pointer_5 = new System.Windows.Forms.Label();
            this.Freq_Pointer_4 = new System.Windows.Forms.Label();
            this.Freq_Pointer_3 = new System.Windows.Forms.Label();
            this.Freq_Pointer_2 = new System.Windows.Forms.Label();
            this.Freq_Pointer_1 = new System.Windows.Forms.Label();
            this.Freq_Pointer_0 = new System.Windows.Forms.Label();
            this.Tenmillions = new System.Windows.Forms.Label();
            this.Tenthousands = new System.Windows.Forms.Label();
            this.Decimal_label58 = new System.Windows.Forms.Label();
            this.Decimal_label59 = new System.Windows.Forms.Label();
            this.Hundredthousand = new System.Windows.Forms.Label();
            this.Millions = new System.Windows.Forms.Label();
            this.Hundreds = new System.Windows.Forms.Label();
            this.Thousands = new System.Windows.Forms.Label();
            this.Ones = new System.Windows.Forms.Label();
            this.Tens = new System.Windows.Forms.Label();
            this.Main_Power_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Monitor_button8 = new System.Windows.Forms.Button();
            this.Smeter_Display_Value_label = new System.Windows.Forms.Label();
            this.vuMeter1 = new VU_MeterLibrary.VuMeter();
            this.Band_Set_2 = new System.Windows.Forms.GroupBox();
            this.Russian_Radio_Button = new System.Windows.Forms.RadioButton();
            this.WWV1_Radio_Button = new System.Windows.Forms.RadioButton();
            this.WWV2_Radio_Button = new System.Windows.Forms.RadioButton();
            this.WWV3_Radio_Button = new System.Windows.Forms.RadioButton();
            this.WWV4_Radio_Button = new System.Windows.Forms.RadioButton();
            this.CHU2_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Spare_Radio_Button = new System.Windows.Forms.RadioButton();
            this.CHU1_Radio_Button = new System.Windows.Forms.RadioButton();
            this.TX = new System.Windows.Forms.TabPage();
            this.Auto_Tune_Time_button = new System.Windows.Forms.Button();
            this.Auto_Tune_button = new System.Windows.Forms.Button();
            this.TX_Tab_Band_label = new System.Windows.Forms.Label();
            this.ALC_ON_OFF_button5 = new System.Windows.Forms.Button();
            this.AGC_Value_label = new System.Windows.Forms.Label();
            this.NB_Threshold_label = new System.Windows.Forms.Label();
            this.NB_Pulse_lable = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Reverse_Power_label43 = new System.Windows.Forms.Label();
            this.Forward_Meter = new VU_MeterLibrary.VuMeter();
            this.SWR_label1 = new System.Windows.Forms.Label();
            this.Reverse_Meter = new VU_MeterLibrary.VuMeter();
            this.Power_Meter_Hold = new System.Windows.Forms.NumericUpDown();
            this.Meter_hold_label43 = new System.Windows.Forms.Label();
            this.Forward_Power_label43 = new System.Windows.Forms.Label();
            this.Forward_label43 = new System.Windows.Forms.Label();
            this.SWR_Value_label43 = new System.Windows.Forms.Label();
            this.Reverse_label58 = new System.Windows.Forms.Label();
            this.Full_Power_checkBox1 = new System.Windows.Forms.CheckBox();
            this.NR_label5 = new System.Windows.Forms.Label();
            this.NR_Button = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.AGC_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label53 = new System.Windows.Forms.Label();
            this.Default_High_Cut_listBox1 = new System.Windows.Forms.ListBox();
            this.label52 = new System.Windows.Forms.Label();
            this.Default_CW_Filter_listBox1 = new System.Windows.Forms.ListBox();
            this.label51 = new System.Windows.Forms.Label();
            this.Default_Low_Cut_listBox1 = new System.Windows.Forms.ListBox();
            this.label50 = new System.Windows.Forms.Label();
            this.Tune_vButton2 = new System.Windows.Forms.Button();
            this.QRP_Button = new System.Windows.Forms.Button();
            this.NB_Threshold_label1 = new System.Windows.Forms.Label();
            this.NB_label16 = new System.Windows.Forms.Label();
            this.NB_ON_OFF_button2 = new System.Windows.Forms.Button();
            this.NB_Threshold_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.NB_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.NR_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.AGC_listBox1 = new System.Windows.Forms.ListBox();
            this.AGC_label2 = new System.Windows.Forms.Label();
            this.Tune_Power_label37 = new System.Windows.Forms.Label();
            this.Tune_Power_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label36 = new System.Windows.Forms.Label();
            this.CW_Power_label36 = new System.Windows.Forms.Label();
            this.SSB_Power_label36 = new System.Windows.Forms.Label();
            this.AM_Carrier_label36 = new System.Windows.Forms.Label();
            this.CW_Power_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label34 = new System.Windows.Forms.Label();
            this.Power_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Power_label34 = new System.Windows.Forms.Label();
            this.TX_Bandwidth_listBox1 = new System.Windows.Forms.ListBox();
            this.AM_Carrier_label2 = new System.Windows.Forms.Label();
            this.AM_Carrier_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label14 = new System.Windows.Forms.Label();
            this.freqcaltab = new System.Windows.Forms.TabPage();
            this.Freq_Cal_groupBox4 = new System.Windows.Forms.GroupBox();
            this.PPM_Coarse_Value_Label = new System.Windows.Forms.Label();
            this.Freq_Cal_Loose_button = new System.Windows.Forms.Button();
            this.Adjust_PPM_Coarse_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.Signal_Average_label = new System.Windows.Forms.Label();
            this.Freq_Calibration_Status_label = new System.Windows.Forms.Label();
            this.Freq_Auto_Calibrate_button = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.Freq_Cal_Meter = new VU_MeterLibrary.VuMeter();
            this.Set_Calibration_button = new System.Windows.Forms.Button();
            this.Freq_CAl_Progress_Lable = new System.Windows.Forms.Label();
            this.Freq_Check_Button = new System.Windows.Forms.Button();
            this.Freq_Cal_Reset_button4 = new System.Windows.Forms.Button();
            this.Calibration_progressBar1 = new System.Windows.Forms.ProgressBar();
            this.IQ_groupBox3 = new System.Windows.Forms.GroupBox();
            this.IQ_Image_meter = new VU_MeterLibrary.VuMeter();
            this.IQ_RX_button = new System.Windows.Forms.Button();
            this.Reset_Freq_button3 = new System.Windows.Forms.Button();
            this.IQ_UP24KHz_checkBox2 = new System.Windows.Forms.CheckBox();
            this.IQ_Freq_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Cal_Freq_textBox2 = new System.Windows.Forms.TextBox();
            this.IQ_Reset_All_button2 = new System.Windows.Forms.Button();
            this.LeftResetbutton2 = new System.Windows.Forms.Button();
            this.LefthScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.IQ_Commit_button2 = new System.Windows.Forms.Button();
            this.IQLefttextBox2 = new System.Windows.Forms.TextBox();
            this.powertabPage1 = new System.Windows.Forms.TabPage();
            this.AMP_groupBox3 = new System.Windows.Forms.GroupBox();
            this.PA_Calibrate_button = new System.Windows.Forms.Button();
            this.PA_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.PA_Power_Limit_button = new System.Windows.Forms.Button();
            this.PA_TX_button8 = new System.Windows.Forms.Button();
            this.Calibration_Band_button8 = new System.Windows.Forms.Button();
            this.PA_Reset_button8 = new System.Windows.Forms.Button();
            this.Solidus_Fan_On_Temperature_button8 = new System.Windows.Forms.Button();
            this.Fan_Control_button8 = new System.Windows.Forms.Button();
            this.Solidus_Bias_button8 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.Power_calibration_label58 = new System.Windows.Forms.Label();
            this.AMP_Raw_Bias_label5 = new System.Windows.Forms.Label();
            this.AMP_Temp_MFC_AMP_label5 = new System.Windows.Forms.Label();
            this.AMP_label57 = new System.Windows.Forms.Label();
            this.Proficio_Band_Cal_groupBox = new System.Windows.Forms.GroupBox();
            this.Geminus_Band_Calibrated_630_button = new System.Windows.Forms.Button();
            this.Geminus_Band_Calibrated_2200_button = new System.Windows.Forms.Button();
            this.B630_Calibration_Status_label = new System.Windows.Forms.Label();
            this.B2200_Calibration_Status_label = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Proficio_Band_Calibrated_10_button = new System.Windows.Forms.Button();
            this.Proficio_Band_Calibrated_12_button = new System.Windows.Forms.Button();
            this.Proficio_Band_Calibrated_15_button = new System.Windows.Forms.Button();
            this.Proficio_Band_Calibrated_17_button = new System.Windows.Forms.Button();
            this.Proficio_Band_Calibrated_20_button = new System.Windows.Forms.Button();
            this.Proficio_Band_Calibrated_30_button = new System.Windows.Forms.Button();
            this.Proficio_Band_Calibrated_40_button = new System.Windows.Forms.Button();
            this.Proficio_Band_Calibrated_60_button = new System.Windows.Forms.Button();
            this.Proficio_Band_Calibrated_80_button = new System.Windows.Forms.Button();
            this.Proficio_Band_Calibrated_160_button = new System.Windows.Forms.Button();
            this.Proficio_Calibrate_button8 = new System.Windows.Forms.Button();
            this.Transceiver_Calibrate_groupBox = new System.Windows.Forms.GroupBox();
            this.XCRV_Power_Display_label33 = new System.Windows.Forms.Label();
            this.Proficio_Pwr_groupBox6 = new System.Windows.Forms.GroupBox();
            this.B630_radioButton = new System.Windows.Forms.RadioButton();
            this.B2200_radioButton = new System.Windows.Forms.RadioButton();
            this.B15radioButton = new System.Windows.Forms.RadioButton();
            this.B20radioButton = new System.Windows.Forms.RadioButton();
            this.B10radioButton = new System.Windows.Forms.RadioButton();
            this.B30radioButton = new System.Windows.Forms.RadioButton();
            this.B40radioButton = new System.Windows.Forms.RadioButton();
            this.B160radioButton = new System.Windows.Forms.RadioButton();
            this.B17radioButton = new System.Windows.Forms.RadioButton();
            this.B60radioButton = new System.Windows.Forms.RadioButton();
            this.B12radioButton = new System.Windows.Forms.RadioButton();
            this.B80radioButton = new System.Windows.Forms.RadioButton();
            this.Proficio_Calibrate_Power_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.powerlabel14 = new System.Windows.Forms.Label();
            this.Proficio_Manual_Calibrate_button = new System.Windows.Forms.Button();
            this.powertunebutton1 = new System.Windows.Forms.Button();
            this.powerrestorebutton2 = new System.Windows.Forms.Button();
            this.Audio_tabPage1 = new System.Windows.Forms.TabPage();
            this.CW_groupBox = new System.Windows.Forms.GroupBox();
            this.Potentia_checkBox = new System.Windows.Forms.CheckBox();
            this.CW_Mode_Phone_checkBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ritlistBox1 = new System.Windows.Forms.ListBox();
            this.CW_Hold_numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.CW_Speed_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CW_Paddle_listBox1 = new System.Windows.Forms.ListBox();
            this.CW_Weight_listBox1 = new System.Windows.Forms.ListBox();
            this.CW_Space_listBox1 = new System.Windows.Forms.ListBox();
            this.CW_Mode_listBox1 = new System.Windows.Forms.ListBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CW_Pitch_listBox1 = new System.Windows.Forms.ListBox();
            this.label35 = new System.Windows.Forms.Label();
            this.MFC = new System.Windows.Forms.TabPage();
            this.IQBD_TX_groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TX_IQ_Balance_label = new System.Windows.Forms.Label();
            this.IQ_TX_Label = new System.Windows.Forms.Label();
            this.Geminus_Select_Band_button = new System.Windows.Forms.Button();
            this.IQBD_Meter = new VU_MeterLibrary.VuMeter();
            this.IQ_TX_Band_button = new System.Windows.Forms.Button();
            this.IQ_TX_Button = new System.Windows.Forms.Button();
            this.IQBD_Reset_button8 = new System.Windows.Forms.Button();
            this.IQBD_Auto_button8 = new System.Windows.Forms.Button();
            this.IQBD_TX_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.IQBD_TX_Power_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.IQBD_Monitor_label = new System.Windows.Forms.Label();
            this.IQBD_TX_Tune_button = new System.Windows.Forms.Button();
            this.metertab = new System.Windows.Forms.TabPage();
            this.Server_Message_label = new System.Windows.Forms.Label();
            this.Reset_Logs_button = new System.Windows.Forms.Button();
            this.Beta_checkBox = new System.Windows.Forms.CheckBox();
            this.Spectrum_button9 = new System.Windows.Forms.Button();
            this.Colors_groupBox = new System.Windows.Forms.GroupBox();
            this.Color_Reset_button5 = new System.Windows.Forms.Button();
            this.Button_Color_label49 = new System.Windows.Forms.Label();
            this.Button_BG_Color_button5 = new System.Windows.Forms.Button();
            this.Button_Text_Color_button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Freq_Digit_Test_label58 = new System.Windows.Forms.Label();
            this.Freq_Color_button4 = new System.Windows.Forms.Button();
            this.Boarder_Color_button4 = new System.Windows.Forms.Button();
            this.SMeter_groupBox4 = new System.Windows.Forms.GroupBox();
            this.Smeter_Hold_Time_button = new System.Windows.Forms.Button();
            this.Peak_Needle_Delay_button = new System.Windows.Forms.Button();
            this.Smeter_Peak_Needle_Color_button = new System.Windows.Forms.Button();
            this.S_Meter_Color_button = new System.Windows.Forms.Button();
            this.VU_Blink_button = new System.Windows.Forms.Button();
            this.Smeter_Dbm_button = new System.Windows.Forms.Button();
            this.Smeter_Decay = new System.Windows.Forms.CheckBox();
            this.Temperature_Selection_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Main_Meter_Temperature_Preferred = new System.Windows.Forms.Button();
            this.Main_Meter_ALC_Preferred = new System.Windows.Forms.Button();
            this.Main_Meter_I_Preferred = new System.Windows.Forms.Button();
            this.Main_Meter_SWR_Preferred = new System.Windows.Forms.Button();
            this.Main_Meter_Power_Preferred = new System.Windows.Forms.Button();
            this.Smeter_Average_button8 = new System.Windows.Forms.Button();
            this.Peak_Needle_checkBox2 = new System.Windows.Forms.CheckBox();
            this.Freq_Comp_label32 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Mic_Digital_Pre_Gain_button = new System.Windows.Forms.Button();
            this.Compression_Up_button = new System.Windows.Forms.Button();
            this.Compression_Down_button = new System.Windows.Forms.Button();
            this.Digital_Volume_Attn_button5 = new System.Windows.Forms.Button();
            this.Volume_Attn_button8 = new System.Windows.Forms.Button();
            this.Mic_Pre_Gain_button8 = new System.Windows.Forms.Button();
            this.Compression_Level_hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Compression_button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Compression_label44 = new System.Windows.Forms.Label();
            this.Mic_Gain_label2 = new System.Windows.Forms.Label();
            this.Time_checkBox2 = new System.Windows.Forms.CheckBox();
            this.Monitorbutton = new System.Windows.Forms.Button();
            this.RPi_Temperature_label1 = new System.Windows.Forms.Label();
            this.AMP_Current_label5 = new System.Windows.Forms.Label();
            this.Amplifier_temperature_label58 = new System.Windows.Forms.Label();
            this.Temperature_label57 = new System.Windows.Forms.Label();
            this.Relay_Board_checkBox2 = new System.Windows.Forms.CheckBox();
            this.MSCC_Core_Version_label45 = new System.Windows.Forms.Label();
            this.MSCC_Display_label44 = new System.Windows.Forms.Label();
            this.HR50_PPT_listBox1 = new System.Windows.Forms.ListBox();
            this.HR50_checkBox2 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.HR50_listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SDRcore_Trans_Version = new System.Windows.Forms.Label();
            this.SDRcore_Recv_Version_label16 = new System.Windows.Forms.Label();
            this.MS_SDR_Version_label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firmwarelabel16 = new System.Windows.Forms.Label();
            this.Transvertercheckbox = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Smeter_Timer = new System.Windows.Forms.Timer(this.components);
            this.Waterfall_timer = new System.Windows.Forms.Timer(this.components);
            this.Master_State_Machine_Timer = new System.Windows.Forms.Timer(this.components);
            this.PA_Calibrate_Timer = new System.Windows.Forms.Timer(this.components);
            this.Proficio_Calibrate_timer = new System.Windows.Forms.Timer(this.components);
            this.PA_Display_Power_Timer = new System.Windows.Forms.Timer(this.components);
            this.ALC_Blink_timer1 = new System.Windows.Forms.Timer(this.components);
            this.Main_Frequency_Update_timer4 = new System.Windows.Forms.Timer(this.components);
            this.Mouse_Timer = new System.Windows.Forms.Timer(this.components);
            this.MFC_Update_Timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Message_Blink_timer = new System.Windows.Forms.Timer(this.components);
            this.Freq_Cal_Smeter_Timer = new System.Windows.Forms.Timer(this.components);
            this.Windows_Move_timer = new System.Windows.Forms.Timer(this.components);
            this.Clock_timer = new System.Windows.Forms.Timer(this.components);
            this.GEM_BCN_Button_1 = new System.Windows.Forms.RadioButton();
            this.GEM_BCN_Button_2 = new System.Windows.Forms.RadioButton();
            this.powertabControl1.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.GEM_Group_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWaterfall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpectrum)).BeginInit();
            this.RIT_groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Band_Set_2.SuspendLayout();
            this.TX.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Power_Meter_Hold)).BeginInit();
            this.freqcaltab.SuspendLayout();
            this.Freq_Cal_groupBox4.SuspendLayout();
            this.IQ_groupBox3.SuspendLayout();
            this.powertabPage1.SuspendLayout();
            this.AMP_groupBox3.SuspendLayout();
            this.Proficio_Band_Cal_groupBox.SuspendLayout();
            this.Transceiver_Calibrate_groupBox.SuspendLayout();
            this.Proficio_Pwr_groupBox6.SuspendLayout();
            this.Audio_tabPage1.SuspendLayout();
            this.CW_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CW_Hold_numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CW_Speed_numericUpDown)).BeginInit();
            this.MFC.SuspendLayout();
            this.IQBD_TX_groupBox.SuspendLayout();
            this.metertab.SuspendLayout();
            this.Colors_groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SMeter_groupBox4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // powertabControl1
            // 
            this.powertabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.powertabControl1.Controls.Add(this.mainPage);
            this.powertabControl1.Controls.Add(this.TX);
            this.powertabControl1.Controls.Add(this.freqcaltab);
            this.powertabControl1.Controls.Add(this.powertabPage1);
            this.powertabControl1.Controls.Add(this.Audio_tabPage1);
            this.powertabControl1.Controls.Add(this.MFC);
            this.powertabControl1.Controls.Add(this.metertab);
            this.powertabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powertabControl1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powertabControl1.HotTrack = true;
            this.powertabControl1.ItemSize = new System.Drawing.Size(96, 20);
            this.powertabControl1.Location = new System.Drawing.Point(0, 0);
            this.powertabControl1.Name = "powertabControl1";
            this.powertabControl1.Padding = new System.Drawing.Point(0, 0);
            this.powertabControl1.SelectedIndex = 0;
            this.powertabControl1.ShowToolTips = true;
            this.powertabControl1.Size = new System.Drawing.Size(814, 509);
            this.powertabControl1.TabIndex = 0;
            this.powertabControl1.SelectedIndexChanged += new System.EventHandler(this.powertabControl1_SelectedIndexChanged);
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.Color.Black;
            this.mainPage.Controls.Add(this.GEM_Group_Box);
            this.mainPage.Controls.Add(this.picWaterfall);
            this.mainPage.Controls.Add(this.picSpectrum);
            this.mainPage.Controls.Add(this.Freq_Add_Stack_Button);
            this.mainPage.Controls.Add(this.Freq_Stack_button);
            this.mainPage.Controls.Add(this.MIC_Gain_Down_button);
            this.mainPage.Controls.Add(this.MIC_Gain_UP_button);
            this.mainPage.Controls.Add(this.Volume_Down_button);
            this.mainPage.Controls.Add(this.Volume_UP_button);
            this.mainPage.Controls.Add(this.NR_button3);
            this.mainPage.Controls.Add(this.RIT_groupBox4);
            this.mainPage.Controls.Add(this.button4);
            this.mainPage.Controls.Add(this.GEN_button);
            this.mainPage.Controls.Add(this.Meter_Temperature_button8);
            this.mainPage.Controls.Add(this.Meter_ALC_button8);
            this.mainPage.Controls.Add(this.Meter_I_button8);
            this.mainPage.Controls.Add(this.Meter_SWR_button8);
            this.mainPage.Controls.Add(this.Meter_Power_button8);
            this.mainPage.Controls.Add(this.Dbm_label9);
            this.mainPage.Controls.Add(this.PA_button);
            this.mainPage.Controls.Add(this.Dbm_Value_label9);
            this.mainPage.Controls.Add(this.Power_Value_label2);
            this.mainPage.Controls.Add(this.CW_Filter_button8);
            this.mainPage.Controls.Add(this.Low_Cut_Filter_button8);
            this.mainPage.Controls.Add(this.High_Cut_button8);
            this.mainPage.Controls.Add(this.Step_button8);
            this.mainPage.Controls.Add(this.Microphone_textBox2);
            this.mainPage.Controls.Add(this.Volume_textBox2);
            this.mainPage.Controls.Add(this.UTC_Date_label46);
            this.mainPage.Controls.Add(this.Time_display_UTC_label34);
            this.mainPage.Controls.Add(this.Minimize_checkBox2);
            this.mainPage.Controls.Add(this.Audio_Digital_button3);
            this.mainPage.Controls.Add(this.Split_Button);
            this.mainPage.Controls.Add(this.Spectrum_Controls_button3);
            this.mainPage.Controls.Add(this.VFO_button);
            this.mainPage.Controls.Add(this.ACG_button);
            this.mainPage.Controls.Add(this.Compression_button4);
            this.mainPage.Controls.Add(this.Auto_Zero_checkBox2);
            this.mainPage.Controls.Add(this.Local_Date_label46);
            this.mainPage.Controls.Add(this.NB_button2);
            this.mainPage.Controls.Add(this.Time_display_label33);
            this.mainPage.Controls.Add(this.TX_Mute_button2);
            this.mainPage.Controls.Add(this.Volume_Mute_button2);
            this.mainPage.Controls.Add(this.MicVolume_hScrollBar1);
            this.mainPage.Controls.Add(this.Volume_hScrollBar1);
            this.mainPage.Controls.Add(this.Freqbutton3);
            this.mainPage.Controls.Add(this.button1);
            this.mainPage.Controls.Add(this.mainmodebutton2);
            this.mainPage.Controls.Add(this.buttTune);
            this.mainPage.Controls.Add(this.Band_Change_Auto_Tune_checkBox2);
            this.mainPage.Controls.Add(this.groupBox3);
            this.mainPage.Controls.Add(this.Main_Power_hScrollBar1);
            this.mainPage.Controls.Add(this.Monitor_button8);
            this.mainPage.Controls.Add(this.Smeter_Display_Value_label);
            this.mainPage.Controls.Add(this.vuMeter1);
            this.mainPage.Controls.Add(this.Band_Set_2);
            this.mainPage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPage.ForeColor = System.Drawing.Color.Black;
            this.mainPage.Location = new System.Drawing.Point(4, 24);
            this.mainPage.Margin = new System.Windows.Forms.Padding(0);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(806, 481);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "     Main     ";
            this.mainPage.ToolTipText = "MAIN TRANSCEIVER CONTROLS";
            this.mainPage.Click += new System.EventHandler(this.mainPage_Click);
            this.mainPage.Enter += new System.EventHandler(this.Main_Tab_Enter);
            this.mainPage.Leave += new System.EventHandler(this.Main_Tab_Leave);
            // 
            // GEM_Group_Box
            // 
            this.GEM_Group_Box.BackColor = System.Drawing.Color.Transparent;
            this.GEM_Group_Box.Controls.Add(this.GEM_BCN_Button_2);
            this.GEM_Group_Box.Controls.Add(this.GEM_BCN_Button_1);
            this.GEM_Group_Box.Controls.Add(this.GEM_BCN_Button);
            this.GEM_Group_Box.Controls.Add(this.GEM_GEN_Butt);
            this.GEM_Group_Box.Controls.Add(this.MF_Button);
            this.GEM_Group_Box.Controls.Add(this.LF_Button);
            this.GEM_Group_Box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GEM_Group_Box.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEM_Group_Box.ForeColor = System.Drawing.Color.White;
            this.GEM_Group_Box.Location = new System.Drawing.Point(8, 124);
            this.GEM_Group_Box.Name = "GEM_Group_Box";
            this.GEM_Group_Box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GEM_Group_Box.Size = new System.Drawing.Size(777, 40);
            this.GEM_Group_Box.TabIndex = 210;
            this.GEM_Group_Box.TabStop = false;
            this.GEM_Group_Box.Text = "BAND SELECTION";
            this.GEM_Group_Box.Enter += new System.EventHandler(this.GEM_Group_Box_Enter);
            // 
            // GEM_BCN_Button
            // 
            this.GEM_BCN_Button.AutoSize = true;
            this.GEM_BCN_Button.BackColor = System.Drawing.Color.Transparent;
            this.GEM_BCN_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GEM_BCN_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEM_BCN_Button.ForeColor = System.Drawing.Color.White;
            this.GEM_BCN_Button.Location = new System.Drawing.Point(295, 12);
            this.GEM_BCN_Button.Name = "GEM_BCN_Button";
            this.GEM_BCN_Button.Size = new System.Drawing.Size(68, 27);
            this.GEM_BCN_Button.TabIndex = 52;
            this.GEM_BCN_Button.Text = "BCN";
            this.GEM_BCN_Button.UseVisualStyleBackColor = false;
            this.GEM_BCN_Button.CheckedChanged += new System.EventHandler(this.GEM_BCN_Button_CheckedChanged);
            // 
            // GEM_GEN_Butt
            // 
            this.GEM_GEN_Butt.AutoSize = true;
            this.GEM_GEN_Butt.BackColor = System.Drawing.Color.Transparent;
            this.GEM_GEN_Butt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GEM_GEN_Butt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEM_GEN_Butt.ForeColor = System.Drawing.Color.White;
            this.GEM_GEN_Butt.Location = new System.Drawing.Point(658, 12);
            this.GEM_GEN_Butt.Name = "GEM_GEN_Butt";
            this.GEM_GEN_Butt.Size = new System.Drawing.Size(69, 27);
            this.GEM_GEN_Butt.TabIndex = 51;
            this.GEM_GEN_Butt.Text = "GEN";
            this.GEM_GEN_Butt.UseVisualStyleBackColor = false;
            this.GEM_GEN_Butt.CheckedChanged += new System.EventHandler(this.GEM_GEN_Butt_CheckedChanged);
            // 
            // MF_Button
            // 
            this.MF_Button.AutoSize = true;
            this.MF_Button.BackColor = System.Drawing.Color.Transparent;
            this.MF_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MF_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MF_Button.ForeColor = System.Drawing.Color.White;
            this.MF_Button.Location = new System.Drawing.Point(170, 12);
            this.MF_Button.Name = "MF_Button";
            this.MF_Button.Size = new System.Drawing.Size(80, 27);
            this.MF_Button.TabIndex = 44;
            this.MF_Button.Text = "630M";
            this.MF_Button.UseVisualStyleBackColor = false;
            this.MF_Button.CheckedChanged += new System.EventHandler(this.MF_Button_CheckedChanged_1);
            // 
            // LF_Button
            // 
            this.LF_Button.AutoSize = true;
            this.LF_Button.BackColor = System.Drawing.Color.Transparent;
            this.LF_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LF_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LF_Button.ForeColor = System.Drawing.Color.White;
            this.LF_Button.Location = new System.Drawing.Point(33, 12);
            this.LF_Button.Name = "LF_Button";
            this.LF_Button.Size = new System.Drawing.Size(92, 27);
            this.LF_Button.TabIndex = 43;
            this.LF_Button.Text = "2200M";
            this.LF_Button.UseVisualStyleBackColor = false;
            this.LF_Button.CheckedChanged += new System.EventHandler(this.LF_Button_CheckedChanged_1);
            // 
            // picWaterfall
            // 
            this.picWaterfall.BackColor = System.Drawing.Color.White;
            this.picWaterfall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWaterfall.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picWaterfall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picWaterfall.Location = new System.Drawing.Point(8, 357);
            this.picWaterfall.Margin = new System.Windows.Forms.Padding(0);
            this.picWaterfall.Name = "picWaterfall";
            this.picWaterfall.Size = new System.Drawing.Size(777, 76);
            this.picWaterfall.TabIndex = 235;
            this.picWaterfall.TabStop = false;
            // 
            // picSpectrum
            // 
            this.picSpectrum.BackColor = System.Drawing.Color.White;
            this.picSpectrum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSpectrum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picSpectrum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSpectrum.Location = new System.Drawing.Point(8, 281);
            this.picSpectrum.Margin = new System.Windows.Forms.Padding(0);
            this.picSpectrum.Name = "picSpectrum";
            this.picSpectrum.Size = new System.Drawing.Size(777, 76);
            this.picSpectrum.TabIndex = 234;
            this.picSpectrum.TabStop = false;
            this.picSpectrum.Click += new System.EventHandler(this.picSpectrum_Click);
            this.picSpectrum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Set_freq);
            this.picSpectrum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.picSpectrum.MouseEnter += new System.EventHandler(this.Display_User_Cursor);
            this.picSpectrum.MouseLeave += new System.EventHandler(this.Hide_User_Cursor);
            this.picSpectrum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CursorValueEvent);
            this.picSpectrum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Freq_Add_Stack_Button
            // 
            this.Freq_Add_Stack_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Add_Stack_Button.Enabled = false;
            this.Freq_Add_Stack_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Freq_Add_Stack_Button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Add_Stack_Button.ForeColor = System.Drawing.Color.Black;
            this.Freq_Add_Stack_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Freq_Add_Stack_Button.Location = new System.Drawing.Point(219, 98);
            this.Freq_Add_Stack_Button.Name = "Freq_Add_Stack_Button";
            this.Freq_Add_Stack_Button.Size = new System.Drawing.Size(15, 15);
            this.Freq_Add_Stack_Button.TabIndex = 218;
            this.Freq_Add_Stack_Button.UseVisualStyleBackColor = false;
            this.Freq_Add_Stack_Button.Visible = false;
            this.Freq_Add_Stack_Button.Click += new System.EventHandler(this.Freq_Add_Stack_Button_Click);
            // 
            // Freq_Stack_button
            // 
            this.Freq_Stack_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Stack_button.Enabled = false;
            this.Freq_Stack_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Freq_Stack_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Stack_button.ForeColor = System.Drawing.Color.Black;
            this.Freq_Stack_button.Location = new System.Drawing.Point(158, 61);
            this.Freq_Stack_button.Name = "Freq_Stack_button";
            this.Freq_Stack_button.Size = new System.Drawing.Size(59, 26);
            this.Freq_Stack_button.TabIndex = 217;
            this.Freq_Stack_button.Text = "STK";
            this.toolTip.SetToolTip(this.Freq_Stack_button, "BAND STACK (VFO A ONLY)\r\nLEFT CLICK RECALL\r\nRIGHT CLICK SET");
            this.Freq_Stack_button.UseVisualStyleBackColor = false;
            this.Freq_Stack_button.Click += new System.EventHandler(this.Freq_Stack_button_Click);
            this.Freq_Stack_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Freq_Stack_button_Click);
            // 
            // MIC_Gain_Down_button
            // 
            this.MIC_Gain_Down_button.BackColor = System.Drawing.Color.Gainsboro;
            this.MIC_Gain_Down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MIC_Gain_Down_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIC_Gain_Down_button.ForeColor = System.Drawing.Color.Black;
            this.MIC_Gain_Down_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MIC_Gain_Down_button.Location = new System.Drawing.Point(595, 235);
            this.MIC_Gain_Down_button.Name = "MIC_Gain_Down_button";
            this.MIC_Gain_Down_button.Size = new System.Drawing.Size(20, 20);
            this.MIC_Gain_Down_button.TabIndex = 214;
            this.toolTip.SetToolTip(this.MIC_Gain_Down_button, "CLICK OR TAP TO\r\nMICROPHONE GAIN");
            this.MIC_Gain_Down_button.UseVisualStyleBackColor = false;
            this.MIC_Gain_Down_button.Click += new System.EventHandler(this.MIC_Gain_Down_button_Click);
            this.MIC_Gain_Down_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MIC_Gain_Down_button_Mouse_Down);
            this.MIC_Gain_Down_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MIC_Gain_Down_button_Mouse_Up);
            // 
            // MIC_Gain_UP_button
            // 
            this.MIC_Gain_UP_button.BackColor = System.Drawing.Color.Gainsboro;
            this.MIC_Gain_UP_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MIC_Gain_UP_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIC_Gain_UP_button.ForeColor = System.Drawing.Color.Black;
            this.MIC_Gain_UP_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MIC_Gain_UP_button.Location = new System.Drawing.Point(760, 235);
            this.MIC_Gain_UP_button.Name = "MIC_Gain_UP_button";
            this.MIC_Gain_UP_button.Size = new System.Drawing.Size(20, 20);
            this.MIC_Gain_UP_button.TabIndex = 213;
            this.toolTip.SetToolTip(this.MIC_Gain_UP_button, "CLICK OR TAP TO\r\nINCREASE MICROPHONE GAIN");
            this.MIC_Gain_UP_button.UseVisualStyleBackColor = false;
            this.MIC_Gain_UP_button.Click += new System.EventHandler(this.MIC_Gain_Up_button_Click);
            this.MIC_Gain_UP_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MIC_Gain_Up_button_Mouse_Down);
            this.MIC_Gain_UP_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MIC_Gain_Up_button_Mouse_Up);
            // 
            // Volume_Down_button
            // 
            this.Volume_Down_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Volume_Down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volume_Down_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume_Down_button.ForeColor = System.Drawing.Color.Black;
            this.Volume_Down_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Volume_Down_button.Location = new System.Drawing.Point(12, 235);
            this.Volume_Down_button.Name = "Volume_Down_button";
            this.Volume_Down_button.Size = new System.Drawing.Size(20, 20);
            this.Volume_Down_button.TabIndex = 212;
            this.toolTip.SetToolTip(this.Volume_Down_button, "CLICK OR TAP TO\r\nDECREASE VOLUME");
            this.Volume_Down_button.UseVisualStyleBackColor = false;
            this.Volume_Down_button.Click += new System.EventHandler(this.Volume_Down_button_Click);
            this.Volume_Down_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Volume_Down_button_Mouse_Down);
            this.Volume_Down_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Volume_Down_button_Mouse_Up);
            // 
            // Volume_UP_button
            // 
            this.Volume_UP_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Volume_UP_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volume_UP_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume_UP_button.ForeColor = System.Drawing.Color.Black;
            this.Volume_UP_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Volume_UP_button.Location = new System.Drawing.Point(177, 235);
            this.Volume_UP_button.Name = "Volume_UP_button";
            this.Volume_UP_button.Size = new System.Drawing.Size(20, 20);
            this.Volume_UP_button.TabIndex = 211;
            this.toolTip.SetToolTip(this.Volume_UP_button, "CLICK OR TAP TO\r\nINCREASE VOLUME");
            this.Volume_UP_button.UseVisualStyleBackColor = false;
            this.Volume_UP_button.Click += new System.EventHandler(this.Volume_UP_button_Click);
            this.Volume_UP_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Volume_Up_button_Mouse_Down);
            this.Volume_UP_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Volume_Up_button_Mouse_Up);
            // 
            // NR_button3
            // 
            this.NR_button3.BackColor = System.Drawing.Color.Gainsboro;
            this.NR_button3.Enabled = false;
            this.NR_button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NR_button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NR_button3.ForeColor = System.Drawing.Color.Black;
            this.NR_button3.Location = new System.Drawing.Point(210, 175);
            this.NR_button3.Name = "NR_button3";
            this.NR_button3.Size = new System.Drawing.Size(29, 29);
            this.NR_button3.TabIndex = 138;
            this.NR_button3.Text = "N";
            this.NR_button3.UseVisualStyleBackColor = false;
            this.NR_button3.Visible = false;
            this.NR_button3.Click += new System.EventHandler(this.NR_button3_Click);
            // 
            // RIT_groupBox4
            // 
            this.RIT_groupBox4.Controls.Add(this.StartUP_label44);
            this.RIT_groupBox4.Controls.Add(this.RIT_Up_button);
            this.RIT_groupBox4.Controls.Add(this.RIT_Down_button);
            this.RIT_groupBox4.Controls.Add(this.ritfreqtextBox1);
            this.RIT_groupBox4.Controls.Add(this.buttReset);
            this.RIT_groupBox4.Controls.Add(this.ritbutton1);
            this.RIT_groupBox4.Controls.Add(this.ritScroll);
            this.RIT_groupBox4.Controls.Add(this.Error_Message_label);
            this.RIT_groupBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIT_groupBox4.ForeColor = System.Drawing.Color.White;
            this.RIT_groupBox4.Location = new System.Drawing.Point(262, 161);
            this.RIT_groupBox4.Name = "RIT_groupBox4";
            this.RIT_groupBox4.Size = new System.Drawing.Size(268, 75);
            this.RIT_groupBox4.TabIndex = 176;
            this.RIT_groupBox4.TabStop = false;
            this.RIT_groupBox4.Text = "RIT";
            // 
            // StartUP_label44
            // 
            this.StartUP_label44.BackColor = System.Drawing.Color.Black;
            this.StartUP_label44.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartUP_label44.ForeColor = System.Drawing.Color.LightGreen;
            this.StartUP_label44.Location = new System.Drawing.Point(-6, 0);
            this.StartUP_label44.Name = "StartUP_label44";
            this.StartUP_label44.Size = new System.Drawing.Size(280, 77);
            this.StartUP_label44.TabIndex = 141;
            this.StartUP_label44.Text = "MSCC INITIALIZING\r\nPLEASE WAIT";
            this.StartUP_label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartUP_label44.Click += new System.EventHandler(this.StartUP_label44_Click);
            // 
            // RIT_Up_button
            // 
            this.RIT_Up_button.BackColor = System.Drawing.Color.Gainsboro;
            this.RIT_Up_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RIT_Up_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIT_Up_button.ForeColor = System.Drawing.Color.Black;
            this.RIT_Up_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RIT_Up_button.Location = new System.Drawing.Point(242, 48);
            this.RIT_Up_button.Name = "RIT_Up_button";
            this.RIT_Up_button.Size = new System.Drawing.Size(20, 20);
            this.RIT_Up_button.TabIndex = 216;
            this.RIT_Up_button.UseVisualStyleBackColor = false;
            this.RIT_Up_button.Click += new System.EventHandler(this.RIT_Up_button_Click);
            this.RIT_Up_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RIT_Up_button_Mouse_Down);
            this.RIT_Up_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RIT_Up_button_Mouse_Up);
            // 
            // RIT_Down_button
            // 
            this.RIT_Down_button.BackColor = System.Drawing.Color.Gainsboro;
            this.RIT_Down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RIT_Down_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIT_Down_button.ForeColor = System.Drawing.Color.Black;
            this.RIT_Down_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RIT_Down_button.Location = new System.Drawing.Point(7, 48);
            this.RIT_Down_button.Name = "RIT_Down_button";
            this.RIT_Down_button.Size = new System.Drawing.Size(20, 20);
            this.RIT_Down_button.TabIndex = 213;
            this.RIT_Down_button.UseVisualStyleBackColor = false;
            this.RIT_Down_button.Click += new System.EventHandler(this.RIT_Down_button_Click);
            this.RIT_Down_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RIT_Down_button_Mouse_Down);
            this.RIT_Down_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RIT_Down_button_Mouse_Up);
            // 
            // ritfreqtextBox1
            // 
            this.ritfreqtextBox1.BackColor = System.Drawing.Color.Black;
            this.ritfreqtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ritfreqtextBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ritfreqtextBox1.ForeColor = System.Drawing.Color.White;
            this.ritfreqtextBox1.Location = new System.Drawing.Point(66, 20);
            this.ritfreqtextBox1.Name = "ritfreqtextBox1";
            this.ritfreqtextBox1.ReadOnly = true;
            this.ritfreqtextBox1.Size = new System.Drawing.Size(137, 24);
            this.ritfreqtextBox1.TabIndex = 156;
            this.ritfreqtextBox1.Text = "10.000.000";
            this.ritfreqtextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ritfreqtextBox1.TextChanged += new System.EventHandler(this.ritfreqtextBox1_TextChanged_1);
            // 
            // buttReset
            // 
            this.buttReset.BackColor = System.Drawing.Color.Gainsboro;
            this.buttReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttReset.ForeColor = System.Drawing.Color.Black;
            this.buttReset.Location = new System.Drawing.Point(5, 21);
            this.buttReset.Name = "buttReset";
            this.buttReset.Size = new System.Drawing.Size(54, 23);
            this.buttReset.TabIndex = 2;
            this.buttReset.Text = "RST";
            this.toolTip.SetToolTip(this.buttReset, "RESET RIT FREQUENCY");
            this.buttReset.UseVisualStyleBackColor = false;
            this.buttReset.Click += new System.EventHandler(this.buttReset_Click);
            // 
            // ritbutton1
            // 
            this.ritbutton1.BackColor = System.Drawing.Color.Gainsboro;
            this.ritbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ritbutton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ritbutton1.ForeColor = System.Drawing.Color.Black;
            this.ritbutton1.Location = new System.Drawing.Point(208, 20);
            this.ritbutton1.Name = "ritbutton1";
            this.ritbutton1.Size = new System.Drawing.Size(54, 23);
            this.ritbutton1.TabIndex = 33;
            this.ritbutton1.Text = "RIT";
            this.toolTip.SetToolTip(this.ritbutton1, "RIT ON/OFF");
            this.ritbutton1.UseVisualStyleBackColor = false;
            this.ritbutton1.Click += new System.EventHandler(this.ritbutton1_Click);
            // 
            // ritScroll
            // 
            this.ritScroll.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.ritScroll.Location = new System.Drawing.Point(32, 47);
            this.ritScroll.Maximum = 1009;
            this.ritScroll.Minimum = -1000;
            this.ritScroll.Name = "ritScroll";
            this.ritScroll.Size = new System.Drawing.Size(205, 21);
            this.ritScroll.TabIndex = 0;
            this.ritScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ritScroll_Scroll);
            this.ritScroll.MouseEnter += new System.EventHandler(this.ritScroll_Scroll_Enter);
            this.ritScroll.MouseLeave += new System.EventHandler(this.ritScroll_Scroll_Leave);
            // 
            // Error_Message_label
            // 
            this.Error_Message_label.BackColor = System.Drawing.Color.Gainsboro;
            this.Error_Message_label.Enabled = false;
            this.Error_Message_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Message_label.ForeColor = System.Drawing.Color.Red;
            this.Error_Message_label.Location = new System.Drawing.Point(-6, -1);
            this.Error_Message_label.Name = "Error_Message_label";
            this.Error_Message_label.Size = new System.Drawing.Size(280, 77);
            this.Error_Message_label.TabIndex = 217;
            this.Error_Message_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Error_Message_label.Visible = false;
            this.Error_Message_label.Click += new System.EventHandler(this.Error_Message_label_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(668, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 26);
            this.button4.TabIndex = 167;
            this.button4.Text = "EXT";
            this.toolTip.SetToolTip(this.button4, "STOP MSCC");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GEN_button
            // 
            this.GEN_button.BackColor = System.Drawing.Color.Gainsboro;
            this.GEN_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GEN_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEN_button.ForeColor = System.Drawing.Color.Black;
            this.GEN_button.Location = new System.Drawing.Point(530, 169);
            this.GEN_button.Name = "GEN_button";
            this.GEN_button.Size = new System.Drawing.Size(59, 26);
            this.GEN_button.TabIndex = 206;
            this.GEN_button.Text = "HAM";
            this.toolTip.SetToolTip(this.GEN_button, "SELECT HAM BANDS \r\nOR \r\nGENERAL BAND");
            this.GEN_button.UseVisualStyleBackColor = false;
            this.GEN_button.Visible = false;
            this.GEN_button.Click += new System.EventHandler(this.GEN_button_Click);
            // 
            // Meter_Temperature_button8
            // 
            this.Meter_Temperature_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Meter_Temperature_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Meter_Temperature_button8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meter_Temperature_button8.ForeColor = System.Drawing.Color.Black;
            this.Meter_Temperature_button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Meter_Temperature_button8.Location = new System.Drawing.Point(122, 96);
            this.Meter_Temperature_button8.Name = "Meter_Temperature_button8";
            this.Meter_Temperature_button8.Size = new System.Drawing.Size(19, 19);
            this.Meter_Temperature_button8.TabIndex = 205;
            this.Meter_Temperature_button8.Text = "T";
            this.toolTip.SetToolTip(this.Meter_Temperature_button8, "TEMPERATURE");
            this.Meter_Temperature_button8.UseVisualStyleBackColor = false;
            this.Meter_Temperature_button8.Click += new System.EventHandler(this.Meter_Temperature_button8_Click);
            // 
            // Meter_ALC_button8
            // 
            this.Meter_ALC_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Meter_ALC_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Meter_ALC_button8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meter_ALC_button8.ForeColor = System.Drawing.Color.Black;
            this.Meter_ALC_button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Meter_ALC_button8.Location = new System.Drawing.Point(72, 96);
            this.Meter_ALC_button8.Name = "Meter_ALC_button8";
            this.Meter_ALC_button8.Size = new System.Drawing.Size(19, 19);
            this.Meter_ALC_button8.TabIndex = 204;
            this.Meter_ALC_button8.Text = "A";
            this.toolTip.SetToolTip(this.Meter_ALC_button8, "ALC");
            this.Meter_ALC_button8.UseVisualStyleBackColor = false;
            this.Meter_ALC_button8.Click += new System.EventHandler(this.Meter_ALC_button8_Click);
            // 
            // Meter_I_button8
            // 
            this.Meter_I_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Meter_I_button8.Enabled = false;
            this.Meter_I_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Meter_I_button8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meter_I_button8.ForeColor = System.Drawing.Color.Black;
            this.Meter_I_button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Meter_I_button8.Location = new System.Drawing.Point(97, 96);
            this.Meter_I_button8.Name = "Meter_I_button8";
            this.Meter_I_button8.Size = new System.Drawing.Size(19, 19);
            this.Meter_I_button8.TabIndex = 204;
            this.Meter_I_button8.Text = "I";
            this.toolTip.SetToolTip(this.Meter_I_button8, "CURRENT (I)");
            this.Meter_I_button8.UseVisualStyleBackColor = false;
            this.Meter_I_button8.Click += new System.EventHandler(this.Meter_I_button8_Click);
            // 
            // Meter_SWR_button8
            // 
            this.Meter_SWR_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Meter_SWR_button8.Enabled = false;
            this.Meter_SWR_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Meter_SWR_button8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meter_SWR_button8.ForeColor = System.Drawing.Color.Black;
            this.Meter_SWR_button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Meter_SWR_button8.Location = new System.Drawing.Point(22, 96);
            this.Meter_SWR_button8.Name = "Meter_SWR_button8";
            this.Meter_SWR_button8.Size = new System.Drawing.Size(19, 19);
            this.Meter_SWR_button8.TabIndex = 204;
            this.Meter_SWR_button8.Text = "S";
            this.toolTip.SetToolTip(this.Meter_SWR_button8, "SWR");
            this.Meter_SWR_button8.UseVisualStyleBackColor = false;
            this.Meter_SWR_button8.Click += new System.EventHandler(this.Meter_SWR_button8_Click);
            // 
            // Meter_Power_button8
            // 
            this.Meter_Power_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Meter_Power_button8.Enabled = false;
            this.Meter_Power_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Meter_Power_button8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meter_Power_button8.ForeColor = System.Drawing.Color.Black;
            this.Meter_Power_button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Meter_Power_button8.Location = new System.Drawing.Point(47, 96);
            this.Meter_Power_button8.Name = "Meter_Power_button8";
            this.Meter_Power_button8.Size = new System.Drawing.Size(19, 19);
            this.Meter_Power_button8.TabIndex = 203;
            this.Meter_Power_button8.Text = "P";
            this.toolTip.SetToolTip(this.Meter_Power_button8, "POWER");
            this.Meter_Power_button8.UseVisualStyleBackColor = false;
            this.Meter_Power_button8.Click += new System.EventHandler(this.Meter_Power_button8_Click);
            // 
            // Dbm_label9
            // 
            this.Dbm_label9.BackColor = System.Drawing.Color.Transparent;
            this.Dbm_label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbm_label9.ForeColor = System.Drawing.Color.White;
            this.Dbm_label9.Location = new System.Drawing.Point(37, 71);
            this.Dbm_label9.Name = "Dbm_label9";
            this.Dbm_label9.Size = new System.Drawing.Size(53, 24);
            this.Dbm_label9.TabIndex = 199;
            this.Dbm_label9.Text = "dBm";
            this.Dbm_label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dbm_label9.Click += new System.EventHandler(this.Dbm_label9_Click);
            // 
            // PA_button
            // 
            this.PA_button.BackColor = System.Drawing.Color.Gainsboro;
            this.PA_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PA_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA_button.ForeColor = System.Drawing.Color.Black;
            this.PA_button.Location = new System.Drawing.Point(699, 32);
            this.PA_button.Name = "PA_button";
            this.PA_button.Size = new System.Drawing.Size(59, 26);
            this.PA_button.TabIndex = 202;
            this.PA_button.Text = "AMP";
            this.toolTip.SetToolTip(this.PA_button, "CLICK IF AN AMPLIFIER IS ATTACHED.");
            this.PA_button.UseVisualStyleBackColor = false;
            this.PA_button.Click += new System.EventHandler(this.PA_button_Click);
            // 
            // Dbm_Value_label9
            // 
            this.Dbm_Value_label9.BackColor = System.Drawing.Color.Transparent;
            this.Dbm_Value_label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbm_Value_label9.ForeColor = System.Drawing.Color.White;
            this.Dbm_Value_label9.Location = new System.Drawing.Point(83, 71);
            this.Dbm_Value_label9.Name = "Dbm_Value_label9";
            this.Dbm_Value_label9.Size = new System.Drawing.Size(58, 24);
            this.Dbm_Value_label9.TabIndex = 200;
            this.Dbm_Value_label9.Text = "-100";
            this.Dbm_Value_label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dbm_Value_label9.Click += new System.EventHandler(this.Dbm_Value_label9_Click);
            // 
            // Power_Value_label2
            // 
            this.Power_Value_label2.BackColor = System.Drawing.Color.Transparent;
            this.Power_Value_label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Power_Value_label2.ForeColor = System.Drawing.Color.White;
            this.Power_Value_label2.Location = new System.Drawing.Point(21, 71);
            this.Power_Value_label2.Name = "Power_Value_label2";
            this.Power_Value_label2.Size = new System.Drawing.Size(120, 24);
            this.Power_Value_label2.TabIndex = 172;
            this.Power_Value_label2.Text = "dBm -100";
            this.Power_Value_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Power_Value_label2.Click += new System.EventHandler(this.Power_Value_label2_Click);
            // 
            // CW_Filter_button8
            // 
            this.CW_Filter_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.CW_Filter_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CW_Filter_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CW_Filter_button8.ForeColor = System.Drawing.Color.Black;
            this.CW_Filter_button8.Location = new System.Drawing.Point(236, 93);
            this.CW_Filter_button8.Name = "CW_Filter_button8";
            this.CW_Filter_button8.Size = new System.Drawing.Size(88, 27);
            this.CW_Filter_button8.TabIndex = 197;
            this.CW_Filter_button8.Text = "200Hz";
            this.toolTip.SetToolTip(this.CW_Filter_button8, "SET CW BANDWIDTH");
            this.CW_Filter_button8.UseVisualStyleBackColor = false;
            this.CW_Filter_button8.Click += new System.EventHandler(this.CW_Filter_button8_Click);
            // 
            // Low_Cut_Filter_button8
            // 
            this.Low_Cut_Filter_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Low_Cut_Filter_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Low_Cut_Filter_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Low_Cut_Filter_button8.ForeColor = System.Drawing.Color.Black;
            this.Low_Cut_Filter_button8.Location = new System.Drawing.Point(334, 93);
            this.Low_Cut_Filter_button8.Name = "Low_Cut_Filter_button8";
            this.Low_Cut_Filter_button8.Size = new System.Drawing.Size(88, 27);
            this.Low_Cut_Filter_button8.TabIndex = 196;
            this.Low_Cut_Filter_button8.Text = "75Hz";
            this.toolTip.SetToolTip(this.Low_Cut_Filter_button8, "SET LOW CUT FILTER");
            this.Low_Cut_Filter_button8.UseVisualStyleBackColor = false;
            this.Low_Cut_Filter_button8.Click += new System.EventHandler(this.Low_Cut_Filter_button8_Click);
            // 
            // High_Cut_button8
            // 
            this.High_Cut_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.High_Cut_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.High_Cut_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.High_Cut_button8.ForeColor = System.Drawing.Color.Black;
            this.High_Cut_button8.Location = new System.Drawing.Point(432, 93);
            this.High_Cut_button8.Name = "High_Cut_button8";
            this.High_Cut_button8.Size = new System.Drawing.Size(88, 27);
            this.High_Cut_button8.TabIndex = 195;
            this.High_Cut_button8.Text = "3.0KHz";
            this.toolTip.SetToolTip(this.High_Cut_button8, "SET HIGH CUT FILTER");
            this.High_Cut_button8.UseVisualStyleBackColor = false;
            this.High_Cut_button8.Click += new System.EventHandler(this.High_Cut_button8_Click);
            // 
            // Step_button8
            // 
            this.Step_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Step_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Step_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step_button8.ForeColor = System.Drawing.Color.Black;
            this.Step_button8.Location = new System.Drawing.Point(530, 93);
            this.Step_button8.Name = "Step_button8";
            this.Step_button8.Size = new System.Drawing.Size(88, 27);
            this.Step_button8.TabIndex = 157;
            this.Step_button8.Text = "100KHz";
            this.toolTip.SetToolTip(this.Step_button8, "SET FREQUENCY STEP");
            this.Step_button8.UseVisualStyleBackColor = false;
            this.Step_button8.Click += new System.EventHandler(this.Step_button8_Click);
            // 
            // Microphone_textBox2
            // 
            this.Microphone_textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.Microphone_textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Microphone_textBox2.ForeColor = System.Drawing.Color.Black;
            this.Microphone_textBox2.Location = new System.Drawing.Point(553, 211);
            this.Microphone_textBox2.Name = "Microphone_textBox2";
            this.Microphone_textBox2.Size = new System.Drawing.Size(39, 21);
            this.Microphone_textBox2.TabIndex = 158;
            this.Microphone_textBox2.Text = "100";
            this.Microphone_textBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Microphone_textBox2.Click += new System.EventHandler(this.Microphone_textBox2_Click);
            this.Microphone_textBox2.MouseEnter += new System.EventHandler(this.Microphone_textBox2_mouseenter);
            this.Microphone_textBox2.MouseLeave += new System.EventHandler(this.Microphone_textBox2_mouseleave);
            // 
            // Volume_textBox2
            // 
            this.Volume_textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.Volume_textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume_textBox2.ForeColor = System.Drawing.Color.Black;
            this.Volume_textBox2.Location = new System.Drawing.Point(200, 211);
            this.Volume_textBox2.Name = "Volume_textBox2";
            this.Volume_textBox2.Size = new System.Drawing.Size(39, 21);
            this.Volume_textBox2.TabIndex = 157;
            this.Volume_textBox2.Text = "100";
            this.Volume_textBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Volume_textBox2.Click += new System.EventHandler(this.Volume_textBox2_Click);
            this.Volume_textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Volume_textBox2_Mouse_Click);
            this.Volume_textBox2.MouseEnter += new System.EventHandler(this.Volume_textBox2_Enter);
            this.Volume_textBox2.MouseLeave += new System.EventHandler(this.Volume_textBox2_Leave);
            // 
            // UTC_Date_label46
            // 
            this.UTC_Date_label46.BackColor = System.Drawing.Color.Transparent;
            this.UTC_Date_label46.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UTC_Date_label46.ForeColor = System.Drawing.Color.White;
            this.UTC_Date_label46.Location = new System.Drawing.Point(651, 258);
            this.UTC_Date_label46.Name = "UTC_Date_label46";
            this.UTC_Date_label46.Size = new System.Drawing.Size(110, 23);
            this.UTC_Date_label46.TabIndex = 143;
            this.UTC_Date_label46.Text = "12.12.20";
            this.UTC_Date_label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UTC_Date_label46.Visible = false;
            this.UTC_Date_label46.Click += new System.EventHandler(this.UTC_Date_label46_Click);
            // 
            // Time_display_UTC_label34
            // 
            this.Time_display_UTC_label34.BackColor = System.Drawing.Color.Transparent;
            this.Time_display_UTC_label34.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_display_UTC_label34.ForeColor = System.Drawing.Color.White;
            this.Time_display_UTC_label34.Location = new System.Drawing.Point(651, 236);
            this.Time_display_UTC_label34.Name = "Time_display_UTC_label34";
            this.Time_display_UTC_label34.Size = new System.Drawing.Size(110, 23);
            this.Time_display_UTC_label34.TabIndex = 114;
            this.Time_display_UTC_label34.Text = "00:00:00";
            this.Time_display_UTC_label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Time_display_UTC_label34.Visible = false;
            this.Time_display_UTC_label34.Click += new System.EventHandler(this.Time_display_UTC_label34_Click);
            // 
            // Minimize_checkBox2
            // 
            this.Minimize_checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_checkBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Minimize_checkBox2.Location = new System.Drawing.Point(763, 90);
            this.Minimize_checkBox2.Name = "Minimize_checkBox2";
            this.Minimize_checkBox2.Size = new System.Drawing.Size(20, 20);
            this.Minimize_checkBox2.TabIndex = 188;
            this.toolTip.SetToolTip(this.Minimize_checkBox2, "MINIMIZE MSCC");
            this.Minimize_checkBox2.UseVisualStyleBackColor = false;
            this.Minimize_checkBox2.CheckedChanged += new System.EventHandler(this.Minimize_checkBox2_CheckedChanged);
            // 
            // Audio_Digital_button3
            // 
            this.Audio_Digital_button3.BackColor = System.Drawing.Color.Gainsboro;
            this.Audio_Digital_button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Audio_Digital_button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Audio_Digital_button3.ForeColor = System.Drawing.Color.Black;
            this.Audio_Digital_button3.Location = new System.Drawing.Point(746, 173);
            this.Audio_Digital_button3.Name = "Audio_Digital_button3";
            this.Audio_Digital_button3.Size = new System.Drawing.Size(29, 29);
            this.Audio_Digital_button3.TabIndex = 185;
            this.Audio_Digital_button3.Text = "D";
            this.toolTip.SetToolTip(this.Audio_Digital_button3, "P- PHONES (Operator Audio)\r\nD- DIGITAL  (Audio for Digital Application)");
            this.Audio_Digital_button3.UseVisualStyleBackColor = false;
            this.Audio_Digital_button3.Click += new System.EventHandler(this.Audio_Digital_button3_Click);
            // 
            // Split_Button
            // 
            this.Split_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Split_Button.Enabled = false;
            this.Split_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Split_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Split_Button.ForeColor = System.Drawing.Color.Black;
            this.Split_Button.Location = new System.Drawing.Point(158, 32);
            this.Split_Button.Name = "Split_Button";
            this.Split_Button.Size = new System.Drawing.Size(59, 26);
            this.Split_Button.TabIndex = 184;
            this.Split_Button.Text = "SPL";
            this.toolTip.SetToolTip(this.Split_Button, "ACTIVATE SPLIT");
            this.Split_Button.UseVisualStyleBackColor = false;
            this.Split_Button.Click += new System.EventHandler(this.Split_Button_Click);
            // 
            // Spectrum_Controls_button3
            // 
            this.Spectrum_Controls_button3.BackColor = System.Drawing.Color.Gainsboro;
            this.Spectrum_Controls_button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Spectrum_Controls_button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spectrum_Controls_button3.ForeColor = System.Drawing.Color.Black;
            this.Spectrum_Controls_button3.Location = new System.Drawing.Point(699, 61);
            this.Spectrum_Controls_button3.Name = "Spectrum_Controls_button3";
            this.Spectrum_Controls_button3.Size = new System.Drawing.Size(59, 26);
            this.Spectrum_Controls_button3.TabIndex = 181;
            this.Spectrum_Controls_button3.Text = "S/W";
            this.toolTip.SetToolTip(this.Spectrum_Controls_button3, "DISPLAY SPECTRUM / WATERFALL CONTROLS");
            this.Spectrum_Controls_button3.UseVisualStyleBackColor = false;
            this.Spectrum_Controls_button3.Click += new System.EventHandler(this.Spectrum_Controls_button3_Click);
            // 
            // VFO_button
            // 
            this.VFO_button.BackColor = System.Drawing.Color.Gainsboro;
            this.VFO_button.Enabled = false;
            this.VFO_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VFO_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VFO_button.ForeColor = System.Drawing.Color.Black;
            this.VFO_button.Location = new System.Drawing.Point(158, 3);
            this.VFO_button.Name = "VFO_button";
            this.VFO_button.Size = new System.Drawing.Size(59, 26);
            this.VFO_button.TabIndex = 175;
            this.VFO_button.Text = "VFO";
            this.toolTip.SetToolTip(this.VFO_button, "LEFT CLICK - SELECT VFO\r\nRIGHT CLICK - VFOA = VFOB");
            this.VFO_button.UseVisualStyleBackColor = false;
            this.VFO_button.Click += new System.EventHandler(this.VFO_button_Click);
            this.VFO_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VFO_button_Click);
            // 
            // ACG_button
            // 
            this.ACG_button.BackColor = System.Drawing.Color.Gainsboro;
            this.ACG_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ACG_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACG_button.ForeColor = System.Drawing.Color.Black;
            this.ACG_button.Location = new System.Drawing.Point(636, 32);
            this.ACG_button.Name = "ACG_button";
            this.ACG_button.Size = new System.Drawing.Size(59, 26);
            this.ACG_button.TabIndex = 164;
            this.ACG_button.Text = "SLO";
            this.toolTip.SetToolTip(this.ACG_button, "AGC");
            this.ACG_button.UseVisualStyleBackColor = false;
            this.ACG_button.Click += new System.EventHandler(this.ACG_button_Click);
            // 
            // Compression_button4
            // 
            this.Compression_button4.BackColor = System.Drawing.Color.Gainsboro;
            this.Compression_button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Compression_button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compression_button4.ForeColor = System.Drawing.Color.Black;
            this.Compression_button4.Location = new System.Drawing.Point(636, 61);
            this.Compression_button4.Name = "Compression_button4";
            this.Compression_button4.Size = new System.Drawing.Size(59, 26);
            this.Compression_button4.TabIndex = 163;
            this.Compression_button4.Text = "CMP";
            this.toolTip.SetToolTip(this.Compression_button4, "AUDIO COMPRESSION\r\nON/OFF");
            this.Compression_button4.UseVisualStyleBackColor = false;
            this.Compression_button4.Click += new System.EventHandler(this.Compression_button4_Click);
            // 
            // Auto_Zero_checkBox2
            // 
            this.Auto_Zero_checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.Auto_Zero_checkBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Auto_Zero_checkBox2.Location = new System.Drawing.Point(763, 6);
            this.Auto_Zero_checkBox2.Name = "Auto_Zero_checkBox2";
            this.Auto_Zero_checkBox2.Size = new System.Drawing.Size(20, 20);
            this.Auto_Zero_checkBox2.TabIndex = 150;
            this.toolTip.SetToolTip(this.Auto_Zero_checkBox2, "AUTO ZERO");
            this.Auto_Zero_checkBox2.UseVisualStyleBackColor = false;
            this.Auto_Zero_checkBox2.CheckedChanged += new System.EventHandler(this.Auto_Zero_checkBox2_CheckedChanged);
            // 
            // Local_Date_label46
            // 
            this.Local_Date_label46.BackColor = System.Drawing.Color.Transparent;
            this.Local_Date_label46.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Local_Date_label46.ForeColor = System.Drawing.Color.White;
            this.Local_Date_label46.Location = new System.Drawing.Point(36, 258);
            this.Local_Date_label46.Name = "Local_Date_label46";
            this.Local_Date_label46.Size = new System.Drawing.Size(114, 23);
            this.Local_Date_label46.TabIndex = 142;
            this.Local_Date_label46.Text = "12.12.20";
            this.Local_Date_label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Local_Date_label46.Visible = false;
            this.Local_Date_label46.Click += new System.EventHandler(this.Local_Date_label46_Click);
            // 
            // NB_button2
            // 
            this.NB_button2.BackColor = System.Drawing.Color.Gainsboro;
            this.NB_button2.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.NB_button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.NB_button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.NB_button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NB_button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_button2.ForeColor = System.Drawing.Color.Black;
            this.NB_button2.Location = new System.Drawing.Point(19, 173);
            this.NB_button2.Name = "NB_button2";
            this.NB_button2.Size = new System.Drawing.Size(29, 29);
            this.NB_button2.TabIndex = 137;
            this.NB_button2.Text = "B";
            this.toolTip.SetToolTip(this.NB_button2, "NOISE BLANKER");
            this.NB_button2.UseVisualStyleBackColor = false;
            this.NB_button2.Click += new System.EventHandler(this.NB_button2_Click);
            // 
            // Time_display_label33
            // 
            this.Time_display_label33.BackColor = System.Drawing.Color.Transparent;
            this.Time_display_label33.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_display_label33.ForeColor = System.Drawing.Color.White;
            this.Time_display_label33.Location = new System.Drawing.Point(36, 236);
            this.Time_display_label33.Name = "Time_display_label33";
            this.Time_display_label33.Size = new System.Drawing.Size(114, 23);
            this.Time_display_label33.TabIndex = 113;
            this.Time_display_label33.Text = "00:00:00";
            this.Time_display_label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Time_display_label33.Visible = false;
            this.Time_display_label33.Click += new System.EventHandler(this.Time_display_label33_Click);
            // 
            // TX_Mute_button2
            // 
            this.TX_Mute_button2.BackColor = System.Drawing.Color.Gainsboro;
            this.TX_Mute_button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TX_Mute_button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Mute_button2.ForeColor = System.Drawing.Color.Black;
            this.TX_Mute_button2.Location = new System.Drawing.Point(635, 173);
            this.TX_Mute_button2.Name = "TX_Mute_button2";
            this.TX_Mute_button2.Size = new System.Drawing.Size(105, 29);
            this.TX_Mute_button2.TabIndex = 106;
            this.TX_Mute_button2.Text = "MIC GAIN";
            this.TX_Mute_button2.UseVisualStyleBackColor = false;
            this.TX_Mute_button2.Click += new System.EventHandler(this.TX_Mute_button2_Click);
            // 
            // Volume_Mute_button2
            // 
            this.Volume_Mute_button2.BackColor = System.Drawing.Color.Gainsboro;
            this.Volume_Mute_button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Volume_Mute_button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume_Mute_button2.ForeColor = System.Drawing.Color.Black;
            this.Volume_Mute_button2.Location = new System.Drawing.Point(54, 173);
            this.Volume_Mute_button2.Name = "Volume_Mute_button2";
            this.Volume_Mute_button2.Size = new System.Drawing.Size(100, 29);
            this.Volume_Mute_button2.TabIndex = 105;
            this.Volume_Mute_button2.Text = "VOLUME";
            this.Volume_Mute_button2.UseVisualStyleBackColor = false;
            this.Volume_Mute_button2.Click += new System.EventHandler(this.Volume_Mute_button2_Click);
            // 
            // MicVolume_hScrollBar1
            // 
            this.MicVolume_hScrollBar1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.MicVolume_hScrollBar1.Location = new System.Drawing.Point(595, 211);
            this.MicVolume_hScrollBar1.Maximum = 109;
            this.MicVolume_hScrollBar1.Name = "MicVolume_hScrollBar1";
            this.MicVolume_hScrollBar1.Size = new System.Drawing.Size(185, 21);
            this.MicVolume_hScrollBar1.TabIndex = 102;
            this.MicVolume_hScrollBar1.TabStop = true;
            this.MicVolume_hScrollBar1.Value = 30;
            this.MicVolume_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MicVolume_hScrollBar1_Scroll);
            this.MicVolume_hScrollBar1.MouseEnter += new System.EventHandler(this.Mic_Gain_ScroolBar_mouseenter);
            this.MicVolume_hScrollBar1.MouseLeave += new System.EventHandler(this.Mic_Gain_ScroolBar_mouseleave);
            // 
            // Volume_hScrollBar1
            // 
            this.Volume_hScrollBar1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.Volume_hScrollBar1.Location = new System.Drawing.Point(12, 211);
            this.Volume_hScrollBar1.Maximum = 108;
            this.Volume_hScrollBar1.Name = "Volume_hScrollBar1";
            this.Volume_hScrollBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Volume_hScrollBar1.Size = new System.Drawing.Size(185, 21);
            this.Volume_hScrollBar1.TabIndex = 101;
            this.Volume_hScrollBar1.TabStop = true;
            this.Volume_hScrollBar1.Value = 30;
            this.Volume_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Volume_hScrollBar1_Scroll);
            this.Volume_hScrollBar1.MouseEnter += new System.EventHandler(this.Volume_ScroolBar_mouseenter);
            this.Volume_hScrollBar1.MouseLeave += new System.EventHandler(this.Volume_ScroolBar_mouseleave);
            // 
            // Freqbutton3
            // 
            this.Freqbutton3.BackColor = System.Drawing.Color.Gainsboro;
            this.Freqbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Freqbutton3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freqbutton3.ForeColor = System.Drawing.Color.Black;
            this.Freqbutton3.Location = new System.Drawing.Point(160, 173);
            this.Freqbutton3.Name = "Freqbutton3";
            this.Freqbutton3.Size = new System.Drawing.Size(29, 29);
            this.Freqbutton3.TabIndex = 66;
            this.Freqbutton3.Text = "A";
            this.toolTip.SetToolTip(this.Freqbutton3, "AUTO NOTCH");
            this.Freqbutton3.UseVisualStyleBackColor = false;
            this.Freqbutton3.Click += new System.EventHandler(this.Freqbutton3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(636, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 26);
            this.button1.TabIndex = 64;
            this.button1.Text = "PTT";
            this.toolTip.SetToolTip(this.button1, "SET TX ON");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mainmodebutton2
            // 
            this.mainmodebutton2.BackColor = System.Drawing.Color.Gainsboro;
            this.mainmodebutton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainmodebutton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmodebutton2.ForeColor = System.Drawing.Color.Black;
            this.mainmodebutton2.Location = new System.Drawing.Point(158, 90);
            this.mainmodebutton2.Name = "mainmodebutton2";
            this.mainmodebutton2.Size = new System.Drawing.Size(59, 26);
            this.mainmodebutton2.TabIndex = 53;
            this.mainmodebutton2.Text = "USB";
            this.toolTip.SetToolTip(this.mainmodebutton2, "SET OPERATING MODE");
            this.mainmodebutton2.UseVisualStyleBackColor = false;
            this.mainmodebutton2.Click += new System.EventHandler(this.mainmodebutton2_Click);
            // 
            // buttTune
            // 
            this.buttTune.BackColor = System.Drawing.Color.Gainsboro;
            this.buttTune.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttTune.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttTune.ForeColor = System.Drawing.Color.Black;
            this.buttTune.Location = new System.Drawing.Point(699, 3);
            this.buttTune.Name = "buttTune";
            this.buttTune.Size = new System.Drawing.Size(59, 26);
            this.buttTune.TabIndex = 4;
            this.buttTune.Text = "TUN";
            this.toolTip.SetToolTip(this.buttTune, "SET TUNE ON / OFF");
            this.buttTune.UseVisualStyleBackColor = false;
            this.buttTune.Click += new System.EventHandler(this.buttTune_Click);
            // 
            // Band_Change_Auto_Tune_checkBox2
            // 
            this.Band_Change_Auto_Tune_checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.Band_Change_Auto_Tune_checkBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Band_Change_Auto_Tune_checkBox2.Location = new System.Drawing.Point(763, 48);
            this.Band_Change_Auto_Tune_checkBox2.Name = "Band_Change_Auto_Tune_checkBox2";
            this.Band_Change_Auto_Tune_checkBox2.Size = new System.Drawing.Size(20, 20);
            this.Band_Change_Auto_Tune_checkBox2.TabIndex = 151;
            this.toolTip.SetToolTip(this.Band_Change_Auto_Tune_checkBox2, "AUTO TUN ON BAND CHANGE");
            this.Band_Change_Auto_Tune_checkBox2.UseVisualStyleBackColor = false;
            this.Band_Change_Auto_Tune_checkBox2.CheckedChanged += new System.EventHandler(this.Band_Change_Auto_Tune_checkBox2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Message_button);
            this.groupBox3.Controls.Add(this.VFOB_Active_button);
            this.groupBox3.Controls.Add(this.VFOB_TX_Indicator_button);
            this.groupBox3.Controls.Add(this.Out_Of_Band_button);
            this.groupBox3.Controls.Add(this.Main_Freq_KB_button);
            this.groupBox3.Controls.Add(this.Freq_Up_button);
            this.groupBox3.Controls.Add(this.Freq_Down_button);
            this.groupBox3.Controls.Add(this.Freq_Pointer_7);
            this.groupBox3.Controls.Add(this.Freq_Pointer_6);
            this.groupBox3.Controls.Add(this.Freq_Pointer_5);
            this.groupBox3.Controls.Add(this.Freq_Pointer_4);
            this.groupBox3.Controls.Add(this.Freq_Pointer_3);
            this.groupBox3.Controls.Add(this.Freq_Pointer_2);
            this.groupBox3.Controls.Add(this.Freq_Pointer_1);
            this.groupBox3.Controls.Add(this.Freq_Pointer_0);
            this.groupBox3.Controls.Add(this.Tenmillions);
            this.groupBox3.Controls.Add(this.Tenthousands);
            this.groupBox3.Controls.Add(this.Decimal_label58);
            this.groupBox3.Controls.Add(this.Decimal_label59);
            this.groupBox3.Controls.Add(this.Hundredthousand);
            this.groupBox3.Controls.Add(this.Millions);
            this.groupBox3.Controls.Add(this.Hundreds);
            this.groupBox3.Controls.Add(this.Thousands);
            this.groupBox3.Controls.Add(this.Ones);
            this.groupBox3.Controls.Add(this.Tens);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(222, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 89);
            this.groupBox3.TabIndex = 161;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VFO A";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Message_button
            // 
            this.Message_button.BackColor = System.Drawing.Color.Red;
            this.Message_button.Enabled = false;
            this.Message_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Message_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_button.ForeColor = System.Drawing.Color.Black;
            this.Message_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Message_button.Location = new System.Drawing.Point(6, 46);
            this.Message_button.Name = "Message_button";
            this.Message_button.Size = new System.Drawing.Size(11, 11);
            this.Message_button.TabIndex = 219;
            this.toolTip.SetToolTip(this.Message_button, "SYSTEM MESSAGE AVAILABLE");
            this.Message_button.UseVisualStyleBackColor = false;
            this.Message_button.Visible = false;
            this.Message_button.Click += new System.EventHandler(this.Message_button_Click);
            // 
            // VFOB_Active_button
            // 
            this.VFOB_Active_button.BackColor = System.Drawing.Color.Red;
            this.VFOB_Active_button.Enabled = false;
            this.VFOB_Active_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VFOB_Active_button.Font = new System.Drawing.Font("Verdana", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VFOB_Active_button.ForeColor = System.Drawing.Color.Black;
            this.VFOB_Active_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VFOB_Active_button.Location = new System.Drawing.Point(6, 20);
            this.VFOB_Active_button.Name = "VFOB_Active_button";
            this.VFOB_Active_button.Size = new System.Drawing.Size(11, 11);
            this.VFOB_Active_button.TabIndex = 220;
            this.toolTip.SetToolTip(this.VFOB_Active_button, "VFO B");
            this.VFOB_Active_button.UseVisualStyleBackColor = false;
            this.VFOB_Active_button.Visible = false;
            this.VFOB_Active_button.Click += new System.EventHandler(this.VFOB_Active_button_Click);
            // 
            // VFOB_TX_Indicator_button
            // 
            this.VFOB_TX_Indicator_button.BackColor = System.Drawing.Color.Red;
            this.VFOB_TX_Indicator_button.Enabled = false;
            this.VFOB_TX_Indicator_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VFOB_TX_Indicator_button.Font = new System.Drawing.Font("Verdana", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VFOB_TX_Indicator_button.ForeColor = System.Drawing.Color.Black;
            this.VFOB_TX_Indicator_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VFOB_TX_Indicator_button.Location = new System.Drawing.Point(6, 72);
            this.VFOB_TX_Indicator_button.Name = "VFOB_TX_Indicator_button";
            this.VFOB_TX_Indicator_button.Size = new System.Drawing.Size(11, 11);
            this.VFOB_TX_Indicator_button.TabIndex = 219;
            this.toolTip.SetToolTip(this.VFOB_TX_Indicator_button, "TRANSMITTING ON VFO B");
            this.VFOB_TX_Indicator_button.UseVisualStyleBackColor = false;
            this.VFOB_TX_Indicator_button.Visible = false;
            this.VFOB_TX_Indicator_button.Click += new System.EventHandler(this.VFOB_TX_Indicator_button_Click);
            // 
            // Out_Of_Band_button
            // 
            this.Out_Of_Band_button.BackColor = System.Drawing.Color.Red;
            this.Out_Of_Band_button.Enabled = false;
            this.Out_Of_Band_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Out_Of_Band_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out_Of_Band_button.ForeColor = System.Drawing.Color.Black;
            this.Out_Of_Band_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Out_Of_Band_button.Location = new System.Drawing.Point(197, 72);
            this.Out_Of_Band_button.Name = "Out_Of_Band_button";
            this.Out_Of_Band_button.Size = new System.Drawing.Size(11, 11);
            this.Out_Of_Band_button.TabIndex = 217;
            this.toolTip.SetToolTip(this.Out_Of_Band_button, "OUT OF BAND");
            this.Out_Of_Band_button.UseVisualStyleBackColor = false;
            this.Out_Of_Band_button.Visible = false;
            this.Out_Of_Band_button.Click += new System.EventHandler(this.Out_Of_Band_button_Click);
            // 
            // Main_Freq_KB_button
            // 
            this.Main_Freq_KB_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Main_Freq_KB_button.Enabled = false;
            this.Main_Freq_KB_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_Freq_KB_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Freq_KB_button.ForeColor = System.Drawing.Color.Black;
            this.Main_Freq_KB_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Main_Freq_KB_button.Location = new System.Drawing.Point(390, 42);
            this.Main_Freq_KB_button.Name = "Main_Freq_KB_button";
            this.Main_Freq_KB_button.Size = new System.Drawing.Size(15, 15);
            this.Main_Freq_KB_button.TabIndex = 211;
            this.Main_Freq_KB_button.UseVisualStyleBackColor = false;
            this.Main_Freq_KB_button.Visible = false;
            this.Main_Freq_KB_button.Click += new System.EventHandler(this.Main_Freq_KB_button_Click);
            // 
            // Freq_Up_button
            // 
            this.Freq_Up_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Up_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Freq_Up_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Up_button.ForeColor = System.Drawing.Color.Black;
            this.Freq_Up_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Freq_Up_button.Location = new System.Drawing.Point(390, 16);
            this.Freq_Up_button.Name = "Freq_Up_button";
            this.Freq_Up_button.Size = new System.Drawing.Size(15, 15);
            this.Freq_Up_button.TabIndex = 210;
            this.toolTip.SetToolTip(this.Freq_Up_button, "CLICK TO INCREASE FREQUENCY");
            this.Freq_Up_button.UseVisualStyleBackColor = false;
            this.Freq_Up_button.Click += new System.EventHandler(this.Freq_Up_button_Click);
            this.Freq_Up_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Freq_Up_button_Mouse_Down);
            this.Freq_Up_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Freq_Up_button_Mouse_Up);
            // 
            // Freq_Down_button
            // 
            this.Freq_Down_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Freq_Down_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Down_button.ForeColor = System.Drawing.Color.Black;
            this.Freq_Down_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Freq_Down_button.Location = new System.Drawing.Point(390, 68);
            this.Freq_Down_button.Name = "Freq_Down_button";
            this.Freq_Down_button.Size = new System.Drawing.Size(15, 15);
            this.Freq_Down_button.TabIndex = 210;
            this.toolTip.SetToolTip(this.Freq_Down_button, "CLICK TO DECREASE FREQUENCY");
            this.Freq_Down_button.UseVisualStyleBackColor = false;
            this.Freq_Down_button.Click += new System.EventHandler(this.Freq_Down_button_Click);
            this.Freq_Down_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Freq_Down_button_Mouse_Down);
            this.Freq_Down_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Freq_Down_button_Mouse_Up);
            // 
            // Freq_Pointer_7
            // 
            this.Freq_Pointer_7.AutoSize = true;
            this.Freq_Pointer_7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Pointer_7.Location = new System.Drawing.Point(28, 71);
            this.Freq_Pointer_7.Name = "Freq_Pointer_7";
            this.Freq_Pointer_7.Size = new System.Drawing.Size(17, 13);
            this.Freq_Pointer_7.TabIndex = 168;
            this.Freq_Pointer_7.Text = "^";
            this.Freq_Pointer_7.Click += new System.EventHandler(this.Freq_Pointer_7_Click);
            // 
            // Freq_Pointer_6
            // 
            this.Freq_Pointer_6.AutoSize = true;
            this.Freq_Pointer_6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Pointer_6.Location = new System.Drawing.Point(67, 71);
            this.Freq_Pointer_6.Name = "Freq_Pointer_6";
            this.Freq_Pointer_6.Size = new System.Drawing.Size(17, 13);
            this.Freq_Pointer_6.TabIndex = 167;
            this.Freq_Pointer_6.Text = "^";
            this.Freq_Pointer_6.Click += new System.EventHandler(this.Freq_Pointer_6_Click);
            // 
            // Freq_Pointer_5
            // 
            this.Freq_Pointer_5.AutoSize = true;
            this.Freq_Pointer_5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Pointer_5.Location = new System.Drawing.Point(122, 71);
            this.Freq_Pointer_5.Name = "Freq_Pointer_5";
            this.Freq_Pointer_5.Size = new System.Drawing.Size(17, 13);
            this.Freq_Pointer_5.TabIndex = 166;
            this.Freq_Pointer_5.Text = "^";
            this.Freq_Pointer_5.Click += new System.EventHandler(this.Freq_Pointer_5_Click);
            // 
            // Freq_Pointer_4
            // 
            this.Freq_Pointer_4.AutoSize = true;
            this.Freq_Pointer_4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Pointer_4.Location = new System.Drawing.Point(166, 71);
            this.Freq_Pointer_4.Name = "Freq_Pointer_4";
            this.Freq_Pointer_4.Size = new System.Drawing.Size(17, 13);
            this.Freq_Pointer_4.TabIndex = 165;
            this.Freq_Pointer_4.Text = "^";
            this.Freq_Pointer_4.Click += new System.EventHandler(this.Freq_Pointer_4_Click);
            // 
            // Freq_Pointer_3
            // 
            this.Freq_Pointer_3.AutoSize = true;
            this.Freq_Pointer_3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Pointer_3.Location = new System.Drawing.Point(217, 71);
            this.Freq_Pointer_3.Name = "Freq_Pointer_3";
            this.Freq_Pointer_3.Size = new System.Drawing.Size(17, 13);
            this.Freq_Pointer_3.TabIndex = 164;
            this.Freq_Pointer_3.Text = "^";
            this.Freq_Pointer_3.Click += new System.EventHandler(this.Freq_Pointer_3_Click);
            // 
            // Freq_Pointer_2
            // 
            this.Freq_Pointer_2.AutoSize = true;
            this.Freq_Pointer_2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Pointer_2.Location = new System.Drawing.Point(274, 71);
            this.Freq_Pointer_2.Name = "Freq_Pointer_2";
            this.Freq_Pointer_2.Size = new System.Drawing.Size(17, 13);
            this.Freq_Pointer_2.TabIndex = 163;
            this.Freq_Pointer_2.Text = "^";
            this.Freq_Pointer_2.Click += new System.EventHandler(this.Freq_Pointer_2_Click);
            // 
            // Freq_Pointer_1
            // 
            this.Freq_Pointer_1.AutoSize = true;
            this.Freq_Pointer_1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Pointer_1.Location = new System.Drawing.Point(320, 71);
            this.Freq_Pointer_1.Name = "Freq_Pointer_1";
            this.Freq_Pointer_1.Size = new System.Drawing.Size(17, 13);
            this.Freq_Pointer_1.TabIndex = 162;
            this.Freq_Pointer_1.Text = "^";
            this.Freq_Pointer_1.Click += new System.EventHandler(this.Freq_Pointer_1_Click);
            // 
            // Freq_Pointer_0
            // 
            this.Freq_Pointer_0.AutoSize = true;
            this.Freq_Pointer_0.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Pointer_0.Location = new System.Drawing.Point(355, 71);
            this.Freq_Pointer_0.Name = "Freq_Pointer_0";
            this.Freq_Pointer_0.Size = new System.Drawing.Size(17, 13);
            this.Freq_Pointer_0.TabIndex = 161;
            this.Freq_Pointer_0.Text = "^";
            this.Freq_Pointer_0.Click += new System.EventHandler(this.Freq_Pointer_0_Click);
            // 
            // Tenmillions
            // 
            this.Tenmillions.AutoSize = true;
            this.Tenmillions.BackColor = System.Drawing.Color.Transparent;
            this.Tenmillions.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenmillions.ForeColor = System.Drawing.Color.White;
            this.Tenmillions.Location = new System.Drawing.Point(23, 26);
            this.Tenmillions.Name = "Tenmillions";
            this.Tenmillions.Size = new System.Drawing.Size(37, 39);
            this.Tenmillions.TabIndex = 95;
            this.Tenmillions.Text = "L";
            this.Tenmillions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tenmillions.Click += new System.EventHandler(this.Tenmillions_Click);
            this.Tenmillions.MouseEnter += new System.EventHandler(this.Tenmillions_MouseEnter);
            this.Tenmillions.MouseLeave += new System.EventHandler(this.Tenmillions_MouseExit);
            // 
            // Tenthousands
            // 
            this.Tenthousands.AutoSize = true;
            this.Tenthousands.BackColor = System.Drawing.Color.Transparent;
            this.Tenthousands.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenthousands.ForeColor = System.Drawing.Color.White;
            this.Tenthousands.Location = new System.Drawing.Point(155, 20);
            this.Tenthousands.Name = "Tenthousands";
            this.Tenthousands.Size = new System.Drawing.Size(52, 55);
            this.Tenthousands.TabIndex = 92;
            this.Tenthousands.Text = "0";
            this.Tenthousands.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tenthousands.Click += new System.EventHandler(this.Tenthousands_Click);
            this.Tenthousands.MouseEnter += new System.EventHandler(this.Tenthousands_MouseEnter);
            this.Tenthousands.MouseLeave += new System.EventHandler(this.Tenthousands_MouseExit);
            // 
            // Decimal_label58
            // 
            this.Decimal_label58.AutoSize = true;
            this.Decimal_label58.BackColor = System.Drawing.Color.Transparent;
            this.Decimal_label58.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal_label58.ForeColor = System.Drawing.Color.White;
            this.Decimal_label58.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Decimal_label58.Location = new System.Drawing.Point(249, 43);
            this.Decimal_label58.Name = "Decimal_label58";
            this.Decimal_label58.Size = new System.Drawing.Size(15, 24);
            this.Decimal_label58.TabIndex = 159;
            this.Decimal_label58.Text = ".";
            this.Decimal_label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Decimal_label59
            // 
            this.Decimal_label59.AutoSize = true;
            this.Decimal_label59.BackColor = System.Drawing.Color.Transparent;
            this.Decimal_label59.Enabled = false;
            this.Decimal_label59.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal_label59.ForeColor = System.Drawing.Color.White;
            this.Decimal_label59.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Decimal_label59.Location = new System.Drawing.Point(95, 43);
            this.Decimal_label59.Name = "Decimal_label59";
            this.Decimal_label59.Size = new System.Drawing.Size(15, 24);
            this.Decimal_label59.TabIndex = 160;
            this.Decimal_label59.Text = ".";
            this.Decimal_label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Decimal_label59.Visible = false;
            // 
            // Hundredthousand
            // 
            this.Hundredthousand.AutoSize = true;
            this.Hundredthousand.BackColor = System.Drawing.Color.Transparent;
            this.Hundredthousand.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hundredthousand.ForeColor = System.Drawing.Color.White;
            this.Hundredthousand.Location = new System.Drawing.Point(110, 20);
            this.Hundredthousand.Name = "Hundredthousand";
            this.Hundredthousand.Size = new System.Drawing.Size(52, 55);
            this.Hundredthousand.TabIndex = 93;
            this.Hundredthousand.Text = "0";
            this.Hundredthousand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hundredthousand.Click += new System.EventHandler(this.Hundredthousand_Click);
            this.Hundredthousand.MouseEnter += new System.EventHandler(this.Hundredthousand_MouseEnter);
            this.Hundredthousand.MouseLeave += new System.EventHandler(this.Hundredthousand_MouseExit);
            // 
            // Millions
            // 
            this.Millions.AutoSize = true;
            this.Millions.BackColor = System.Drawing.Color.Transparent;
            this.Millions.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Millions.ForeColor = System.Drawing.Color.White;
            this.Millions.Location = new System.Drawing.Point(62, 26);
            this.Millions.Name = "Millions";
            this.Millions.Size = new System.Drawing.Size(39, 39);
            this.Millions.TabIndex = 94;
            this.Millions.Text = "F";
            this.Millions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Millions.Click += new System.EventHandler(this.Millions_Click);
            this.Millions.MouseEnter += new System.EventHandler(this.Millions_MouseEnter);
            this.Millions.MouseLeave += new System.EventHandler(this.Millions_MouseExit);
            // 
            // Hundreds
            // 
            this.Hundreds.AutoSize = true;
            this.Hundreds.BackColor = System.Drawing.Color.Transparent;
            this.Hundreds.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hundreds.ForeColor = System.Drawing.Color.White;
            this.Hundreds.Location = new System.Drawing.Point(265, 20);
            this.Hundreds.Name = "Hundreds";
            this.Hundreds.Size = new System.Drawing.Size(52, 55);
            this.Hundreds.TabIndex = 90;
            this.Hundreds.Text = "0";
            this.Hundreds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hundreds.Click += new System.EventHandler(this.Hundreds_Click);
            this.Hundreds.MouseEnter += new System.EventHandler(this.Hundreds_MouseEnter);
            this.Hundreds.MouseLeave += new System.EventHandler(this.Hundreds_MouseExit);
            // 
            // Thousands
            // 
            this.Thousands.AutoSize = true;
            this.Thousands.BackColor = System.Drawing.Color.Transparent;
            this.Thousands.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thousands.ForeColor = System.Drawing.Color.White;
            this.Thousands.Location = new System.Drawing.Point(201, 20);
            this.Thousands.Name = "Thousands";
            this.Thousands.Size = new System.Drawing.Size(52, 55);
            this.Thousands.TabIndex = 91;
            this.Thousands.Text = "0";
            this.Thousands.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Thousands.Click += new System.EventHandler(this.Thousands_Click);
            this.Thousands.MouseEnter += new System.EventHandler(this.Thousands_MouseEnter);
            this.Thousands.MouseLeave += new System.EventHandler(this.Thousands_MouseExit);
            // 
            // Ones
            // 
            this.Ones.AutoSize = true;
            this.Ones.BackColor = System.Drawing.Color.Transparent;
            this.Ones.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ones.ForeColor = System.Drawing.Color.White;
            this.Ones.Location = new System.Drawing.Point(348, 20);
            this.Ones.Name = "Ones";
            this.Ones.Size = new System.Drawing.Size(52, 55);
            this.Ones.TabIndex = 88;
            this.Ones.Text = "0";
            this.Ones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ones.Click += new System.EventHandler(this.Ones_Click);
            this.Ones.MouseEnter += new System.EventHandler(this.Ones_MouseEnter);
            this.Ones.MouseLeave += new System.EventHandler(this.Ones_MouseExit);
            // 
            // Tens
            // 
            this.Tens.AutoSize = true;
            this.Tens.BackColor = System.Drawing.Color.Transparent;
            this.Tens.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tens.ForeColor = System.Drawing.Color.White;
            this.Tens.Location = new System.Drawing.Point(305, 20);
            this.Tens.Name = "Tens";
            this.Tens.Size = new System.Drawing.Size(52, 55);
            this.Tens.TabIndex = 89;
            this.Tens.Text = "0";
            this.Tens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tens.Click += new System.EventHandler(this.Tens_Click);
            this.Tens.MouseEnter += new System.EventHandler(this.Tens_MouseEnter);
            this.Tens.MouseLeave += new System.EventHandler(this.Tens_MouseExit);
            // 
            // Main_Power_hScrollBar1
            // 
            this.Main_Power_hScrollBar1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.Main_Power_hScrollBar1.Location = new System.Drawing.Point(301, 240);
            this.Main_Power_hScrollBar1.Name = "Main_Power_hScrollBar1";
            this.Main_Power_hScrollBar1.Size = new System.Drawing.Size(185, 15);
            this.Main_Power_hScrollBar1.TabIndex = 187;
            this.Main_Power_hScrollBar1.TabStop = true;
            this.toolTip.SetToolTip(this.Main_Power_hScrollBar1, "SET POWER OUTPUT \r\nFOR\r\nCURRENT MODE");
            this.Main_Power_hScrollBar1.Value = 100;
            this.Main_Power_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Main_Power_hScrollBar1_Scroll);
            this.Main_Power_hScrollBar1.MouseEnter += new System.EventHandler(this.Main_Power_hScrollBar1_Enter);
            this.Main_Power_hScrollBar1.MouseLeave += new System.EventHandler(this.Main_Power_hScrollBar1_Leave);
            // 
            // Monitor_button8
            // 
            this.Monitor_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Monitor_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Monitor_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor_button8.ForeColor = System.Drawing.Color.Black;
            this.Monitor_button8.Location = new System.Drawing.Point(600, 173);
            this.Monitor_button8.Name = "Monitor_button8";
            this.Monitor_button8.Size = new System.Drawing.Size(29, 29);
            this.Monitor_button8.TabIndex = 201;
            this.Monitor_button8.Text = "M";
            this.Monitor_button8.UseVisualStyleBackColor = false;
            this.Monitor_button8.Click += new System.EventHandler(this.Monitor_button8_Click);
            // 
            // Smeter_Display_Value_label
            // 
            this.Smeter_Display_Value_label.BackColor = System.Drawing.Color.Transparent;
            this.Smeter_Display_Value_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smeter_Display_Value_label.ForeColor = System.Drawing.Color.White;
            this.Smeter_Display_Value_label.Location = new System.Drawing.Point(39, 71);
            this.Smeter_Display_Value_label.Name = "Smeter_Display_Value_label";
            this.Smeter_Display_Value_label.Size = new System.Drawing.Size(91, 22);
            this.Smeter_Display_Value_label.TabIndex = 216;
            this.Smeter_Display_Value_label.Text = "S9+60";
            this.Smeter_Display_Value_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Smeter_Display_Value_label.Visible = false;
            this.Smeter_Display_Value_label.Click += new System.EventHandler(this.Smeter_Display_Value_label_Click);
            // 
            // vuMeter1
            // 
            this.vuMeter1.AnalogMeter = true;
            this.vuMeter1.BackColor = System.Drawing.Color.Transparent;
            this.vuMeter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vuMeter1.DialBackground = System.Drawing.Color.Moccasin;
            this.vuMeter1.DialTextNegative = System.Drawing.Color.Red;
            this.vuMeter1.DialTextPositive = System.Drawing.Color.Black;
            this.vuMeter1.DialTextZero = System.Drawing.Color.DarkGreen;
            this.vuMeter1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vuMeter1.Led1ColorOff = System.Drawing.Color.Black;
            this.vuMeter1.Led1ColorOn = System.Drawing.Color.LimeGreen;
            this.vuMeter1.Led1Count = 9;
            this.vuMeter1.Led2ColorOff = System.Drawing.Color.Black;
            this.vuMeter1.Led2ColorOn = System.Drawing.Color.Yellow;
            this.vuMeter1.Led2Count = 0;
            this.vuMeter1.Led3ColorOff = System.Drawing.Color.Black;
            this.vuMeter1.Led3ColorOn = System.Drawing.Color.Red;
            this.vuMeter1.Led3Count = 5;
            this.vuMeter1.LedSize = new System.Drawing.Size(3, 14);
            this.vuMeter1.LedSpace = 0;
            this.vuMeter1.Level = 0;
            this.vuMeter1.LevelMax = 150;
            this.vuMeter1.Location = new System.Drawing.Point(3, 2);
            this.vuMeter1.MeterScale = VU_MeterLibrary.MeterScale.Analog;
            this.vuMeter1.Name = "vuMeter1";
            this.vuMeter1.NeedleColor = System.Drawing.Color.Black;
            this.vuMeter1.PeakHold = false;
            this.vuMeter1.Peakms = 1000;
            this.vuMeter1.PeakNeedleColor = System.Drawing.Color.White;
            this.vuMeter1.ShowDialOnly = false;
            this.vuMeter1.ShowLedPeak = false;
            this.vuMeter1.ShowTextInDial = true;
            this.vuMeter1.Size = new System.Drawing.Size(157, 125);
            this.vuMeter1.TabIndex = 168;
            this.vuMeter1.TextInDial = new string[] {
        "[S]",
        "1",
        "3",
        "5",
        "7",
        "9",
        "+20",
        "+40",
        "+60"};
            this.toolTip.SetToolTip(this.vuMeter1, resources.GetString("vuMeter1.ToolTip"));
            this.vuMeter1.UseLedLight = true;
            this.vuMeter1.VerticalBar = false;
            this.vuMeter1.VuText = "S Meter";
            this.vuMeter1.Load += new System.EventHandler(this.vuMeter1_Load);
            // 
            // Band_Set_2
            // 
            this.Band_Set_2.BackColor = System.Drawing.Color.Transparent;
            this.Band_Set_2.Controls.Add(this.Russian_Radio_Button);
            this.Band_Set_2.Controls.Add(this.WWV1_Radio_Button);
            this.Band_Set_2.Controls.Add(this.WWV2_Radio_Button);
            this.Band_Set_2.Controls.Add(this.WWV3_Radio_Button);
            this.Band_Set_2.Controls.Add(this.WWV4_Radio_Button);
            this.Band_Set_2.Controls.Add(this.CHU2_Radio_Button);
            this.Band_Set_2.Controls.Add(this.Spare_Radio_Button);
            this.Band_Set_2.Controls.Add(this.CHU1_Radio_Button);
            this.Band_Set_2.Enabled = false;
            this.Band_Set_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Band_Set_2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Band_Set_2.ForeColor = System.Drawing.Color.White;
            this.Band_Set_2.Location = new System.Drawing.Point(8, 124);
            this.Band_Set_2.Name = "Band_Set_2";
            this.Band_Set_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Band_Set_2.Size = new System.Drawing.Size(777, 40);
            this.Band_Set_2.TabIndex = 207;
            this.Band_Set_2.TabStop = false;
            this.Band_Set_2.Text = "BAND SELECTION";
            this.Band_Set_2.Visible = false;
            // 
            // Russian_Radio_Button
            // 
            this.Russian_Radio_Button.AutoSize = true;
            this.Russian_Radio_Button.BackColor = System.Drawing.Color.Transparent;
            this.Russian_Radio_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Russian_Radio_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Russian_Radio_Button.ForeColor = System.Drawing.Color.White;
            this.Russian_Radio_Button.Location = new System.Drawing.Point(594, 12);
            this.Russian_Radio_Button.Name = "Russian_Radio_Button";
            this.Russian_Radio_Button.Size = new System.Drawing.Size(76, 27);
            this.Russian_Radio_Button.TabIndex = 49;
            this.Russian_Radio_Button.Text = "RWM";
            this.Russian_Radio_Button.UseVisualStyleBackColor = false;
            this.Russian_Radio_Button.CheckedChanged += new System.EventHandler(this.Russian_Radio_Button_CheckedChanged);
            // 
            // WWV1_Radio_Button
            // 
            this.WWV1_Radio_Button.AutoSize = true;
            this.WWV1_Radio_Button.BackColor = System.Drawing.Color.Transparent;
            this.WWV1_Radio_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WWV1_Radio_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WWV1_Radio_Button.ForeColor = System.Drawing.Color.White;
            this.WWV1_Radio_Button.Location = new System.Drawing.Point(32, 12);
            this.WWV1_Radio_Button.Name = "WWV1_Radio_Button";
            this.WWV1_Radio_Button.Size = new System.Drawing.Size(91, 27);
            this.WWV1_Radio_Button.TabIndex = 43;
            this.WWV1_Radio_Button.Text = "WWV1";
            this.toolTip.SetToolTip(this.WWV1_Radio_Button, "WWV - 5Mhz");
            this.WWV1_Radio_Button.UseVisualStyleBackColor = false;
            this.WWV1_Radio_Button.CheckedChanged += new System.EventHandler(this.WWV1_Radio_Button_CheckedChanged);
            // 
            // WWV2_Radio_Button
            // 
            this.WWV2_Radio_Button.AutoSize = true;
            this.WWV2_Radio_Button.BackColor = System.Drawing.Color.Transparent;
            this.WWV2_Radio_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WWV2_Radio_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WWV2_Radio_Button.ForeColor = System.Drawing.Color.White;
            this.WWV2_Radio_Button.Location = new System.Drawing.Point(129, 12);
            this.WWV2_Radio_Button.Name = "WWV2_Radio_Button";
            this.WWV2_Radio_Button.Size = new System.Drawing.Size(91, 27);
            this.WWV2_Radio_Button.TabIndex = 44;
            this.WWV2_Radio_Button.Text = "WWV2";
            this.toolTip.SetToolTip(this.WWV2_Radio_Button, "WWV - 10Mhz");
            this.WWV2_Radio_Button.UseVisualStyleBackColor = false;
            this.WWV2_Radio_Button.CheckedChanged += new System.EventHandler(this.WWV2_Radio_Button_CheckedChanged);
            // 
            // WWV3_Radio_Button
            // 
            this.WWV3_Radio_Button.AutoSize = true;
            this.WWV3_Radio_Button.BackColor = System.Drawing.Color.Transparent;
            this.WWV3_Radio_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WWV3_Radio_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WWV3_Radio_Button.ForeColor = System.Drawing.Color.White;
            this.WWV3_Radio_Button.Location = new System.Drawing.Point(226, 12);
            this.WWV3_Radio_Button.Name = "WWV3_Radio_Button";
            this.WWV3_Radio_Button.Size = new System.Drawing.Size(91, 27);
            this.WWV3_Radio_Button.TabIndex = 45;
            this.WWV3_Radio_Button.Text = "WWV3";
            this.toolTip.SetToolTip(this.WWV3_Radio_Button, "WWV - 15Mhz");
            this.WWV3_Radio_Button.UseVisualStyleBackColor = false;
            this.WWV3_Radio_Button.CheckedChanged += new System.EventHandler(this.WWV3_Radio_Button_CheckedChanged);
            // 
            // WWV4_Radio_Button
            // 
            this.WWV4_Radio_Button.AutoSize = true;
            this.WWV4_Radio_Button.BackColor = System.Drawing.Color.Transparent;
            this.WWV4_Radio_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WWV4_Radio_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WWV4_Radio_Button.ForeColor = System.Drawing.Color.White;
            this.WWV4_Radio_Button.Location = new System.Drawing.Point(323, 12);
            this.WWV4_Radio_Button.Name = "WWV4_Radio_Button";
            this.WWV4_Radio_Button.Size = new System.Drawing.Size(91, 27);
            this.WWV4_Radio_Button.TabIndex = 46;
            this.WWV4_Radio_Button.Text = "WWV4";
            this.toolTip.SetToolTip(this.WWV4_Radio_Button, "WWV - 20Mhz");
            this.WWV4_Radio_Button.UseVisualStyleBackColor = false;
            this.WWV4_Radio_Button.CheckedChanged += new System.EventHandler(this.WWV4_Radio_Button_CheckedChanged);
            // 
            // CHU2_Radio_Button
            // 
            this.CHU2_Radio_Button.AutoSize = true;
            this.CHU2_Radio_Button.BackColor = System.Drawing.Color.Transparent;
            this.CHU2_Radio_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CHU2_Radio_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHU2_Radio_Button.ForeColor = System.Drawing.Color.White;
            this.CHU2_Radio_Button.Location = new System.Drawing.Point(507, 12);
            this.CHU2_Radio_Button.Name = "CHU2_Radio_Button";
            this.CHU2_Radio_Button.Size = new System.Drawing.Size(81, 27);
            this.CHU2_Radio_Button.TabIndex = 48;
            this.CHU2_Radio_Button.Text = "CHU2";
            this.CHU2_Radio_Button.UseVisualStyleBackColor = false;
            this.CHU2_Radio_Button.CheckedChanged += new System.EventHandler(this.CHU2_Radio_Button_CheckedChanged);
            // 
            // Spare_Radio_Button
            // 
            this.Spare_Radio_Button.AutoSize = true;
            this.Spare_Radio_Button.BackColor = System.Drawing.Color.Transparent;
            this.Spare_Radio_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Spare_Radio_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spare_Radio_Button.ForeColor = System.Drawing.Color.White;
            this.Spare_Radio_Button.Location = new System.Drawing.Point(676, 12);
            this.Spare_Radio_Button.Name = "Spare_Radio_Button";
            this.Spare_Radio_Button.Size = new System.Drawing.Size(69, 27);
            this.Spare_Radio_Button.TabIndex = 50;
            this.Spare_Radio_Button.Text = "GEN";
            this.Spare_Radio_Button.UseVisualStyleBackColor = false;
            this.Spare_Radio_Button.CheckedChanged += new System.EventHandler(this.Spare_Radio_Button_CheckedChanged);
            // 
            // CHU1_Radio_Button
            // 
            this.CHU1_Radio_Button.AutoSize = true;
            this.CHU1_Radio_Button.BackColor = System.Drawing.Color.Transparent;
            this.CHU1_Radio_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CHU1_Radio_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHU1_Radio_Button.ForeColor = System.Drawing.Color.White;
            this.CHU1_Radio_Button.Location = new System.Drawing.Point(420, 12);
            this.CHU1_Radio_Button.Name = "CHU1_Radio_Button";
            this.CHU1_Radio_Button.Size = new System.Drawing.Size(81, 27);
            this.CHU1_Radio_Button.TabIndex = 47;
            this.CHU1_Radio_Button.Text = "CHU1";
            this.CHU1_Radio_Button.UseVisualStyleBackColor = false;
            this.CHU1_Radio_Button.CheckedChanged += new System.EventHandler(this.CHU1_Radio_Button_CheckedChanged);
            // 
            // TX
            // 
            this.TX.BackColor = System.Drawing.Color.Black;
            this.TX.Controls.Add(this.Auto_Tune_Time_button);
            this.TX.Controls.Add(this.Auto_Tune_button);
            this.TX.Controls.Add(this.TX_Tab_Band_label);
            this.TX.Controls.Add(this.ALC_ON_OFF_button5);
            this.TX.Controls.Add(this.AGC_Value_label);
            this.TX.Controls.Add(this.NB_Threshold_label);
            this.TX.Controls.Add(this.NB_Pulse_lable);
            this.TX.Controls.Add(this.groupBox5);
            this.TX.Controls.Add(this.Full_Power_checkBox1);
            this.TX.Controls.Add(this.NR_label5);
            this.TX.Controls.Add(this.NR_Button);
            this.TX.Controls.Add(this.label55);
            this.TX.Controls.Add(this.AGC_hScrollBar1);
            this.TX.Controls.Add(this.label53);
            this.TX.Controls.Add(this.Default_High_Cut_listBox1);
            this.TX.Controls.Add(this.label52);
            this.TX.Controls.Add(this.Default_CW_Filter_listBox1);
            this.TX.Controls.Add(this.label51);
            this.TX.Controls.Add(this.Default_Low_Cut_listBox1);
            this.TX.Controls.Add(this.label50);
            this.TX.Controls.Add(this.Tune_vButton2);
            this.TX.Controls.Add(this.QRP_Button);
            this.TX.Controls.Add(this.NB_Threshold_label1);
            this.TX.Controls.Add(this.NB_label16);
            this.TX.Controls.Add(this.NB_ON_OFF_button2);
            this.TX.Controls.Add(this.NB_Threshold_hScrollBar1);
            this.TX.Controls.Add(this.NB_hScrollBar1);
            this.TX.Controls.Add(this.NR_hScrollBar1);
            this.TX.Controls.Add(this.AGC_listBox1);
            this.TX.Controls.Add(this.AGC_label2);
            this.TX.Controls.Add(this.Tune_Power_label37);
            this.TX.Controls.Add(this.Tune_Power_hScrollBar1);
            this.TX.Controls.Add(this.label36);
            this.TX.Controls.Add(this.CW_Power_label36);
            this.TX.Controls.Add(this.SSB_Power_label36);
            this.TX.Controls.Add(this.AM_Carrier_label36);
            this.TX.Controls.Add(this.CW_Power_hScrollBar1);
            this.TX.Controls.Add(this.label34);
            this.TX.Controls.Add(this.Power_hScrollBar1);
            this.TX.Controls.Add(this.Power_label34);
            this.TX.Controls.Add(this.TX_Bandwidth_listBox1);
            this.TX.Controls.Add(this.AM_Carrier_label2);
            this.TX.Controls.Add(this.AM_Carrier_hScrollBar1);
            this.TX.Controls.Add(this.label14);
            this.TX.ForeColor = System.Drawing.Color.Black;
            this.TX.Location = new System.Drawing.Point(4, 24);
            this.TX.Margin = new System.Windows.Forms.Padding(0);
            this.TX.Name = "TX";
            this.TX.Size = new System.Drawing.Size(806, 481);
            this.TX.TabIndex = 11;
            this.TX.Text = "    Rx/Tx    ";
            this.TX.ToolTipText = "RECEIVE AND TRANSMIT SETTINGS";
            this.TX.Click += new System.EventHandler(this.TX_Click);
            this.TX.Enter += new System.EventHandler(this.TX_Tab_Enter);
            this.TX.Leave += new System.EventHandler(this.TX_Tab_Leave);
            // 
            // Auto_Tune_Time_button
            // 
            this.Auto_Tune_Time_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Auto_Tune_Time_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Auto_Tune_Time_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auto_Tune_Time_button.ForeColor = System.Drawing.Color.Black;
            this.Auto_Tune_Time_button.Location = new System.Drawing.Point(279, 117);
            this.Auto_Tune_Time_button.Name = "Auto_Tune_Time_button";
            this.Auto_Tune_Time_button.Size = new System.Drawing.Size(235, 24);
            this.Auto_Tune_Time_button.TabIndex = 204;
            this.Auto_Tune_Time_button.Text = "AUTO TUNE: HOLD";
            this.toolTip.SetToolTip(this.Auto_Tune_Time_button, "AUTO TUNE HOLD TIME IN SECONDS");
            this.Auto_Tune_Time_button.UseVisualStyleBackColor = false;
            this.Auto_Tune_Time_button.Click += new System.EventHandler(this.Auto_Tune_Time_button_Click);
            // 
            // Auto_Tune_button
            // 
            this.Auto_Tune_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Auto_Tune_button.Enabled = false;
            this.Auto_Tune_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Auto_Tune_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auto_Tune_button.ForeColor = System.Drawing.Color.Black;
            this.Auto_Tune_button.Location = new System.Drawing.Point(293, 419);
            this.Auto_Tune_button.Name = "Auto_Tune_button";
            this.Auto_Tune_button.Size = new System.Drawing.Size(185, 26);
            this.Auto_Tune_button.TabIndex = 203;
            this.Auto_Tune_button.Text = "AUTO TUNE: QRP";
            this.toolTip.SetToolTip(this.Auto_Tune_button, "SET TUNE ON / OFF");
            this.Auto_Tune_button.UseVisualStyleBackColor = false;
            this.Auto_Tune_button.Visible = false;
            this.Auto_Tune_button.Click += new System.EventHandler(this.Auto_Tune_button_Click);
            // 
            // TX_Tab_Band_label
            // 
            this.TX_Tab_Band_label.BackColor = System.Drawing.Color.Gainsboro;
            this.TX_Tab_Band_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TX_Tab_Band_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Tab_Band_label.Location = new System.Drawing.Point(328, 88);
            this.TX_Tab_Band_label.Name = "TX_Tab_Band_label";
            this.TX_Tab_Band_label.Size = new System.Drawing.Size(136, 20);
            this.TX_Tab_Band_label.TabIndex = 202;
            this.TX_Tab_Band_label.Text = "BAND: 2200M";
            this.TX_Tab_Band_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TX_Tab_Band_label.UseMnemonic = false;
            this.TX_Tab_Band_label.Click += new System.EventHandler(this.TX_Tab_Band_label_Click);
            // 
            // ALC_ON_OFF_button5
            // 
            this.ALC_ON_OFF_button5.BackColor = System.Drawing.Color.Gainsboro;
            this.ALC_ON_OFF_button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ALC_ON_OFF_button5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALC_ON_OFF_button5.ForeColor = System.Drawing.Color.Black;
            this.ALC_ON_OFF_button5.Location = new System.Drawing.Point(347, 147);
            this.ALC_ON_OFF_button5.Name = "ALC_ON_OFF_button5";
            this.ALC_ON_OFF_button5.Size = new System.Drawing.Size(98, 26);
            this.ALC_ON_OFF_button5.TabIndex = 200;
            this.ALC_ON_OFF_button5.Text = "ALC ON";
            this.toolTip.SetToolTip(this.ALC_ON_OFF_button5, "TURN ALC OFF\r\n!TEST MODE ONLY!");
            this.ALC_ON_OFF_button5.UseVisualStyleBackColor = false;
            this.ALC_ON_OFF_button5.Click += new System.EventHandler(this.ALC_ON_OFF_button5_Click);
            // 
            // AGC_Value_label
            // 
            this.AGC_Value_label.BackColor = System.Drawing.Color.Gainsboro;
            this.AGC_Value_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AGC_Value_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGC_Value_label.Location = new System.Drawing.Point(612, 369);
            this.AGC_Value_label.Name = "AGC_Value_label";
            this.AGC_Value_label.Size = new System.Drawing.Size(73, 24);
            this.AGC_Value_label.TabIndex = 196;
            this.AGC_Value_label.Text = "999 ms";
            this.AGC_Value_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AGC_Value_label.UseMnemonic = false;
            this.AGC_Value_label.Click += new System.EventHandler(this.AGC_Value_label_Click);
            // 
            // NB_Threshold_label
            // 
            this.NB_Threshold_label.BackColor = System.Drawing.Color.Gainsboro;
            this.NB_Threshold_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NB_Threshold_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_Threshold_label.Location = new System.Drawing.Point(165, 368);
            this.NB_Threshold_label.Name = "NB_Threshold_label";
            this.NB_Threshold_label.Size = new System.Drawing.Size(63, 20);
            this.NB_Threshold_label.TabIndex = 195;
            this.NB_Threshold_label.Text = "100%";
            this.NB_Threshold_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NB_Threshold_label.Click += new System.EventHandler(this.NB_Threshold_label_Click);
            // 
            // NB_Pulse_lable
            // 
            this.NB_Pulse_lable.BackColor = System.Drawing.Color.Gainsboro;
            this.NB_Pulse_lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NB_Pulse_lable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_Pulse_lable.Location = new System.Drawing.Point(183, 311);
            this.NB_Pulse_lable.Name = "NB_Pulse_lable";
            this.NB_Pulse_lable.Size = new System.Drawing.Size(68, 24);
            this.NB_Pulse_lable.TabIndex = 194;
            this.NB_Pulse_lable.Text = "200 us";
            this.NB_Pulse_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NB_Pulse_lable.Click += new System.EventHandler(this.NB_Pulse_lable_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Reverse_Power_label43);
            this.groupBox5.Controls.Add(this.Forward_Meter);
            this.groupBox5.Controls.Add(this.SWR_label1);
            this.groupBox5.Controls.Add(this.Reverse_Meter);
            this.groupBox5.Controls.Add(this.Power_Meter_Hold);
            this.groupBox5.Controls.Add(this.Meter_hold_label43);
            this.groupBox5.Controls.Add(this.Forward_Power_label43);
            this.groupBox5.Controls.Add(this.Forward_label43);
            this.groupBox5.Controls.Add(this.SWR_Value_label43);
            this.groupBox5.Controls.Add(this.Reverse_label58);
            this.groupBox5.Enabled = false;
            this.groupBox5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(279, 179);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 165);
            this.groupBox5.TabIndex = 193;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Meter";
            this.groupBox5.Visible = false;
            // 
            // Reverse_Power_label43
            // 
            this.Reverse_Power_label43.BackColor = System.Drawing.Color.Gainsboro;
            this.Reverse_Power_label43.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reverse_Power_label43.ForeColor = System.Drawing.Color.Black;
            this.Reverse_Power_label43.Location = new System.Drawing.Point(100, 59);
            this.Reverse_Power_label43.Name = "Reverse_Power_label43";
            this.Reverse_Power_label43.Size = new System.Drawing.Size(63, 17);
            this.Reverse_Power_label43.TabIndex = 190;
            this.Reverse_Power_label43.Text = "0";
            this.Reverse_Power_label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Reverse_Power_label43.Click += new System.EventHandler(this.Reverse_Power_label43_Click_1);
            // 
            // Forward_Meter
            // 
            this.Forward_Meter.AnalogMeter = false;
            this.Forward_Meter.BackColor = System.Drawing.Color.Moccasin;
            this.Forward_Meter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Forward_Meter.DialBackground = System.Drawing.Color.Moccasin;
            this.Forward_Meter.DialTextNegative = System.Drawing.Color.Red;
            this.Forward_Meter.DialTextPositive = System.Drawing.Color.Black;
            this.Forward_Meter.DialTextZero = System.Drawing.Color.DarkGreen;
            this.Forward_Meter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_Meter.Led1ColorOff = System.Drawing.Color.Snow;
            this.Forward_Meter.Led1ColorOn = System.Drawing.Color.Green;
            this.Forward_Meter.Led1Count = 12;
            this.Forward_Meter.Led2ColorOff = System.Drawing.Color.Snow;
            this.Forward_Meter.Led2ColorOn = System.Drawing.Color.Green;
            this.Forward_Meter.Led2Count = 13;
            this.Forward_Meter.Led3ColorOff = System.Drawing.Color.Snow;
            this.Forward_Meter.Led3ColorOn = System.Drawing.Color.Red;
            this.Forward_Meter.Led3Count = 2;
            this.Forward_Meter.LedSize = new System.Drawing.Size(7, 12);
            this.Forward_Meter.LedSpace = 1;
            this.Forward_Meter.Level = 0;
            this.Forward_Meter.LevelMax = 110;
            this.Forward_Meter.Location = new System.Drawing.Point(9, 40);
            this.Forward_Meter.MeterScale = VU_MeterLibrary.MeterScale.Analog;
            this.Forward_Meter.Name = "Forward_Meter";
            this.Forward_Meter.NeedleColor = System.Drawing.Color.Black;
            this.Forward_Meter.PeakHold = false;
            this.Forward_Meter.Peakms = 2000;
            this.Forward_Meter.PeakNeedleColor = System.Drawing.Color.Red;
            this.Forward_Meter.ShowDialOnly = false;
            this.Forward_Meter.ShowLedPeak = false;
            this.Forward_Meter.ShowTextInDial = true;
            this.Forward_Meter.Size = new System.Drawing.Size(217, 14);
            this.Forward_Meter.TabIndex = 183;
            this.Forward_Meter.TextInDial = new string[] {
        "[S]",
        "1",
        "3",
        "5",
        "7",
        "9",
        "+20",
        "+40",
        "+60"};
            this.Forward_Meter.UseLedLight = true;
            this.Forward_Meter.VerticalBar = false;
            this.Forward_Meter.VuText = "ALC";
            this.Forward_Meter.Load += new System.EventHandler(this.Forward_Meter_Load_1);
            // 
            // SWR_label1
            // 
            this.SWR_label1.BackColor = System.Drawing.Color.Gainsboro;
            this.SWR_label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWR_label1.ForeColor = System.Drawing.Color.Black;
            this.SWR_label1.Location = new System.Drawing.Point(62, 102);
            this.SWR_label1.Name = "SWR_label1";
            this.SWR_label1.Size = new System.Drawing.Size(52, 17);
            this.SWR_label1.TabIndex = 184;
            this.SWR_label1.Text = "SWR";
            this.SWR_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reverse_Meter
            // 
            this.Reverse_Meter.AnalogMeter = false;
            this.Reverse_Meter.BackColor = System.Drawing.Color.Moccasin;
            this.Reverse_Meter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reverse_Meter.DialBackground = System.Drawing.Color.Moccasin;
            this.Reverse_Meter.DialTextNegative = System.Drawing.Color.Red;
            this.Reverse_Meter.DialTextPositive = System.Drawing.Color.Black;
            this.Reverse_Meter.DialTextZero = System.Drawing.Color.DarkGreen;
            this.Reverse_Meter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reverse_Meter.Led1ColorOff = System.Drawing.Color.Snow;
            this.Reverse_Meter.Led1ColorOn = System.Drawing.Color.Green;
            this.Reverse_Meter.Led1Count = 12;
            this.Reverse_Meter.Led2ColorOff = System.Drawing.Color.Snow;
            this.Reverse_Meter.Led2ColorOn = System.Drawing.Color.Green;
            this.Reverse_Meter.Led2Count = 13;
            this.Reverse_Meter.Led3ColorOff = System.Drawing.Color.Snow;
            this.Reverse_Meter.Led3ColorOn = System.Drawing.Color.Red;
            this.Reverse_Meter.Led3Count = 2;
            this.Reverse_Meter.LedSize = new System.Drawing.Size(7, 12);
            this.Reverse_Meter.LedSpace = 1;
            this.Reverse_Meter.Level = 0;
            this.Reverse_Meter.LevelMax = 110;
            this.Reverse_Meter.Location = new System.Drawing.Point(9, 81);
            this.Reverse_Meter.MeterScale = VU_MeterLibrary.MeterScale.Analog;
            this.Reverse_Meter.Name = "Reverse_Meter";
            this.Reverse_Meter.NeedleColor = System.Drawing.Color.Black;
            this.Reverse_Meter.PeakHold = false;
            this.Reverse_Meter.Peakms = 1000;
            this.Reverse_Meter.PeakNeedleColor = System.Drawing.Color.Red;
            this.Reverse_Meter.ShowDialOnly = false;
            this.Reverse_Meter.ShowLedPeak = false;
            this.Reverse_Meter.ShowTextInDial = true;
            this.Reverse_Meter.Size = new System.Drawing.Size(217, 14);
            this.Reverse_Meter.TabIndex = 185;
            this.Reverse_Meter.TextInDial = new string[] {
        "[S]",
        "1",
        "3",
        "5",
        "7",
        "9",
        "+20",
        "+40",
        "+60"};
            this.Reverse_Meter.UseLedLight = true;
            this.Reverse_Meter.VerticalBar = false;
            this.Reverse_Meter.VuText = "ALC";
            this.Reverse_Meter.Load += new System.EventHandler(this.Reverse_Meter_Load_1);
            // 
            // Power_Meter_Hold
            // 
            this.Power_Meter_Hold.BackColor = System.Drawing.Color.White;
            this.Power_Meter_Hold.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Power_Meter_Hold.ForeColor = System.Drawing.Color.Black;
            this.Power_Meter_Hold.Location = new System.Drawing.Point(175, 128);
            this.Power_Meter_Hold.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Power_Meter_Hold.Name = "Power_Meter_Hold";
            this.Power_Meter_Hold.Size = new System.Drawing.Size(48, 27);
            this.Power_Meter_Hold.TabIndex = 191;
            this.Power_Meter_Hold.ValueChanged += new System.EventHandler(this.Power_Meter_Hold_ValueChanged_1);
            // 
            // Meter_hold_label43
            // 
            this.Meter_hold_label43.AutoSize = true;
            this.Meter_hold_label43.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meter_hold_label43.ForeColor = System.Drawing.Color.White;
            this.Meter_hold_label43.Location = new System.Drawing.Point(8, 132);
            this.Meter_hold_label43.Name = "Meter_hold_label43";
            this.Meter_hold_label43.Size = new System.Drawing.Size(125, 18);
            this.Meter_hold_label43.TabIndex = 192;
            this.Meter_hold_label43.Text = "METER HOLD";
            this.Meter_hold_label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meter_hold_label43.Click += new System.EventHandler(this.Meter_hold_label43_Click);
            // 
            // Forward_Power_label43
            // 
            this.Forward_Power_label43.BackColor = System.Drawing.Color.Gainsboro;
            this.Forward_Power_label43.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_Power_label43.ForeColor = System.Drawing.Color.Black;
            this.Forward_Power_label43.Location = new System.Drawing.Point(100, 18);
            this.Forward_Power_label43.Name = "Forward_Power_label43";
            this.Forward_Power_label43.Size = new System.Drawing.Size(63, 17);
            this.Forward_Power_label43.TabIndex = 189;
            this.Forward_Power_label43.Text = "0";
            this.Forward_Power_label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Forward_Power_label43.Click += new System.EventHandler(this.Forward_Power_label43_Click_1);
            // 
            // Forward_label43
            // 
            this.Forward_label43.BackColor = System.Drawing.Color.Gainsboro;
            this.Forward_label43.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_label43.ForeColor = System.Drawing.Color.Black;
            this.Forward_label43.Location = new System.Drawing.Point(71, 18);
            this.Forward_label43.Name = "Forward_label43";
            this.Forward_label43.Size = new System.Drawing.Size(23, 17);
            this.Forward_label43.TabIndex = 186;
            this.Forward_label43.Text = "F";
            this.Forward_label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SWR_Value_label43
            // 
            this.SWR_Value_label43.BackColor = System.Drawing.Color.Gainsboro;
            this.SWR_Value_label43.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWR_Value_label43.ForeColor = System.Drawing.Color.Black;
            this.SWR_Value_label43.Location = new System.Drawing.Point(120, 102);
            this.SWR_Value_label43.Name = "SWR_Value_label43";
            this.SWR_Value_label43.Size = new System.Drawing.Size(52, 17);
            this.SWR_Value_label43.TabIndex = 188;
            this.SWR_Value_label43.Text = "1.0";
            this.SWR_Value_label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SWR_Value_label43.Click += new System.EventHandler(this.SWR_Value_label43_Click_1);
            // 
            // Reverse_label58
            // 
            this.Reverse_label58.BackColor = System.Drawing.Color.Gainsboro;
            this.Reverse_label58.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reverse_label58.ForeColor = System.Drawing.Color.Black;
            this.Reverse_label58.Location = new System.Drawing.Point(71, 59);
            this.Reverse_label58.Name = "Reverse_label58";
            this.Reverse_label58.Size = new System.Drawing.Size(23, 17);
            this.Reverse_label58.TabIndex = 187;
            this.Reverse_label58.Text = "R";
            this.Reverse_label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Full_Power_checkBox1
            // 
            this.Full_Power_checkBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.Full_Power_checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Full_Power_checkBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_Power_checkBox1.ForeColor = System.Drawing.Color.Black;
            this.Full_Power_checkBox1.Location = new System.Drawing.Point(569, 201);
            this.Full_Power_checkBox1.MinimumSize = new System.Drawing.Size(110, 20);
            this.Full_Power_checkBox1.Name = "Full_Power_checkBox1";
            this.Full_Power_checkBox1.Size = new System.Drawing.Size(158, 22);
            this.Full_Power_checkBox1.TabIndex = 170;
            this.Full_Power_checkBox1.Text = "POWER: TUNE";
            this.toolTip.SetToolTip(this.Full_Power_checkBox1, "CLICK TO SET FULL POWER TUNE");
            this.Full_Power_checkBox1.UseVisualStyleBackColor = false;
            this.Full_Power_checkBox1.CheckedChanged += new System.EventHandler(this.Full_Power_checkBox1_CheckedChanged);
            // 
            // NR_label5
            // 
            this.NR_label5.BackColor = System.Drawing.Color.Gainsboro;
            this.NR_label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NR_label5.Enabled = false;
            this.NR_label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NR_label5.ForeColor = System.Drawing.Color.Black;
            this.NR_label5.Location = new System.Drawing.Point(404, 350);
            this.NR_label5.Name = "NR_label5";
            this.NR_label5.Size = new System.Drawing.Size(60, 24);
            this.NR_label5.TabIndex = 167;
            this.NR_label5.Text = "100";
            this.NR_label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NR_label5.Visible = false;
            this.NR_label5.Click += new System.EventHandler(this.NR_label5_Click);
            // 
            // NR_Button
            // 
            this.NR_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.NR_Button.Enabled = false;
            this.NR_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NR_Button.ForeColor = System.Drawing.Color.Black;
            this.NR_Button.Location = new System.Drawing.Point(313, 350);
            this.NR_Button.Name = "NR_Button";
            this.NR_Button.Size = new System.Drawing.Size(60, 24);
            this.NR_Button.TabIndex = 166;
            this.NR_Button.Text = "NR";
            this.NR_Button.UseVisualStyleBackColor = false;
            this.NR_Button.Visible = false;
            this.NR_Button.Click += new System.EventHandler(this.NR_Button_Click);
            // 
            // label55
            // 
            this.label55.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(552, 320);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(193, 20);
            this.label55.TabIndex = 163;
            this.label55.Text = "AGC FAST RELEASE";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AGC_hScrollBar1
            // 
            this.AGC_hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.AGC_hScrollBar1.LargeChange = 100;
            this.AGC_hScrollBar1.Location = new System.Drawing.Point(556, 346);
            this.AGC_hScrollBar1.Maximum = 1098;
            this.AGC_hScrollBar1.Minimum = 1;
            this.AGC_hScrollBar1.Name = "AGC_hScrollBar1";
            this.AGC_hScrollBar1.Size = new System.Drawing.Size(185, 18);
            this.AGC_hScrollBar1.SmallChange = 10;
            this.AGC_hScrollBar1.TabIndex = 162;
            this.toolTip.SetToolTip(this.AGC_hScrollBar1, "SET AGC RELEASE TIME\r\nFAST MODE ONLY");
            this.AGC_hScrollBar1.Value = 20;
            this.AGC_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.AGC_hScrollBar1_Scroll);
            // 
            // label53
            // 
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(185, 114);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(76, 21);
            this.label53.TabIndex = 161;
            this.label53.Text = "HIGH CUT";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Default_High_Cut_listBox1
            // 
            this.Default_High_Cut_listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.Default_High_Cut_listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Default_High_Cut_listBox1.ForeColor = System.Drawing.Color.Black;
            this.Default_High_Cut_listBox1.FormattingEnabled = true;
            this.Default_High_Cut_listBox1.ItemHeight = 18;
            this.Default_High_Cut_listBox1.Items.AddRange(new object[] {
            "5.5KHz",
            "4.0KHz",
            "3.0KHz",
            "2.7KHz",
            "2.4KHz"});
            this.Default_High_Cut_listBox1.Location = new System.Drawing.Point(190, 134);
            this.Default_High_Cut_listBox1.Name = "Default_High_Cut_listBox1";
            this.Default_High_Cut_listBox1.Size = new System.Drawing.Size(66, 94);
            this.Default_High_Cut_listBox1.TabIndex = 160;
            this.Default_High_Cut_listBox1.SelectedIndexChanged += new System.EventHandler(this.Default_High_Cut_listBox1_SelectedIndexChanged);
            // 
            // label52
            // 
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(115, 214);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(56, 21);
            this.label52.TabIndex = 159;
            this.label52.Text = "CW BW";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Default_CW_Filter_listBox1
            // 
            this.Default_CW_Filter_listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.Default_CW_Filter_listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Default_CW_Filter_listBox1.ForeColor = System.Drawing.Color.Black;
            this.Default_CW_Filter_listBox1.FormattingEnabled = true;
            this.Default_CW_Filter_listBox1.ItemHeight = 18;
            this.Default_CW_Filter_listBox1.Items.AddRange(new object[] {
            "1.8KHz",
            "400Hz",
            "200Hz"});
            this.Default_CW_Filter_listBox1.Location = new System.Drawing.Point(110, 238);
            this.Default_CW_Filter_listBox1.Name = "Default_CW_Filter_listBox1";
            this.Default_CW_Filter_listBox1.Size = new System.Drawing.Size(66, 58);
            this.Default_CW_Filter_listBox1.TabIndex = 158;
            this.Default_CW_Filter_listBox1.SelectedIndexChanged += new System.EventHandler(this.Default_CW_Filter_listBox1_SelectedIndexChanged);
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(25, 114);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(72, 21);
            this.label51.TabIndex = 157;
            this.label51.Text = "LOW CUT";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Default_Low_Cut_listBox1
            // 
            this.Default_Low_Cut_listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.Default_Low_Cut_listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Default_Low_Cut_listBox1.ForeColor = System.Drawing.Color.Black;
            this.Default_Low_Cut_listBox1.FormattingEnabled = true;
            this.Default_Low_Cut_listBox1.ItemHeight = 18;
            this.Default_Low_Cut_listBox1.Items.AddRange(new object[] {
            "500Hz",
            "300Hz",
            "200Hz",
            "100Hz",
            "75Hz"});
            this.Default_Low_Cut_listBox1.Location = new System.Drawing.Point(28, 134);
            this.Default_Low_Cut_listBox1.Name = "Default_Low_Cut_listBox1";
            this.Default_Low_Cut_listBox1.Size = new System.Drawing.Size(66, 94);
            this.Default_Low_Cut_listBox1.TabIndex = 156;
            this.Default_Low_Cut_listBox1.SelectedIndexChanged += new System.EventHandler(this.Default_Low_Cut_listBox1_SelectedIndexChanged);
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(56, 95);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(173, 17);
            this.label50.TabIndex = 155;
            this.label50.Text = "DEFAULT FILTERS";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label50.Click += new System.EventHandler(this.label50_Click);
            // 
            // Tune_vButton2
            // 
            this.Tune_vButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.Tune_vButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tune_vButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tune_vButton2.ForeColor = System.Drawing.Color.Black;
            this.Tune_vButton2.Location = new System.Drawing.Point(581, 168);
            this.Tune_vButton2.Name = "Tune_vButton2";
            this.Tune_vButton2.Size = new System.Drawing.Size(62, 26);
            this.Tune_vButton2.TabIndex = 145;
            this.Tune_vButton2.Text = "TUN";
            this.toolTip.SetToolTip(this.Tune_vButton2, "SET TUNE ON / OFF");
            this.Tune_vButton2.UseVisualStyleBackColor = false;
            this.Tune_vButton2.Click += new System.EventHandler(this.Tune_vButton2_Click_1);
            // 
            // QRP_Button
            // 
            this.QRP_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.QRP_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QRP_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRP_Button.ForeColor = System.Drawing.Color.Black;
            this.QRP_Button.Location = new System.Drawing.Point(649, 168);
            this.QRP_Button.Name = "QRP_Button";
            this.QRP_Button.Size = new System.Drawing.Size(61, 26);
            this.QRP_Button.TabIndex = 144;
            this.QRP_Button.Text = "AMP";
            this.toolTip.SetToolTip(this.QRP_Button, "CLICK IF AMPLIFIER IS ATTACHED");
            this.QRP_Button.UseVisualStyleBackColor = false;
            this.QRP_Button.Click += new System.EventHandler(this.QRP_Button_Click_1);
            // 
            // NB_Threshold_label1
            // 
            this.NB_Threshold_label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_Threshold_label1.ForeColor = System.Drawing.Color.White;
            this.NB_Threshold_label1.Location = new System.Drawing.Point(43, 369);
            this.NB_Threshold_label1.Name = "NB_Threshold_label1";
            this.NB_Threshold_label1.Size = new System.Drawing.Size(120, 18);
            this.NB_Threshold_label1.TabIndex = 143;
            this.NB_Threshold_label1.Text = "THRESHOLD";
            this.NB_Threshold_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NB_label16
            // 
            this.NB_label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_label16.ForeColor = System.Drawing.Color.White;
            this.NB_label16.Location = new System.Drawing.Point(101, 314);
            this.NB_label16.Name = "NB_label16";
            this.NB_label16.Size = new System.Drawing.Size(75, 18);
            this.NB_label16.TabIndex = 142;
            this.NB_label16.Text = "PULSE WIDTH";
            this.NB_label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NB_label16.Click += new System.EventHandler(this.NB_label16_Click);
            // 
            // NB_ON_OFF_button2
            // 
            this.NB_ON_OFF_button2.BackColor = System.Drawing.Color.Gainsboro;
            this.NB_ON_OFF_button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NB_ON_OFF_button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_ON_OFF_button2.ForeColor = System.Drawing.Color.Black;
            this.NB_ON_OFF_button2.Location = new System.Drawing.Point(30, 311);
            this.NB_ON_OFF_button2.Name = "NB_ON_OFF_button2";
            this.NB_ON_OFF_button2.Size = new System.Drawing.Size(68, 24);
            this.NB_ON_OFF_button2.TabIndex = 141;
            this.NB_ON_OFF_button2.Text = "NB";
            this.toolTip.SetToolTip(this.NB_ON_OFF_button2, "NOISE BLANKER ON /OFF");
            this.NB_ON_OFF_button2.UseVisualStyleBackColor = false;
            this.NB_ON_OFF_button2.Click += new System.EventHandler(this.NB_ON_OFF_button2_Click);
            // 
            // NB_Threshold_hScrollBar1
            // 
            this.NB_Threshold_hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.NB_Threshold_hScrollBar1.LargeChange = 20;
            this.NB_Threshold_hScrollBar1.Location = new System.Drawing.Point(48, 397);
            this.NB_Threshold_hScrollBar1.Maximum = 1009;
            this.NB_Threshold_hScrollBar1.Minimum = 1;
            this.NB_Threshold_hScrollBar1.Name = "NB_Threshold_hScrollBar1";
            this.NB_Threshold_hScrollBar1.Size = new System.Drawing.Size(185, 18);
            this.NB_Threshold_hScrollBar1.SmallChange = 5;
            this.NB_Threshold_hScrollBar1.TabIndex = 127;
            this.toolTip.SetToolTip(this.NB_Threshold_hScrollBar1, "RELATIVE AMPLITUDE OF PULSE NOISE");
            this.NB_Threshold_hScrollBar1.Value = 20;
            this.NB_Threshold_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.NB_Threshold_hScrollBar1_Scroll);
            // 
            // NB_hScrollBar1
            // 
            this.NB_hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.NB_hScrollBar1.Location = new System.Drawing.Point(46, 342);
            this.NB_hScrollBar1.Maximum = 510;
            this.NB_hScrollBar1.Minimum = 10;
            this.NB_hScrollBar1.Name = "NB_hScrollBar1";
            this.NB_hScrollBar1.Size = new System.Drawing.Size(185, 18);
            this.NB_hScrollBar1.TabIndex = 125;
            this.toolTip.SetToolTip(this.NB_hScrollBar1, "SET RELATIVE SIZE OF PULSE WIDTH");
            this.NB_hScrollBar1.Value = 30;
            this.NB_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.NB_hScrollBar1_Scroll);
            // 
            // NR_hScrollBar1
            // 
            this.NR_hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.NR_hScrollBar1.Enabled = false;
            this.NR_hScrollBar1.LargeChange = 20;
            this.NR_hScrollBar1.Location = new System.Drawing.Point(304, 385);
            this.NR_hScrollBar1.Minimum = 10;
            this.NR_hScrollBar1.Name = "NR_hScrollBar1";
            this.NR_hScrollBar1.Size = new System.Drawing.Size(185, 18);
            this.NR_hScrollBar1.SmallChange = 10;
            this.NR_hScrollBar1.TabIndex = 123;
            this.NR_hScrollBar1.Value = 20;
            this.NR_hScrollBar1.Visible = false;
            this.NR_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.NR_hScrollBar1_Scroll);
            // 
            // AGC_listBox1
            // 
            this.AGC_listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.AGC_listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGC_listBox1.ForeColor = System.Drawing.Color.Black;
            this.AGC_listBox1.FormattingEnabled = true;
            this.AGC_listBox1.ItemHeight = 18;
            this.AGC_listBox1.Items.AddRange(new object[] {
            "SLOW",
            "MED",
            "FAST"});
            this.AGC_listBox1.Location = new System.Drawing.Point(618, 256);
            this.AGC_listBox1.Name = "AGC_listBox1";
            this.AGC_listBox1.Size = new System.Drawing.Size(60, 58);
            this.AGC_listBox1.TabIndex = 121;
            this.AGC_listBox1.SelectedIndexChanged += new System.EventHandler(this.AGC_listBox1_SelectedIndexChanged);
            // 
            // AGC_label2
            // 
            this.AGC_label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGC_label2.ForeColor = System.Drawing.Color.White;
            this.AGC_label2.Location = new System.Drawing.Point(623, 233);
            this.AGC_label2.Name = "AGC_label2";
            this.AGC_label2.Size = new System.Drawing.Size(51, 20);
            this.AGC_label2.TabIndex = 120;
            this.AGC_label2.Text = "AGC";
            this.AGC_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tune_Power_label37
            // 
            this.Tune_Power_label37.BackColor = System.Drawing.Color.Gainsboro;
            this.Tune_Power_label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tune_Power_label37.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tune_Power_label37.Location = new System.Drawing.Point(614, 139);
            this.Tune_Power_label37.Name = "Tune_Power_label37";
            this.Tune_Power_label37.Size = new System.Drawing.Size(69, 24);
            this.Tune_Power_label37.TabIndex = 119;
            this.Tune_Power_label37.Text = "50";
            this.Tune_Power_label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tune_Power_label37.Click += new System.EventHandler(this.Tune_Power_label37_Click);
            // 
            // Tune_Power_hScrollBar1
            // 
            this.Tune_Power_hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Tune_Power_hScrollBar1.LargeChange = 5;
            this.Tune_Power_hScrollBar1.Location = new System.Drawing.Point(538, 117);
            this.Tune_Power_hScrollBar1.Maximum = 104;
            this.Tune_Power_hScrollBar1.Name = "Tune_Power_hScrollBar1";
            this.Tune_Power_hScrollBar1.Size = new System.Drawing.Size(221, 18);
            this.Tune_Power_hScrollBar1.TabIndex = 118;
            this.Tune_Power_hScrollBar1.Value = 50;
            this.Tune_Power_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Tune_Power_hScrollBar1_Scroll);
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(543, 95);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(211, 17);
            this.label36.TabIndex = 117;
            this.label36.Text = "TUNE OUTPUT LEVEL";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label36.Click += new System.EventHandler(this.label36_Click_1);
            // 
            // CW_Power_label36
            // 
            this.CW_Power_label36.BackColor = System.Drawing.Color.Gainsboro;
            this.CW_Power_label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CW_Power_label36.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CW_Power_label36.Location = new System.Drawing.Point(614, 52);
            this.CW_Power_label36.Name = "CW_Power_label36";
            this.CW_Power_label36.Size = new System.Drawing.Size(69, 24);
            this.CW_Power_label36.TabIndex = 116;
            this.CW_Power_label36.Text = "100";
            this.CW_Power_label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CW_Power_label36.Click += new System.EventHandler(this.CW_Power_label36_Click);
            // 
            // SSB_Power_label36
            // 
            this.SSB_Power_label36.BackColor = System.Drawing.Color.Gainsboro;
            this.SSB_Power_label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SSB_Power_label36.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSB_Power_label36.Location = new System.Drawing.Point(362, 52);
            this.SSB_Power_label36.Name = "SSB_Power_label36";
            this.SSB_Power_label36.Size = new System.Drawing.Size(69, 24);
            this.SSB_Power_label36.TabIndex = 115;
            this.SSB_Power_label36.Text = "100%";
            this.SSB_Power_label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SSB_Power_label36.Click += new System.EventHandler(this.SSB_Power_label36_Click);
            // 
            // AM_Carrier_label36
            // 
            this.AM_Carrier_label36.BackColor = System.Drawing.Color.Gainsboro;
            this.AM_Carrier_label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AM_Carrier_label36.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AM_Carrier_label36.Location = new System.Drawing.Point(110, 52);
            this.AM_Carrier_label36.Name = "AM_Carrier_label36";
            this.AM_Carrier_label36.Size = new System.Drawing.Size(69, 24);
            this.AM_Carrier_label36.TabIndex = 114;
            this.AM_Carrier_label36.Text = "100";
            this.AM_Carrier_label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AM_Carrier_label36.Click += new System.EventHandler(this.AM_Carrier_label36_Click);
            // 
            // CW_Power_hScrollBar1
            // 
            this.CW_Power_hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.CW_Power_hScrollBar1.LargeChange = 2;
            this.CW_Power_hScrollBar1.Location = new System.Drawing.Point(538, 30);
            this.CW_Power_hScrollBar1.Maximum = 101;
            this.CW_Power_hScrollBar1.Name = "CW_Power_hScrollBar1";
            this.CW_Power_hScrollBar1.Size = new System.Drawing.Size(221, 18);
            this.CW_Power_hScrollBar1.TabIndex = 113;
            this.CW_Power_hScrollBar1.Value = 50;
            this.CW_Power_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CW_Power_hScrollBar1_Scroll);
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(550, 3);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(196, 17);
            this.label34.TabIndex = 112;
            this.label34.Text = "CW OUTPUT LEVEL";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label34.Click += new System.EventHandler(this.label34_Click);
            // 
            // Power_hScrollBar1
            // 
            this.Power_hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Power_hScrollBar1.LargeChange = 2;
            this.Power_hScrollBar1.Location = new System.Drawing.Point(286, 30);
            this.Power_hScrollBar1.Maximum = 101;
            this.Power_hScrollBar1.Name = "Power_hScrollBar1";
            this.Power_hScrollBar1.Size = new System.Drawing.Size(221, 18);
            this.Power_hScrollBar1.TabIndex = 111;
            this.Power_hScrollBar1.Value = 50;
            this.Power_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Power_hScrollBar1_Scroll);
            // 
            // Power_label34
            // 
            this.Power_label34.BackColor = System.Drawing.Color.Transparent;
            this.Power_label34.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Power_label34.ForeColor = System.Drawing.Color.White;
            this.Power_label34.Location = new System.Drawing.Point(301, 3);
            this.Power_label34.Name = "Power_label34";
            this.Power_label34.Size = new System.Drawing.Size(191, 17);
            this.Power_label34.TabIndex = 110;
            this.Power_label34.Text = "SSB OUTPUT LEVEL";
            this.Power_label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TX_Bandwidth_listBox1
            // 
            this.TX_Bandwidth_listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.TX_Bandwidth_listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Bandwidth_listBox1.ForeColor = System.Drawing.Color.Black;
            this.TX_Bandwidth_listBox1.FormattingEnabled = true;
            this.TX_Bandwidth_listBox1.ItemHeight = 18;
            this.TX_Bandwidth_listBox1.Items.AddRange(new object[] {
            "2.4KHz",
            "2.7KHz",
            "3.0KHz",
            "5.5KHz"});
            this.TX_Bandwidth_listBox1.Location = new System.Drawing.Point(109, 134);
            this.TX_Bandwidth_listBox1.Name = "TX_Bandwidth_listBox1";
            this.TX_Bandwidth_listBox1.Size = new System.Drawing.Size(66, 76);
            this.TX_Bandwidth_listBox1.TabIndex = 109;
            this.TX_Bandwidth_listBox1.SelectedIndexChanged += new System.EventHandler(this.TX_Bandwidth_listBox1_SelectedIndexChanged);
            // 
            // AM_Carrier_label2
            // 
            this.AM_Carrier_label2.BackColor = System.Drawing.Color.Transparent;
            this.AM_Carrier_label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AM_Carrier_label2.ForeColor = System.Drawing.Color.White;
            this.AM_Carrier_label2.Location = new System.Drawing.Point(47, 3);
            this.AM_Carrier_label2.Name = "AM_Carrier_label2";
            this.AM_Carrier_label2.Size = new System.Drawing.Size(194, 17);
            this.AM_Carrier_label2.TabIndex = 79;
            this.AM_Carrier_label2.Text = "AM CARRIER LEVEL";
            this.AM_Carrier_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AM_Carrier_hScrollBar1
            // 
            this.AM_Carrier_hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.AM_Carrier_hScrollBar1.LargeChange = 2;
            this.AM_Carrier_hScrollBar1.Location = new System.Drawing.Point(34, 30);
            this.AM_Carrier_hScrollBar1.Maximum = 101;
            this.AM_Carrier_hScrollBar1.Name = "AM_Carrier_hScrollBar1";
            this.AM_Carrier_hScrollBar1.Size = new System.Drawing.Size(221, 18);
            this.AM_Carrier_hScrollBar1.TabIndex = 78;
            this.AM_Carrier_hScrollBar1.Value = 50;
            this.AM_Carrier_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.AM_Carrier_hScrollBar1_Scroll);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(113, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 77;
            this.label14.Text = "TX Bandwidth";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // freqcaltab
            // 
            this.freqcaltab.BackColor = System.Drawing.Color.Black;
            this.freqcaltab.Controls.Add(this.Freq_Cal_groupBox4);
            this.freqcaltab.Controls.Add(this.IQ_groupBox3);
            this.freqcaltab.ForeColor = System.Drawing.Color.Black;
            this.freqcaltab.Location = new System.Drawing.Point(4, 24);
            this.freqcaltab.Name = "freqcaltab";
            this.freqcaltab.Padding = new System.Windows.Forms.Padding(10);
            this.freqcaltab.Size = new System.Drawing.Size(806, 481);
            this.freqcaltab.TabIndex = 6;
            this.freqcaltab.Text = "   Freq Cal   ";
            this.freqcaltab.ToolTipText = "FREQUENCY AND RX I/Q CALIBRATION";
            this.freqcaltab.Click += new System.EventHandler(this.freqcaltab_Click);
            this.freqcaltab.Enter += new System.EventHandler(this.freqcaltab_Enter);
            this.freqcaltab.Leave += new System.EventHandler(this.freqcaltab_Leave);
            // 
            // Freq_Cal_groupBox4
            // 
            this.Freq_Cal_groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.Freq_Cal_groupBox4.Controls.Add(this.PPM_Coarse_Value_Label);
            this.Freq_Cal_groupBox4.Controls.Add(this.Freq_Cal_Loose_button);
            this.Freq_Cal_groupBox4.Controls.Add(this.Adjust_PPM_Coarse_hScrollBar);
            this.Freq_Cal_groupBox4.Controls.Add(this.Signal_Average_label);
            this.Freq_Cal_groupBox4.Controls.Add(this.Freq_Calibration_Status_label);
            this.Freq_Cal_groupBox4.Controls.Add(this.Freq_Auto_Calibrate_button);
            this.Freq_Cal_groupBox4.Controls.Add(this.label49);
            this.Freq_Cal_groupBox4.Controls.Add(this.Freq_Cal_Meter);
            this.Freq_Cal_groupBox4.Controls.Add(this.Set_Calibration_button);
            this.Freq_Cal_groupBox4.Controls.Add(this.Freq_CAl_Progress_Lable);
            this.Freq_Cal_groupBox4.Controls.Add(this.Freq_Check_Button);
            this.Freq_Cal_groupBox4.Controls.Add(this.Freq_Cal_Reset_button4);
            this.Freq_Cal_groupBox4.Controls.Add(this.Calibration_progressBar1);
            this.Freq_Cal_groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Freq_Cal_groupBox4.ForeColor = System.Drawing.Color.White;
            this.Freq_Cal_groupBox4.Location = new System.Drawing.Point(10, 10);
            this.Freq_Cal_groupBox4.Name = "Freq_Cal_groupBox4";
            this.Freq_Cal_groupBox4.Size = new System.Drawing.Size(786, 231);
            this.Freq_Cal_groupBox4.TabIndex = 127;
            this.Freq_Cal_groupBox4.TabStop = false;
            this.Freq_Cal_groupBox4.Text = "FREQUENCY CALIBRATION";
            this.Freq_Cal_groupBox4.Enter += new System.EventHandler(this.Freq_Cal_groupBox4_Enter);
            // 
            // PPM_Coarse_Value_Label
            // 
            this.PPM_Coarse_Value_Label.BackColor = System.Drawing.Color.Gainsboro;
            this.PPM_Coarse_Value_Label.Enabled = false;
            this.PPM_Coarse_Value_Label.ForeColor = System.Drawing.Color.Black;
            this.PPM_Coarse_Value_Label.Location = new System.Drawing.Point(261, 160);
            this.PPM_Coarse_Value_Label.Name = "PPM_Coarse_Value_Label";
            this.PPM_Coarse_Value_Label.Size = new System.Drawing.Size(265, 19);
            this.PPM_Coarse_Value_Label.TabIndex = 234;
            this.PPM_Coarse_Value_Label.Text = "MANUAL OFFSET VALUE: ";
            this.PPM_Coarse_Value_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PPM_Coarse_Value_Label.Visible = false;
            // 
            // Freq_Cal_Loose_button
            // 
            this.Freq_Cal_Loose_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Cal_Loose_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Freq_Cal_Loose_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Cal_Loose_button.ForeColor = System.Drawing.Color.Black;
            this.Freq_Cal_Loose_button.Location = new System.Drawing.Point(291, 107);
            this.Freq_Cal_Loose_button.Margin = new System.Windows.Forms.Padding(0);
            this.Freq_Cal_Loose_button.Name = "Freq_Cal_Loose_button";
            this.Freq_Cal_Loose_button.Size = new System.Drawing.Size(98, 27);
            this.Freq_Cal_Loose_button.TabIndex = 233;
            this.Freq_Cal_Loose_button.Text = "LOOSE";
            this.toolTip.SetToolTip(this.Freq_Cal_Loose_button, "CALIBRATION SENSITIVITY\r\nLOOSE - SIGNAL S5 OR BETTER (LESS ACCURATE)\r\nTIGHT -  SI" +
        "GNAL S7 OR BETTER (MOST ACCURATE)");
            this.Freq_Cal_Loose_button.UseVisualStyleBackColor = false;
            this.Freq_Cal_Loose_button.Click += new System.EventHandler(this.Freq_Cal_Loose_button_Click);
            // 
            // Adjust_PPM_Coarse_hScrollBar
            // 
            this.Adjust_PPM_Coarse_hScrollBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Adjust_PPM_Coarse_hScrollBar.Enabled = false;
            this.Adjust_PPM_Coarse_hScrollBar.LargeChange = 1;
            this.Adjust_PPM_Coarse_hScrollBar.Location = new System.Drawing.Point(261, 137);
            this.Adjust_PPM_Coarse_hScrollBar.Minimum = -100;
            this.Adjust_PPM_Coarse_hScrollBar.Name = "Adjust_PPM_Coarse_hScrollBar";
            this.Adjust_PPM_Coarse_hScrollBar.Size = new System.Drawing.Size(265, 18);
            this.Adjust_PPM_Coarse_hScrollBar.TabIndex = 232;
            this.toolTip.SetToolTip(this.Adjust_PPM_Coarse_hScrollBar, "COURSE MANUAL ADJUSTMENT");
            this.Adjust_PPM_Coarse_hScrollBar.Visible = false;
            this.Adjust_PPM_Coarse_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Adjust_PPM_Coarse_hScrollBar_Scroll);
            // 
            // Signal_Average_label
            // 
            this.Signal_Average_label.BackColor = System.Drawing.Color.Gainsboro;
            this.Signal_Average_label.ForeColor = System.Drawing.Color.Black;
            this.Signal_Average_label.Location = new System.Drawing.Point(543, 185);
            this.Signal_Average_label.Name = "Signal_Average_label";
            this.Signal_Average_label.Size = new System.Drawing.Size(52, 22);
            this.Signal_Average_label.TabIndex = 230;
            this.Signal_Average_label.Text = "S60";
            this.Signal_Average_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.Signal_Average_label, "SMETER AVERAGE READING\r\nRED - DO NOT ATTEMP AUTO CALIBRATION\r\nGREEN - OK FOR CALI" +
        "BRATION");
            this.Signal_Average_label.Click += new System.EventHandler(this.Signal_Average_label_Click);
            // 
            // Freq_Calibration_Status_label
            // 
            this.Freq_Calibration_Status_label.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Calibration_Status_label.ForeColor = System.Drawing.Color.Black;
            this.Freq_Calibration_Status_label.Location = new System.Drawing.Point(233, 18);
            this.Freq_Calibration_Status_label.Name = "Freq_Calibration_Status_label";
            this.Freq_Calibration_Status_label.Size = new System.Drawing.Size(321, 37);
            this.Freq_Calibration_Status_label.TabIndex = 224;
            this.Freq_Calibration_Status_label.Text = "CALIBRATION STATUS";
            this.Freq_Calibration_Status_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Freq_Calibration_Status_label.Click += new System.EventHandler(this.Freq_Calibration_Status_label_Click);
            // 
            // Freq_Auto_Calibrate_button
            // 
            this.Freq_Auto_Calibrate_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Auto_Calibrate_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Freq_Auto_Calibrate_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Auto_Calibrate_button.ForeColor = System.Drawing.Color.Black;
            this.Freq_Auto_Calibrate_button.Location = new System.Drawing.Point(188, 77);
            this.Freq_Auto_Calibrate_button.Margin = new System.Windows.Forms.Padding(0);
            this.Freq_Auto_Calibrate_button.Name = "Freq_Auto_Calibrate_button";
            this.Freq_Auto_Calibrate_button.Size = new System.Drawing.Size(201, 27);
            this.Freq_Auto_Calibrate_button.TabIndex = 223;
            this.Freq_Auto_Calibrate_button.Text = "AUTO CALIBRATE";
            this.Freq_Auto_Calibrate_button.UseVisualStyleBackColor = false;
            this.Freq_Auto_Calibrate_button.Click += new System.EventHandler(this.Freq_Auto_Calibrate_button_Click);
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(243, 208);
            this.label49.Margin = new System.Windows.Forms.Padding(0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(298, 20);
            this.label49.TabIndex = 222;
            this.label49.Text = "[S] 1  2  3  4  5  6  7  8  9  +10 +20 +30 +40 +60";
            // 
            // Freq_Cal_Meter
            // 
            this.Freq_Cal_Meter.AnalogMeter = false;
            this.Freq_Cal_Meter.BackColor = System.Drawing.Color.Moccasin;
            this.Freq_Cal_Meter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freq_Cal_Meter.DialBackground = System.Drawing.Color.Moccasin;
            this.Freq_Cal_Meter.DialTextNegative = System.Drawing.Color.Red;
            this.Freq_Cal_Meter.DialTextPositive = System.Drawing.Color.Black;
            this.Freq_Cal_Meter.DialTextZero = System.Drawing.Color.DarkGreen;
            this.Freq_Cal_Meter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Cal_Meter.Led1ColorOff = System.Drawing.Color.Snow;
            this.Freq_Cal_Meter.Led1ColorOn = System.Drawing.Color.Red;
            this.Freq_Cal_Meter.Led1Count = 10;
            this.Freq_Cal_Meter.Led2ColorOff = System.Drawing.Color.Snow;
            this.Freq_Cal_Meter.Led2ColorOn = System.Drawing.Color.Green;
            this.Freq_Cal_Meter.Led2Count = 16;
            this.Freq_Cal_Meter.Led3ColorOff = System.Drawing.Color.Snow;
            this.Freq_Cal_Meter.Led3ColorOn = System.Drawing.Color.Red;
            this.Freq_Cal_Meter.Led3Count = 0;
            this.Freq_Cal_Meter.LedSize = new System.Drawing.Size(10, 20);
            this.Freq_Cal_Meter.LedSpace = 1;
            this.Freq_Cal_Meter.Level = 0;
            this.Freq_Cal_Meter.LevelMax = 160;
            this.Freq_Cal_Meter.Location = new System.Drawing.Point(250, 185);
            this.Freq_Cal_Meter.MeterScale = VU_MeterLibrary.MeterScale.Analog;
            this.Freq_Cal_Meter.Name = "Freq_Cal_Meter";
            this.Freq_Cal_Meter.NeedleColor = System.Drawing.Color.Black;
            this.Freq_Cal_Meter.PeakHold = false;
            this.Freq_Cal_Meter.Peakms = 2000;
            this.Freq_Cal_Meter.PeakNeedleColor = System.Drawing.Color.Red;
            this.Freq_Cal_Meter.ShowDialOnly = false;
            this.Freq_Cal_Meter.ShowLedPeak = false;
            this.Freq_Cal_Meter.ShowTextInDial = true;
            this.Freq_Cal_Meter.Size = new System.Drawing.Size(287, 22);
            this.Freq_Cal_Meter.TabIndex = 221;
            this.Freq_Cal_Meter.TextInDial = new string[] {
        "[S]",
        "1",
        "3",
        "5",
        "7",
        "9",
        "+20",
        "+40",
        "+60"};
            this.Freq_Cal_Meter.UseLedLight = true;
            this.Freq_Cal_Meter.VerticalBar = false;
            this.Freq_Cal_Meter.VuText = "ALC";
            this.Freq_Cal_Meter.Load += new System.EventHandler(this.Freq_Cal_Meter_Load);
            // 
            // Set_Calibration_button
            // 
            this.Set_Calibration_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Set_Calibration_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set_Calibration_button.ForeColor = System.Drawing.Color.Black;
            this.Set_Calibration_button.Location = new System.Drawing.Point(398, 77);
            this.Set_Calibration_button.Name = "Set_Calibration_button";
            this.Set_Calibration_button.Size = new System.Drawing.Size(201, 27);
            this.Set_Calibration_button.TabIndex = 231;
            this.Set_Calibration_button.Text = "MANUAL CALIBRATE";
            this.toolTip.SetToolTip(this.Set_Calibration_button, "SET THE CALIBRATION MANUALLY");
            this.Set_Calibration_button.UseVisualStyleBackColor = false;
            this.Set_Calibration_button.Click += new System.EventHandler(this.Set_Calibration_button_Click);
            // 
            // Freq_CAl_Progress_Lable
            // 
            this.Freq_CAl_Progress_Lable.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_CAl_Progress_Lable.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_CAl_Progress_Lable.ForeColor = System.Drawing.Color.Black;
            this.Freq_CAl_Progress_Lable.Location = new System.Drawing.Point(368, 58);
            this.Freq_CAl_Progress_Lable.Name = "Freq_CAl_Progress_Lable";
            this.Freq_CAl_Progress_Lable.Size = new System.Drawing.Size(51, 16);
            this.Freq_CAl_Progress_Lable.TabIndex = 159;
            this.Freq_CAl_Progress_Lable.Text = "0";
            this.Freq_CAl_Progress_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Freq_CAl_Progress_Lable.Click += new System.EventHandler(this.Freq_CAl_Progress_Lable_Click);
            // 
            // Freq_Check_Button
            // 
            this.Freq_Check_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Check_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Freq_Check_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Check_Button.ForeColor = System.Drawing.Color.Black;
            this.Freq_Check_Button.Location = new System.Drawing.Point(398, 107);
            this.Freq_Check_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Freq_Check_Button.Name = "Freq_Check_Button";
            this.Freq_Check_Button.Size = new System.Drawing.Size(98, 27);
            this.Freq_Check_Button.TabIndex = 122;
            this.Freq_Check_Button.Text = "CHECK";
            this.toolTip.SetToolTip(this.Freq_Check_Button, "CHECK THE CURRENT CALIBRATION");
            this.Freq_Check_Button.UseVisualStyleBackColor = false;
            this.Freq_Check_Button.Click += new System.EventHandler(this.Freq_Check_Button_Click);
            // 
            // Freq_Cal_Reset_button4
            // 
            this.Freq_Cal_Reset_button4.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Cal_Reset_button4.Enabled = false;
            this.Freq_Cal_Reset_button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Freq_Cal_Reset_button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Cal_Reset_button4.ForeColor = System.Drawing.Color.Black;
            this.Freq_Cal_Reset_button4.Location = new System.Drawing.Point(40, 128);
            this.Freq_Cal_Reset_button4.Margin = new System.Windows.Forms.Padding(0);
            this.Freq_Cal_Reset_button4.Name = "Freq_Cal_Reset_button4";
            this.Freq_Cal_Reset_button4.Size = new System.Drawing.Size(98, 27);
            this.Freq_Cal_Reset_button4.TabIndex = 156;
            this.Freq_Cal_Reset_button4.Text = "DEFAULT";
            this.toolTip.SetToolTip(this.Freq_Cal_Reset_button4, "RESTORE CALIBRATION TO FACTORY DEFAULTS");
            this.Freq_Cal_Reset_button4.UseVisualStyleBackColor = false;
            this.Freq_Cal_Reset_button4.Visible = false;
            this.Freq_Cal_Reset_button4.Click += new System.EventHandler(this.Freq_Cal_Reset_button4_Click);
            // 
            // Calibration_progressBar1
            // 
            this.Calibration_progressBar1.BackColor = System.Drawing.Color.Gainsboro;
            this.Calibration_progressBar1.ForeColor = System.Drawing.Color.Red;
            this.Calibration_progressBar1.Location = new System.Drawing.Point(311, 58);
            this.Calibration_progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.Calibration_progressBar1.Name = "Calibration_progressBar1";
            this.Calibration_progressBar1.Size = new System.Drawing.Size(165, 18);
            this.Calibration_progressBar1.Step = 1;
            this.Calibration_progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Calibration_progressBar1.TabIndex = 119;
            this.Calibration_progressBar1.Click += new System.EventHandler(this.Calibration_progressBar1_Click);
            // 
            // IQ_groupBox3
            // 
            this.IQ_groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.IQ_groupBox3.Controls.Add(this.IQ_Image_meter);
            this.IQ_groupBox3.Controls.Add(this.IQ_RX_button);
            this.IQ_groupBox3.Controls.Add(this.Reset_Freq_button3);
            this.IQ_groupBox3.Controls.Add(this.IQ_UP24KHz_checkBox2);
            this.IQ_groupBox3.Controls.Add(this.IQ_Freq_hScrollBar1);
            this.IQ_groupBox3.Controls.Add(this.Cal_Freq_textBox2);
            this.IQ_groupBox3.Controls.Add(this.IQ_Reset_All_button2);
            this.IQ_groupBox3.Controls.Add(this.LeftResetbutton2);
            this.IQ_groupBox3.Controls.Add(this.LefthScrollBar1);
            this.IQ_groupBox3.Controls.Add(this.IQ_Commit_button2);
            this.IQ_groupBox3.Controls.Add(this.IQLefttextBox2);
            this.IQ_groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IQ_groupBox3.ForeColor = System.Drawing.Color.White;
            this.IQ_groupBox3.Location = new System.Drawing.Point(10, 284);
            this.IQ_groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.IQ_groupBox3.Name = "IQ_groupBox3";
            this.IQ_groupBox3.Size = new System.Drawing.Size(786, 187);
            this.IQ_groupBox3.TabIndex = 126;
            this.IQ_groupBox3.TabStop = false;
            this.IQ_groupBox3.Text = "RX I/Q CALIBRATION";
            this.IQ_groupBox3.Enter += new System.EventHandler(this.IQ_groupBox3_Enter);
            // 
            // IQ_Image_meter
            // 
            this.IQ_Image_meter.AnalogMeter = false;
            this.IQ_Image_meter.BackColor = System.Drawing.Color.Moccasin;
            this.IQ_Image_meter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IQ_Image_meter.DialBackground = System.Drawing.Color.Moccasin;
            this.IQ_Image_meter.DialTextNegative = System.Drawing.Color.Red;
            this.IQ_Image_meter.DialTextPositive = System.Drawing.Color.Black;
            this.IQ_Image_meter.DialTextZero = System.Drawing.Color.DarkGreen;
            this.IQ_Image_meter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQ_Image_meter.Led1ColorOff = System.Drawing.Color.Snow;
            this.IQ_Image_meter.Led1ColorOn = System.Drawing.Color.Red;
            this.IQ_Image_meter.Led1Count = 27;
            this.IQ_Image_meter.Led2ColorOff = System.Drawing.Color.Snow;
            this.IQ_Image_meter.Led2ColorOn = System.Drawing.Color.Green;
            this.IQ_Image_meter.Led2Count = 0;
            this.IQ_Image_meter.Led3ColorOff = System.Drawing.Color.Snow;
            this.IQ_Image_meter.Led3ColorOn = System.Drawing.Color.Red;
            this.IQ_Image_meter.Led3Count = 0;
            this.IQ_Image_meter.LedSize = new System.Drawing.Size(10, 20);
            this.IQ_Image_meter.LedSpace = 1;
            this.IQ_Image_meter.Level = 0;
            this.IQ_Image_meter.LevelMax = 160;
            this.IQ_Image_meter.Location = new System.Drawing.Point(243, 103);
            this.IQ_Image_meter.MeterScale = VU_MeterLibrary.MeterScale.Analog;
            this.IQ_Image_meter.Name = "IQ_Image_meter";
            this.IQ_Image_meter.NeedleColor = System.Drawing.Color.Black;
            this.IQ_Image_meter.PeakHold = false;
            this.IQ_Image_meter.Peakms = 2000;
            this.IQ_Image_meter.PeakNeedleColor = System.Drawing.Color.Red;
            this.IQ_Image_meter.ShowDialOnly = false;
            this.IQ_Image_meter.ShowLedPeak = false;
            this.IQ_Image_meter.ShowTextInDial = true;
            this.IQ_Image_meter.Size = new System.Drawing.Size(298, 22);
            this.IQ_Image_meter.TabIndex = 184;
            this.IQ_Image_meter.TextInDial = new string[] {
        "[S]",
        "1",
        "3",
        "5",
        "7",
        "9",
        "+20",
        "+40",
        "+60"};
            this.IQ_Image_meter.UseLedLight = true;
            this.IQ_Image_meter.VerticalBar = false;
            this.IQ_Image_meter.Visible = false;
            this.IQ_Image_meter.VuText = "ALC";
            this.IQ_Image_meter.Load += new System.EventHandler(this.IQ_Image_meter_Load);
            // 
            // IQ_RX_button
            // 
            this.IQ_RX_button.BackColor = System.Drawing.Color.Gainsboro;
            this.IQ_RX_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQ_RX_button.ForeColor = System.Drawing.Color.Black;
            this.IQ_RX_button.Location = new System.Drawing.Point(344, 25);
            this.IQ_RX_button.Name = "IQ_RX_button";
            this.IQ_RX_button.Size = new System.Drawing.Size(98, 26);
            this.IQ_RX_button.TabIndex = 119;
            this.IQ_RX_button.Text = "RX I/Q";
            this.IQ_RX_button.UseVisualStyleBackColor = false;
            this.IQ_RX_button.Click += new System.EventHandler(this.IQ_RX_button_Click);
            // 
            // Reset_Freq_button3
            // 
            this.Reset_Freq_button3.BackColor = System.Drawing.Color.Gainsboro;
            this.Reset_Freq_button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Freq_button3.ForeColor = System.Drawing.Color.Black;
            this.Reset_Freq_button3.Location = new System.Drawing.Point(73, 77);
            this.Reset_Freq_button3.Name = "Reset_Freq_button3";
            this.Reset_Freq_button3.Size = new System.Drawing.Size(142, 26);
            this.Reset_Freq_button3.TabIndex = 143;
            this.Reset_Freq_button3.Text = "RESET FREQ";
            this.Reset_Freq_button3.UseVisualStyleBackColor = false;
            this.Reset_Freq_button3.Visible = false;
            this.Reset_Freq_button3.Click += new System.EventHandler(this.Reset_Freq_button3_Click);
            // 
            // IQ_UP24KHz_checkBox2
            // 
            this.IQ_UP24KHz_checkBox2.AutoSize = true;
            this.IQ_UP24KHz_checkBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.IQ_UP24KHz_checkBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQ_UP24KHz_checkBox2.ForeColor = System.Drawing.Color.Black;
            this.IQ_UP24KHz_checkBox2.Location = new System.Drawing.Point(343, 77);
            this.IQ_UP24KHz_checkBox2.Name = "IQ_UP24KHz_checkBox2";
            this.IQ_UP24KHz_checkBox2.Size = new System.Drawing.Size(86, 22);
            this.IQ_UP24KHz_checkBox2.TabIndex = 142;
            this.IQ_UP24KHz_checkBox2.Text = "IMAGE";
            this.IQ_UP24KHz_checkBox2.UseVisualStyleBackColor = false;
            this.IQ_UP24KHz_checkBox2.Visible = false;
            this.IQ_UP24KHz_checkBox2.CheckedChanged += new System.EventHandler(this.IQ_UP24KHz_checkBox2_CheckedChanged);
            // 
            // IQ_Freq_hScrollBar1
            // 
            this.IQ_Freq_hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.IQ_Freq_hScrollBar1.Location = new System.Drawing.Point(73, 55);
            this.IQ_Freq_hScrollBar1.Maximum = 2009;
            this.IQ_Freq_hScrollBar1.Minimum = -1000;
            this.IQ_Freq_hScrollBar1.Name = "IQ_Freq_hScrollBar1";
            this.IQ_Freq_hScrollBar1.Size = new System.Drawing.Size(627, 18);
            this.IQ_Freq_hScrollBar1.TabIndex = 127;
            this.IQ_Freq_hScrollBar1.Visible = false;
            this.IQ_Freq_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.IQ_Freq_hScrollBar1_Scroll);
            // 
            // Cal_Freq_textBox2
            // 
            this.Cal_Freq_textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.Cal_Freq_textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cal_Freq_textBox2.ForeColor = System.Drawing.Color.Black;
            this.Cal_Freq_textBox2.Location = new System.Drawing.Point(328, 26);
            this.Cal_Freq_textBox2.Name = "Cal_Freq_textBox2";
            this.Cal_Freq_textBox2.ReadOnly = true;
            this.Cal_Freq_textBox2.Size = new System.Drawing.Size(131, 27);
            this.Cal_Freq_textBox2.TabIndex = 126;
            this.Cal_Freq_textBox2.Text = "30000000";
            this.Cal_Freq_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cal_Freq_textBox2.Visible = false;
            this.Cal_Freq_textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // IQ_Reset_All_button2
            // 
            this.IQ_Reset_All_button2.BackColor = System.Drawing.Color.Gainsboro;
            this.IQ_Reset_All_button2.ForeColor = System.Drawing.Color.Black;
            this.IQ_Reset_All_button2.Location = new System.Drawing.Point(558, 150);
            this.IQ_Reset_All_button2.Name = "IQ_Reset_All_button2";
            this.IQ_Reset_All_button2.Size = new System.Drawing.Size(142, 26);
            this.IQ_Reset_All_button2.TabIndex = 125;
            this.IQ_Reset_All_button2.Text = "DEFAULT I/Q ";
            this.IQ_Reset_All_button2.UseVisualStyleBackColor = false;
            this.IQ_Reset_All_button2.Visible = false;
            this.IQ_Reset_All_button2.Click += new System.EventHandler(this.IQ_Reset_All_button2_Click);
            // 
            // LeftResetbutton2
            // 
            this.LeftResetbutton2.BackColor = System.Drawing.Color.Gainsboro;
            this.LeftResetbutton2.ForeColor = System.Drawing.Color.Black;
            this.LeftResetbutton2.Location = new System.Drawing.Point(73, 152);
            this.LeftResetbutton2.Name = "LeftResetbutton2";
            this.LeftResetbutton2.Size = new System.Drawing.Size(142, 26);
            this.LeftResetbutton2.TabIndex = 115;
            this.LeftResetbutton2.Text = "RESET I/Q";
            this.LeftResetbutton2.UseVisualStyleBackColor = false;
            this.LeftResetbutton2.Visible = false;
            this.LeftResetbutton2.Click += new System.EventHandler(this.LeftResetbutton2_Click_1);
            // 
            // LefthScrollBar1
            // 
            this.LefthScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LefthScrollBar1.Location = new System.Drawing.Point(73, 129);
            this.LefthScrollBar1.Maximum = 209;
            this.LefthScrollBar1.Minimum = -200;
            this.LefthScrollBar1.Name = "LefthScrollBar1";
            this.LefthScrollBar1.Size = new System.Drawing.Size(627, 18);
            this.LefthScrollBar1.TabIndex = 114;
            this.LefthScrollBar1.Visible = false;
            this.LefthScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LefthScrollBar1_Scroll_1);
            // 
            // IQ_Commit_button2
            // 
            this.IQ_Commit_button2.BackColor = System.Drawing.Color.Gainsboro;
            this.IQ_Commit_button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQ_Commit_button2.ForeColor = System.Drawing.Color.Black;
            this.IQ_Commit_button2.Location = new System.Drawing.Point(558, 76);
            this.IQ_Commit_button2.Name = "IQ_Commit_button2";
            this.IQ_Commit_button2.Size = new System.Drawing.Size(142, 26);
            this.IQ_Commit_button2.TabIndex = 113;
            this.IQ_Commit_button2.Text = "APPLY";
            this.IQ_Commit_button2.UseVisualStyleBackColor = false;
            this.IQ_Commit_button2.Visible = false;
            this.IQ_Commit_button2.Click += new System.EventHandler(this.IQ_Commit_button2_Click_1);
            // 
            // IQLefttextBox2
            // 
            this.IQLefttextBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.IQLefttextBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQLefttextBox2.ForeColor = System.Drawing.Color.Black;
            this.IQLefttextBox2.Location = new System.Drawing.Point(310, 151);
            this.IQLefttextBox2.Name = "IQLefttextBox2";
            this.IQLefttextBox2.ReadOnly = true;
            this.IQLefttextBox2.Size = new System.Drawing.Size(142, 27);
            this.IQLefttextBox2.TabIndex = 110;
            this.IQLefttextBox2.Text = "0";
            this.IQLefttextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IQLefttextBox2.Visible = false;
            this.IQLefttextBox2.TextChanged += new System.EventHandler(this.IQLefttextBox2_TextChanged_1);
            // 
            // powertabPage1
            // 
            this.powertabPage1.BackColor = System.Drawing.Color.Black;
            this.powertabPage1.Controls.Add(this.AMP_groupBox3);
            this.powertabPage1.Controls.Add(this.Proficio_Band_Cal_groupBox);
            this.powertabPage1.Controls.Add(this.Proficio_Calibrate_button8);
            this.powertabPage1.Controls.Add(this.Transceiver_Calibrate_groupBox);
            this.powertabPage1.ForeColor = System.Drawing.Color.Black;
            this.powertabPage1.Location = new System.Drawing.Point(4, 24);
            this.powertabPage1.Name = "powertabPage1";
            this.powertabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.powertabPage1.Size = new System.Drawing.Size(806, 481);
            this.powertabPage1.TabIndex = 3;
            this.powertabPage1.Text = "   Pwr Cal   ";
            this.powertabPage1.ToolTipText = "PROFICIO POWER CALIBRATION";
            this.powertabPage1.Click += new System.EventHandler(this.powertabPage1_Click);
            this.powertabPage1.Enter += new System.EventHandler(this.powertabPage1_Enter);
            this.powertabPage1.Leave += new System.EventHandler(this.powertabPage1_Leave);
            // 
            // AMP_groupBox3
            // 
            this.AMP_groupBox3.Controls.Add(this.PA_Calibrate_button);
            this.AMP_groupBox3.Controls.Add(this.PA_hScrollBar);
            this.AMP_groupBox3.Controls.Add(this.PA_Power_Limit_button);
            this.AMP_groupBox3.Controls.Add(this.PA_TX_button8);
            this.AMP_groupBox3.Controls.Add(this.Calibration_Band_button8);
            this.AMP_groupBox3.Controls.Add(this.PA_Reset_button8);
            this.AMP_groupBox3.Controls.Add(this.Solidus_Fan_On_Temperature_button8);
            this.AMP_groupBox3.Controls.Add(this.Fan_Control_button8);
            this.AMP_groupBox3.Controls.Add(this.Solidus_Bias_button8);
            this.AMP_groupBox3.Controls.Add(this.label32);
            this.AMP_groupBox3.Controls.Add(this.Power_calibration_label58);
            this.AMP_groupBox3.Controls.Add(this.AMP_Raw_Bias_label5);
            this.AMP_groupBox3.Controls.Add(this.AMP_Temp_MFC_AMP_label5);
            this.AMP_groupBox3.Controls.Add(this.AMP_label57);
            this.AMP_groupBox3.Enabled = false;
            this.AMP_groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMP_groupBox3.ForeColor = System.Drawing.Color.White;
            this.AMP_groupBox3.Location = new System.Drawing.Point(3, 285);
            this.AMP_groupBox3.Name = "AMP_groupBox3";
            this.AMP_groupBox3.Size = new System.Drawing.Size(776, 146);
            this.AMP_groupBox3.TabIndex = 203;
            this.AMP_groupBox3.TabStop = false;
            this.AMP_groupBox3.Text = "POWER AMPLIFIER";
            this.AMP_groupBox3.Enter += new System.EventHandler(this.AMP_groupBox3_Enter);
            // 
            // PA_Calibrate_button
            // 
            this.PA_Calibrate_button.BackColor = System.Drawing.Color.Gainsboro;
            this.PA_Calibrate_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA_Calibrate_button.ForeColor = System.Drawing.Color.Black;
            this.PA_Calibrate_button.Location = new System.Drawing.Point(310, 14);
            this.PA_Calibrate_button.Name = "PA_Calibrate_button";
            this.PA_Calibrate_button.Size = new System.Drawing.Size(147, 27);
            this.PA_Calibrate_button.TabIndex = 205;
            this.PA_Calibrate_button.Text = "CALIBRATE";
            this.toolTip.SetToolTip(this.PA_Calibrate_button, "ENABLE CALIBRATION");
            this.PA_Calibrate_button.UseVisualStyleBackColor = false;
            this.PA_Calibrate_button.Click += new System.EventHandler(this.PA_Calibrate_button_Click);
            // 
            // PA_hScrollBar
            // 
            this.PA_hScrollBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.PA_hScrollBar.LargeChange = 5;
            this.PA_hScrollBar.Location = new System.Drawing.Point(278, 78);
            this.PA_hScrollBar.Maximum = 0;
            this.PA_hScrollBar.Minimum = -99;
            this.PA_hScrollBar.Name = "PA_hScrollBar";
            this.PA_hScrollBar.Size = new System.Drawing.Size(221, 15);
            this.PA_hScrollBar.TabIndex = 206;
            this.toolTip.SetToolTip(this.PA_hScrollBar, "ADJUST SLIDER FOR CALIBRATION POWER OUTPUT.");
            this.PA_hScrollBar.Value = -99;
            this.PA_hScrollBar.Visible = false;
            this.PA_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PA_hScrollBar_Scroll);
            // 
            // PA_Power_Limit_button
            // 
            this.PA_Power_Limit_button.BackColor = System.Drawing.Color.Gainsboro;
            this.PA_Power_Limit_button.Enabled = false;
            this.PA_Power_Limit_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA_Power_Limit_button.ForeColor = System.Drawing.Color.Black;
            this.PA_Power_Limit_button.Location = new System.Drawing.Point(595, 104);
            this.PA_Power_Limit_button.Name = "PA_Power_Limit_button";
            this.PA_Power_Limit_button.Size = new System.Drawing.Size(90, 27);
            this.PA_Power_Limit_button.TabIndex = 205;
            this.PA_Power_Limit_button.Text = "50";
            this.toolTip.SetToolTip(this.PA_Power_Limit_button, "SET AUTO CALIBRATION POWER LIMIT.\r\nPOTENTIA 50 - 50 WATTS.\r\nPOTENTIA 100 - 100 WA" +
        "TTS.");
            this.PA_Power_Limit_button.UseVisualStyleBackColor = false;
            this.PA_Power_Limit_button.Visible = false;
            this.PA_Power_Limit_button.Click += new System.EventHandler(this.PA_Power_Limit_button_Click);
            // 
            // PA_TX_button8
            // 
            this.PA_TX_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.PA_TX_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PA_TX_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA_TX_button8.ForeColor = System.Drawing.Color.Black;
            this.PA_TX_button8.Location = new System.Drawing.Point(446, 44);
            this.PA_TX_button8.Name = "PA_TX_button8";
            this.PA_TX_button8.Size = new System.Drawing.Size(99, 27);
            this.PA_TX_button8.TabIndex = 200;
            this.PA_TX_button8.Text = "TX";
            this.toolTip.SetToolTip(this.PA_TX_button8, "SET TUNE ON.");
            this.PA_TX_button8.UseVisualStyleBackColor = false;
            this.PA_TX_button8.Click += new System.EventHandler(this.PA_TX_button8_Click);
            // 
            // Calibration_Band_button8
            // 
            this.Calibration_Band_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Calibration_Band_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calibration_Band_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calibration_Band_button8.ForeColor = System.Drawing.Color.Black;
            this.Calibration_Band_button8.Location = new System.Drawing.Point(299, 102);
            this.Calibration_Band_button8.Name = "Calibration_Band_button8";
            this.Calibration_Band_button8.Size = new System.Drawing.Size(178, 26);
            this.Calibration_Band_button8.TabIndex = 197;
            this.Calibration_Band_button8.Text = "SELECT BAND";
            this.toolTip.SetToolTip(this.Calibration_Band_button8, "SELECT CALIBRATION BAND.");
            this.Calibration_Band_button8.UseVisualStyleBackColor = false;
            this.Calibration_Band_button8.Click += new System.EventHandler(this.Calibration_Band_button8_Click);
            // 
            // PA_Reset_button8
            // 
            this.PA_Reset_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.PA_Reset_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA_Reset_button8.ForeColor = System.Drawing.Color.Black;
            this.PA_Reset_button8.Location = new System.Drawing.Point(231, 44);
            this.PA_Reset_button8.Name = "PA_Reset_button8";
            this.PA_Reset_button8.Size = new System.Drawing.Size(99, 27);
            this.PA_Reset_button8.TabIndex = 199;
            this.PA_Reset_button8.Text = "RESET";
            this.toolTip.SetToolTip(this.PA_Reset_button8, "RESET CALIBRATION VALUES\r\nTO FACTORY DEFAULTS\r\nFOR ALL BANDS.\r\n\r\n");
            this.PA_Reset_button8.UseVisualStyleBackColor = false;
            this.PA_Reset_button8.Click += new System.EventHandler(this.PA_Reset_button8_Click);
            // 
            // Solidus_Fan_On_Temperature_button8
            // 
            this.Solidus_Fan_On_Temperature_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Solidus_Fan_On_Temperature_button8.Enabled = false;
            this.Solidus_Fan_On_Temperature_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Solidus_Fan_On_Temperature_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solidus_Fan_On_Temperature_button8.ForeColor = System.Drawing.Color.Black;
            this.Solidus_Fan_On_Temperature_button8.Location = new System.Drawing.Point(623, 99);
            this.Solidus_Fan_On_Temperature_button8.Name = "Solidus_Fan_On_Temperature_button8";
            this.Solidus_Fan_On_Temperature_button8.Size = new System.Drawing.Size(103, 26);
            this.Solidus_Fan_On_Temperature_button8.TabIndex = 197;
            this.Solidus_Fan_On_Temperature_button8.Text = "FAN: 30°";
            this.Solidus_Fan_On_Temperature_button8.UseVisualStyleBackColor = false;
            this.Solidus_Fan_On_Temperature_button8.Visible = false;
            this.Solidus_Fan_On_Temperature_button8.Click += new System.EventHandler(this.Solidus_Fan_On_Temperature_button8_Click);
            // 
            // Fan_Control_button8
            // 
            this.Fan_Control_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Fan_Control_button8.Enabled = false;
            this.Fan_Control_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fan_Control_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fan_Control_button8.ForeColor = System.Drawing.Color.Black;
            this.Fan_Control_button8.Location = new System.Drawing.Point(112, 67);
            this.Fan_Control_button8.Name = "Fan_Control_button8";
            this.Fan_Control_button8.Size = new System.Drawing.Size(103, 26);
            this.Fan_Control_button8.TabIndex = 196;
            this.Fan_Control_button8.Text = "PWM OFF";
            this.Fan_Control_button8.UseVisualStyleBackColor = false;
            this.Fan_Control_button8.Visible = false;
            this.Fan_Control_button8.Click += new System.EventHandler(this.Fan_Control_button8_Click);
            // 
            // Solidus_Bias_button8
            // 
            this.Solidus_Bias_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Solidus_Bias_button8.Enabled = false;
            this.Solidus_Bias_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solidus_Bias_button8.ForeColor = System.Drawing.Color.Black;
            this.Solidus_Bias_button8.Location = new System.Drawing.Point(16, 23);
            this.Solidus_Bias_button8.Name = "Solidus_Bias_button8";
            this.Solidus_Bias_button8.Size = new System.Drawing.Size(90, 27);
            this.Solidus_Bias_button8.TabIndex = 186;
            this.Solidus_Bias_button8.Text = "BIAS";
            this.Solidus_Bias_button8.UseVisualStyleBackColor = false;
            this.Solidus_Bias_button8.Visible = false;
            this.Solidus_Bias_button8.Click += new System.EventHandler(this.Solidus_Bias_button8_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Enabled = false;
            this.label32.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(592, 27);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(165, 18);
            this.label32.TabIndex = 195;
            this.label32.Text = "PA FAN CONTROL";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label32.Visible = false;
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // Power_calibration_label58
            // 
            this.Power_calibration_label58.BackColor = System.Drawing.Color.Gainsboro;
            this.Power_calibration_label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Power_calibration_label58.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Power_calibration_label58.ForeColor = System.Drawing.Color.Black;
            this.Power_calibration_label58.Location = new System.Drawing.Point(343, 44);
            this.Power_calibration_label58.Name = "Power_calibration_label58";
            this.Power_calibration_label58.Size = new System.Drawing.Size(90, 27);
            this.Power_calibration_label58.TabIndex = 151;
            this.Power_calibration_label58.Text = "STEP: 0";
            this.Power_calibration_label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.Power_calibration_label58, "POWER CALIBRATION STEP");
            this.Power_calibration_label58.Click += new System.EventHandler(this.Power_calibration_label58_Click);
            // 
            // AMP_Raw_Bias_label5
            // 
            this.AMP_Raw_Bias_label5.BackColor = System.Drawing.Color.Gainsboro;
            this.AMP_Raw_Bias_label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AMP_Raw_Bias_label5.Enabled = false;
            this.AMP_Raw_Bias_label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMP_Raw_Bias_label5.ForeColor = System.Drawing.Color.Black;
            this.AMP_Raw_Bias_label5.Location = new System.Drawing.Point(588, 57);
            this.AMP_Raw_Bias_label5.Name = "AMP_Raw_Bias_label5";
            this.AMP_Raw_Bias_label5.Size = new System.Drawing.Size(180, 23);
            this.AMP_Raw_Bias_label5.TabIndex = 170;
            this.AMP_Raw_Bias_label5.Text = "BIAS I (ma):  00000 ";
            this.AMP_Raw_Bias_label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AMP_Raw_Bias_label5.Visible = false;
            this.AMP_Raw_Bias_label5.Click += new System.EventHandler(this.AMP_Raw_Bias_label5_Click);
            // 
            // AMP_Temp_MFC_AMP_label5
            // 
            this.AMP_Temp_MFC_AMP_label5.BackColor = System.Drawing.Color.Gainsboro;
            this.AMP_Temp_MFC_AMP_label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AMP_Temp_MFC_AMP_label5.Enabled = false;
            this.AMP_Temp_MFC_AMP_label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMP_Temp_MFC_AMP_label5.ForeColor = System.Drawing.Color.Black;
            this.AMP_Temp_MFC_AMP_label5.Location = new System.Drawing.Point(16, 102);
            this.AMP_Temp_MFC_AMP_label5.Name = "AMP_Temp_MFC_AMP_label5";
            this.AMP_Temp_MFC_AMP_label5.Size = new System.Drawing.Size(180, 23);
            this.AMP_Temp_MFC_AMP_label5.TabIndex = 156;
            this.AMP_Temp_MFC_AMP_label5.Text = "PA: 0";
            this.AMP_Temp_MFC_AMP_label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AMP_Temp_MFC_AMP_label5.Visible = false;
            this.AMP_Temp_MFC_AMP_label5.Click += new System.EventHandler(this.AMP_Temp_MFC_AMP_label5_Click);
            // 
            // AMP_label57
            // 
            this.AMP_label57.BackColor = System.Drawing.Color.Gainsboro;
            this.AMP_label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AMP_label57.Enabled = false;
            this.AMP_label57.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMP_label57.ForeColor = System.Drawing.Color.Black;
            this.AMP_label57.Location = new System.Drawing.Point(16, 59);
            this.AMP_label57.Name = "AMP_label57";
            this.AMP_label57.Size = new System.Drawing.Size(90, 27);
            this.AMP_label57.TabIndex = 142;
            this.AMP_label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AMP_label57.Visible = false;
            this.AMP_label57.Click += new System.EventHandler(this.AMP_label57_Click);
            // 
            // Proficio_Band_Cal_groupBox
            // 
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Geminus_Band_Calibrated_630_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Geminus_Band_Calibrated_2200_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.B630_Calibration_Status_label);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.B2200_Calibration_Status_label);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.label48);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.label47);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.label44);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.label42);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.label41);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.label40);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.label38);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.label31);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.label30);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.label9);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Proficio_Band_Calibrated_10_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Proficio_Band_Calibrated_12_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Proficio_Band_Calibrated_15_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Proficio_Band_Calibrated_17_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Proficio_Band_Calibrated_20_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Proficio_Band_Calibrated_30_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Proficio_Band_Calibrated_40_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Proficio_Band_Calibrated_60_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Proficio_Band_Calibrated_80_button);
            this.Proficio_Band_Cal_groupBox.Controls.Add(this.Proficio_Band_Calibrated_160_button);
            this.Proficio_Band_Cal_groupBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Cal_groupBox.ForeColor = System.Drawing.Color.White;
            this.Proficio_Band_Cal_groupBox.Location = new System.Drawing.Point(65, 21);
            this.Proficio_Band_Cal_groupBox.Name = "Proficio_Band_Cal_groupBox";
            this.Proficio_Band_Cal_groupBox.Size = new System.Drawing.Size(663, 80);
            this.Proficio_Band_Cal_groupBox.TabIndex = 200;
            this.Proficio_Band_Cal_groupBox.TabStop = false;
            this.Proficio_Band_Cal_groupBox.Text = "CALIBRATION STATUS";
            // 
            // Geminus_Band_Calibrated_630_button
            // 
            this.Geminus_Band_Calibrated_630_button.BackColor = System.Drawing.Color.White;
            this.Geminus_Band_Calibrated_630_button.Enabled = false;
            this.Geminus_Band_Calibrated_630_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Geminus_Band_Calibrated_630_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geminus_Band_Calibrated_630_button.ForeColor = System.Drawing.Color.Black;
            this.Geminus_Band_Calibrated_630_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Geminus_Band_Calibrated_630_button.Location = new System.Drawing.Point(336, 59);
            this.Geminus_Band_Calibrated_630_button.Name = "Geminus_Band_Calibrated_630_button";
            this.Geminus_Band_Calibrated_630_button.Size = new System.Drawing.Size(13, 13);
            this.Geminus_Band_Calibrated_630_button.TabIndex = 221;
            this.Geminus_Band_Calibrated_630_button.UseVisualStyleBackColor = false;
            this.Geminus_Band_Calibrated_630_button.Visible = false;
            this.Geminus_Band_Calibrated_630_button.Click += new System.EventHandler(this.Geminus_Band_Calibrated_630_button_Click);
            // 
            // Geminus_Band_Calibrated_2200_button
            // 
            this.Geminus_Band_Calibrated_2200_button.BackColor = System.Drawing.Color.White;
            this.Geminus_Band_Calibrated_2200_button.Enabled = false;
            this.Geminus_Band_Calibrated_2200_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Geminus_Band_Calibrated_2200_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geminus_Band_Calibrated_2200_button.ForeColor = System.Drawing.Color.Black;
            this.Geminus_Band_Calibrated_2200_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Geminus_Band_Calibrated_2200_button.Location = new System.Drawing.Point(250, 59);
            this.Geminus_Band_Calibrated_2200_button.Name = "Geminus_Band_Calibrated_2200_button";
            this.Geminus_Band_Calibrated_2200_button.Size = new System.Drawing.Size(13, 13);
            this.Geminus_Band_Calibrated_2200_button.TabIndex = 220;
            this.Geminus_Band_Calibrated_2200_button.UseVisualStyleBackColor = false;
            this.Geminus_Band_Calibrated_2200_button.Visible = false;
            this.Geminus_Band_Calibrated_2200_button.Click += new System.EventHandler(this.Geminus_Band_Calibrated_2200_button_Click);
            // 
            // B630_Calibration_Status_label
            // 
            this.B630_Calibration_Status_label.AutoSize = true;
            this.B630_Calibration_Status_label.Location = new System.Drawing.Point(357, 54);
            this.B630_Calibration_Status_label.Name = "B630_Calibration_Status_label";
            this.B630_Calibration_Status_label.Size = new System.Drawing.Size(56, 18);
            this.B630_Calibration_Status_label.TabIndex = 219;
            this.B630_Calibration_Status_label.Text = "630M";
            this.B630_Calibration_Status_label.Visible = false;
            this.B630_Calibration_Status_label.Click += new System.EventHandler(this.B630_Calibration_Status_label_Click);
            // 
            // B2200_Calibration_Status_label
            // 
            this.B2200_Calibration_Status_label.AutoSize = true;
            this.B2200_Calibration_Status_label.Location = new System.Drawing.Point(269, 54);
            this.B2200_Calibration_Status_label.Name = "B2200_Calibration_Status_label";
            this.B2200_Calibration_Status_label.Size = new System.Drawing.Size(67, 18);
            this.B2200_Calibration_Status_label.TabIndex = 218;
            this.B2200_Calibration_Status_label.Text = "2200M";
            this.B2200_Calibration_Status_label.Visible = false;
            this.B2200_Calibration_Status_label.Click += new System.EventHandler(this.B2200_Calibration_Status_label_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(603, 26);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(45, 18);
            this.label48.TabIndex = 217;
            this.label48.Text = "10M";
            this.label48.Click += new System.EventHandler(this.label48_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(541, 26);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(45, 18);
            this.label47.TabIndex = 216;
            this.label47.Text = "12M";
            this.label47.Click += new System.EventHandler(this.label47_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(479, 26);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(45, 18);
            this.label44.TabIndex = 215;
            this.label44.Text = "15M";
            this.label44.Click += new System.EventHandler(this.label44_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(417, 26);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(45, 18);
            this.label42.TabIndex = 214;
            this.label42.Text = "17M";
            this.label42.Click += new System.EventHandler(this.label42_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(355, 26);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(45, 18);
            this.label41.TabIndex = 213;
            this.label41.Text = "20M";
            this.label41.Click += new System.EventHandler(this.label41_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(293, 26);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(45, 18);
            this.label40.TabIndex = 212;
            this.label40.Text = "30M";
            this.label40.Click += new System.EventHandler(this.label40_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(231, 26);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(45, 18);
            this.label38.TabIndex = 211;
            this.label38.Text = "40M";
            this.label38.Click += new System.EventHandler(this.label38_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(169, 26);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(45, 18);
            this.label31.TabIndex = 210;
            this.label31.Text = "60M";
            this.label31.Click += new System.EventHandler(this.label31_Click_1);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(107, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(45, 18);
            this.label30.TabIndex = 209;
            this.label30.Text = "80M";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 201;
            this.label9.Text = "160M";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Proficio_Band_Calibrated_10_button
            // 
            this.Proficio_Band_Calibrated_10_button.BackColor = System.Drawing.Color.White;
            this.Proficio_Band_Calibrated_10_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proficio_Band_Calibrated_10_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Calibrated_10_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Band_Calibrated_10_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Proficio_Band_Calibrated_10_button.Location = new System.Drawing.Point(586, 29);
            this.Proficio_Band_Calibrated_10_button.Name = "Proficio_Band_Calibrated_10_button";
            this.Proficio_Band_Calibrated_10_button.Size = new System.Drawing.Size(13, 13);
            this.Proficio_Band_Calibrated_10_button.TabIndex = 208;
            this.Proficio_Band_Calibrated_10_button.UseVisualStyleBackColor = false;
            this.Proficio_Band_Calibrated_10_button.Click += new System.EventHandler(this.button17_Click);
            // 
            // Proficio_Band_Calibrated_12_button
            // 
            this.Proficio_Band_Calibrated_12_button.BackColor = System.Drawing.Color.White;
            this.Proficio_Band_Calibrated_12_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proficio_Band_Calibrated_12_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Calibrated_12_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Band_Calibrated_12_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Proficio_Band_Calibrated_12_button.Location = new System.Drawing.Point(524, 29);
            this.Proficio_Band_Calibrated_12_button.Name = "Proficio_Band_Calibrated_12_button";
            this.Proficio_Band_Calibrated_12_button.Size = new System.Drawing.Size(13, 13);
            this.Proficio_Band_Calibrated_12_button.TabIndex = 207;
            this.Proficio_Band_Calibrated_12_button.UseVisualStyleBackColor = false;
            this.Proficio_Band_Calibrated_12_button.Click += new System.EventHandler(this.Proficio_Band_Calibrated_12_button_Click);
            // 
            // Proficio_Band_Calibrated_15_button
            // 
            this.Proficio_Band_Calibrated_15_button.BackColor = System.Drawing.Color.White;
            this.Proficio_Band_Calibrated_15_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proficio_Band_Calibrated_15_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Calibrated_15_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Band_Calibrated_15_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Proficio_Band_Calibrated_15_button.Location = new System.Drawing.Point(462, 29);
            this.Proficio_Band_Calibrated_15_button.Name = "Proficio_Band_Calibrated_15_button";
            this.Proficio_Band_Calibrated_15_button.Size = new System.Drawing.Size(13, 13);
            this.Proficio_Band_Calibrated_15_button.TabIndex = 206;
            this.Proficio_Band_Calibrated_15_button.UseVisualStyleBackColor = false;
            this.Proficio_Band_Calibrated_15_button.Click += new System.EventHandler(this.Proficio_Band_Calibrated_15_button_Click);
            // 
            // Proficio_Band_Calibrated_17_button
            // 
            this.Proficio_Band_Calibrated_17_button.BackColor = System.Drawing.Color.White;
            this.Proficio_Band_Calibrated_17_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proficio_Band_Calibrated_17_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Calibrated_17_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Band_Calibrated_17_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Proficio_Band_Calibrated_17_button.Location = new System.Drawing.Point(400, 29);
            this.Proficio_Band_Calibrated_17_button.Name = "Proficio_Band_Calibrated_17_button";
            this.Proficio_Band_Calibrated_17_button.Size = new System.Drawing.Size(13, 13);
            this.Proficio_Band_Calibrated_17_button.TabIndex = 205;
            this.Proficio_Band_Calibrated_17_button.UseVisualStyleBackColor = false;
            this.Proficio_Band_Calibrated_17_button.Click += new System.EventHandler(this.Proficio_Band_Calibrated_17_button_Click);
            // 
            // Proficio_Band_Calibrated_20_button
            // 
            this.Proficio_Band_Calibrated_20_button.BackColor = System.Drawing.Color.White;
            this.Proficio_Band_Calibrated_20_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proficio_Band_Calibrated_20_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Calibrated_20_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Band_Calibrated_20_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Proficio_Band_Calibrated_20_button.Location = new System.Drawing.Point(338, 29);
            this.Proficio_Band_Calibrated_20_button.Name = "Proficio_Band_Calibrated_20_button";
            this.Proficio_Band_Calibrated_20_button.Size = new System.Drawing.Size(13, 13);
            this.Proficio_Band_Calibrated_20_button.TabIndex = 204;
            this.Proficio_Band_Calibrated_20_button.UseVisualStyleBackColor = false;
            this.Proficio_Band_Calibrated_20_button.Click += new System.EventHandler(this.Proficio_Band_Calibrated_20_button_Click);
            // 
            // Proficio_Band_Calibrated_30_button
            // 
            this.Proficio_Band_Calibrated_30_button.BackColor = System.Drawing.Color.White;
            this.Proficio_Band_Calibrated_30_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proficio_Band_Calibrated_30_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Calibrated_30_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Band_Calibrated_30_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Proficio_Band_Calibrated_30_button.Location = new System.Drawing.Point(276, 29);
            this.Proficio_Band_Calibrated_30_button.Name = "Proficio_Band_Calibrated_30_button";
            this.Proficio_Band_Calibrated_30_button.Size = new System.Drawing.Size(13, 13);
            this.Proficio_Band_Calibrated_30_button.TabIndex = 203;
            this.Proficio_Band_Calibrated_30_button.UseVisualStyleBackColor = false;
            this.Proficio_Band_Calibrated_30_button.Click += new System.EventHandler(this.Proficio_Band_Calibrated_30_button_Click);
            // 
            // Proficio_Band_Calibrated_40_button
            // 
            this.Proficio_Band_Calibrated_40_button.BackColor = System.Drawing.Color.White;
            this.Proficio_Band_Calibrated_40_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proficio_Band_Calibrated_40_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Calibrated_40_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Band_Calibrated_40_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Proficio_Band_Calibrated_40_button.Location = new System.Drawing.Point(214, 29);
            this.Proficio_Band_Calibrated_40_button.Name = "Proficio_Band_Calibrated_40_button";
            this.Proficio_Band_Calibrated_40_button.Size = new System.Drawing.Size(13, 13);
            this.Proficio_Band_Calibrated_40_button.TabIndex = 202;
            this.Proficio_Band_Calibrated_40_button.UseVisualStyleBackColor = false;
            this.Proficio_Band_Calibrated_40_button.Click += new System.EventHandler(this.Proficio_Band_Calibrated_40_button_Click);
            // 
            // Proficio_Band_Calibrated_60_button
            // 
            this.Proficio_Band_Calibrated_60_button.BackColor = System.Drawing.Color.White;
            this.Proficio_Band_Calibrated_60_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proficio_Band_Calibrated_60_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Calibrated_60_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Band_Calibrated_60_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Proficio_Band_Calibrated_60_button.Location = new System.Drawing.Point(152, 29);
            this.Proficio_Band_Calibrated_60_button.Name = "Proficio_Band_Calibrated_60_button";
            this.Proficio_Band_Calibrated_60_button.Size = new System.Drawing.Size(13, 13);
            this.Proficio_Band_Calibrated_60_button.TabIndex = 201;
            this.Proficio_Band_Calibrated_60_button.UseVisualStyleBackColor = false;
            this.Proficio_Band_Calibrated_60_button.Click += new System.EventHandler(this.Proficio_Band_Calibrated_60_button_Click);
            // 
            // Proficio_Band_Calibrated_80_button
            // 
            this.Proficio_Band_Calibrated_80_button.BackColor = System.Drawing.Color.White;
            this.Proficio_Band_Calibrated_80_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proficio_Band_Calibrated_80_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Calibrated_80_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Band_Calibrated_80_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Proficio_Band_Calibrated_80_button.Location = new System.Drawing.Point(90, 29);
            this.Proficio_Band_Calibrated_80_button.Name = "Proficio_Band_Calibrated_80_button";
            this.Proficio_Band_Calibrated_80_button.Size = new System.Drawing.Size(13, 13);
            this.Proficio_Band_Calibrated_80_button.TabIndex = 200;
            this.Proficio_Band_Calibrated_80_button.UseVisualStyleBackColor = false;
            this.Proficio_Band_Calibrated_80_button.Click += new System.EventHandler(this.Proficio_Band_Calibrated_80_Click);
            // 
            // Proficio_Band_Calibrated_160_button
            // 
            this.Proficio_Band_Calibrated_160_button.BackColor = System.Drawing.Color.White;
            this.Proficio_Band_Calibrated_160_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proficio_Band_Calibrated_160_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Band_Calibrated_160_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Band_Calibrated_160_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Proficio_Band_Calibrated_160_button.Location = new System.Drawing.Point(18, 29);
            this.Proficio_Band_Calibrated_160_button.Name = "Proficio_Band_Calibrated_160_button";
            this.Proficio_Band_Calibrated_160_button.Size = new System.Drawing.Size(13, 13);
            this.Proficio_Band_Calibrated_160_button.TabIndex = 199;
            this.Proficio_Band_Calibrated_160_button.UseVisualStyleBackColor = false;
            this.Proficio_Band_Calibrated_160_button.Click += new System.EventHandler(this.Proficio_Band_Calibrated_160_button_Click);
            // 
            // Proficio_Calibrate_button8
            // 
            this.Proficio_Calibrate_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Proficio_Calibrate_button8.Enabled = false;
            this.Proficio_Calibrate_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Calibrate_button8.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Calibrate_button8.Location = new System.Drawing.Point(60, 237);
            this.Proficio_Calibrate_button8.Name = "Proficio_Calibrate_button8";
            this.Proficio_Calibrate_button8.Size = new System.Drawing.Size(167, 27);
            this.Proficio_Calibrate_button8.TabIndex = 199;
            this.Proficio_Calibrate_button8.Text = "AUTO CALIBRATE";
            this.Proficio_Calibrate_button8.UseVisualStyleBackColor = false;
            this.Proficio_Calibrate_button8.Visible = false;
            this.Proficio_Calibrate_button8.Click += new System.EventHandler(this.Proficio_Calibrate_button8_Click);
            // 
            // Transceiver_Calibrate_groupBox
            // 
            this.Transceiver_Calibrate_groupBox.Controls.Add(this.XCRV_Power_Display_label33);
            this.Transceiver_Calibrate_groupBox.Controls.Add(this.Proficio_Pwr_groupBox6);
            this.Transceiver_Calibrate_groupBox.Controls.Add(this.Proficio_Calibrate_Power_hScrollBar);
            this.Transceiver_Calibrate_groupBox.Controls.Add(this.powerlabel14);
            this.Transceiver_Calibrate_groupBox.Controls.Add(this.Proficio_Manual_Calibrate_button);
            this.Transceiver_Calibrate_groupBox.Controls.Add(this.powertunebutton1);
            this.Transceiver_Calibrate_groupBox.Controls.Add(this.powerrestorebutton2);
            this.Transceiver_Calibrate_groupBox.ForeColor = System.Drawing.Color.White;
            this.Transceiver_Calibrate_groupBox.Location = new System.Drawing.Point(5, 5);
            this.Transceiver_Calibrate_groupBox.Name = "Transceiver_Calibrate_groupBox";
            this.Transceiver_Calibrate_groupBox.Size = new System.Drawing.Size(777, 276);
            this.Transceiver_Calibrate_groupBox.TabIndex = 204;
            this.Transceiver_Calibrate_groupBox.TabStop = false;
            this.Transceiver_Calibrate_groupBox.Text = "TRANSCEIVER";
            // 
            // XCRV_Power_Display_label33
            // 
            this.XCRV_Power_Display_label33.BackColor = System.Drawing.Color.Gainsboro;
            this.XCRV_Power_Display_label33.Enabled = false;
            this.XCRV_Power_Display_label33.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XCRV_Power_Display_label33.ForeColor = System.Drawing.Color.Black;
            this.XCRV_Power_Display_label33.Location = new System.Drawing.Point(514, 234);
            this.XCRV_Power_Display_label33.Name = "XCRV_Power_Display_label33";
            this.XCRV_Power_Display_label33.Size = new System.Drawing.Size(209, 23);
            this.XCRV_Power_Display_label33.TabIndex = 190;
            this.XCRV_Power_Display_label33.Text = "POWER OUTPUT:";
            this.XCRV_Power_Display_label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XCRV_Power_Display_label33.Visible = false;
            this.XCRV_Power_Display_label33.Click += new System.EventHandler(this.XCRV_Power_Display_label33_Click);
            // 
            // Proficio_Pwr_groupBox6
            // 
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B630_radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B2200_radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B15radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B20radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B10radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B30radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B40radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B160radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B17radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B60radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B12radioButton);
            this.Proficio_Pwr_groupBox6.Controls.Add(this.B80radioButton);
            this.Proficio_Pwr_groupBox6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Pwr_groupBox6.ForeColor = System.Drawing.Color.White;
            this.Proficio_Pwr_groupBox6.Location = new System.Drawing.Point(61, 102);
            this.Proficio_Pwr_groupBox6.Name = "Proficio_Pwr_groupBox6";
            this.Proficio_Pwr_groupBox6.Size = new System.Drawing.Size(663, 80);
            this.Proficio_Pwr_groupBox6.TabIndex = 191;
            this.Proficio_Pwr_groupBox6.TabStop = false;
            this.Proficio_Pwr_groupBox6.Text = "BAND SELECTION";
            this.Proficio_Pwr_groupBox6.Enter += new System.EventHandler(this.Proficio_Pwr_groupBox6_Enter);
            // 
            // B630_radioButton
            // 
            this.B630_radioButton.AutoSize = true;
            this.B630_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B630_radioButton.Enabled = false;
            this.B630_radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B630_radioButton.ForeColor = System.Drawing.Color.White;
            this.B630_radioButton.Location = new System.Drawing.Point(339, 52);
            this.B630_radioButton.Name = "B630_radioButton";
            this.B630_radioButton.Size = new System.Drawing.Size(69, 22);
            this.B630_radioButton.TabIndex = 203;
            this.B630_radioButton.Text = "630M";
            this.B630_radioButton.UseVisualStyleBackColor = false;
            this.B630_radioButton.Visible = false;
            this.B630_radioButton.CheckedChanged += new System.EventHandler(this.B630_radioButton_CheckedChanged);
            // 
            // B2200_radioButton
            // 
            this.B2200_radioButton.AutoSize = true;
            this.B2200_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B2200_radioButton.Enabled = false;
            this.B2200_radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2200_radioButton.ForeColor = System.Drawing.Color.White;
            this.B2200_radioButton.Location = new System.Drawing.Point(254, 52);
            this.B2200_radioButton.Name = "B2200_radioButton";
            this.B2200_radioButton.Size = new System.Drawing.Size(79, 22);
            this.B2200_radioButton.TabIndex = 52;
            this.B2200_radioButton.Text = "2200M";
            this.B2200_radioButton.UseVisualStyleBackColor = false;
            this.B2200_radioButton.Visible = false;
            this.B2200_radioButton.CheckedChanged += new System.EventHandler(this.B2200_radioButton_CheckedChanged);
            // 
            // B15radioButton
            // 
            this.B15radioButton.AutoSize = true;
            this.B15radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B15radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B15radioButton.ForeColor = System.Drawing.Color.White;
            this.B15radioButton.Location = new System.Drawing.Point(460, 26);
            this.B15radioButton.Name = "B15radioButton";
            this.B15radioButton.Size = new System.Drawing.Size(59, 22);
            this.B15radioButton.TabIndex = 49;
            this.B15radioButton.Text = "15M";
            this.B15radioButton.UseVisualStyleBackColor = false;
            this.B15radioButton.CheckedChanged += new System.EventHandler(this.B15radioButton_CheckedChanged);
            // 
            // B20radioButton
            // 
            this.B20radioButton.AutoSize = true;
            this.B20radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B20radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B20radioButton.ForeColor = System.Drawing.Color.White;
            this.B20radioButton.Location = new System.Drawing.Point(336, 26);
            this.B20radioButton.Name = "B20radioButton";
            this.B20radioButton.Size = new System.Drawing.Size(59, 22);
            this.B20radioButton.TabIndex = 47;
            this.B20radioButton.Text = "20M";
            this.B20radioButton.UseVisualStyleBackColor = false;
            this.B20radioButton.CheckedChanged += new System.EventHandler(this.B20radioButton_CheckedChanged);
            // 
            // B10radioButton
            // 
            this.B10radioButton.AutoSize = true;
            this.B10radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B10radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B10radioButton.ForeColor = System.Drawing.Color.White;
            this.B10radioButton.Location = new System.Drawing.Point(584, 26);
            this.B10radioButton.Name = "B10radioButton";
            this.B10radioButton.Size = new System.Drawing.Size(59, 22);
            this.B10radioButton.TabIndex = 51;
            this.B10radioButton.Text = "10M";
            this.B10radioButton.UseVisualStyleBackColor = false;
            this.B10radioButton.CheckedChanged += new System.EventHandler(this.B10radioButton_CheckedChanged);
            // 
            // B30radioButton
            // 
            this.B30radioButton.AutoSize = true;
            this.B30radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B30radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B30radioButton.ForeColor = System.Drawing.Color.White;
            this.B30radioButton.Location = new System.Drawing.Point(274, 26);
            this.B30radioButton.Name = "B30radioButton";
            this.B30radioButton.Size = new System.Drawing.Size(59, 22);
            this.B30radioButton.TabIndex = 46;
            this.B30radioButton.Text = "30M";
            this.B30radioButton.UseVisualStyleBackColor = false;
            this.B30radioButton.CheckedChanged += new System.EventHandler(this.B30radioButton_CheckedChanged);
            // 
            // B40radioButton
            // 
            this.B40radioButton.AutoSize = true;
            this.B40radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B40radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B40radioButton.ForeColor = System.Drawing.Color.White;
            this.B40radioButton.Location = new System.Drawing.Point(212, 26);
            this.B40radioButton.Name = "B40radioButton";
            this.B40radioButton.Size = new System.Drawing.Size(59, 22);
            this.B40radioButton.TabIndex = 45;
            this.B40radioButton.Text = "40M";
            this.B40radioButton.UseVisualStyleBackColor = false;
            this.B40radioButton.CheckedChanged += new System.EventHandler(this.B40radioButton_CheckedChanged);
            // 
            // B160radioButton
            // 
            this.B160radioButton.AutoSize = true;
            this.B160radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B160radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B160radioButton.ForeColor = System.Drawing.Color.White;
            this.B160radioButton.Location = new System.Drawing.Point(19, 26);
            this.B160radioButton.Name = "B160radioButton";
            this.B160radioButton.Size = new System.Drawing.Size(69, 22);
            this.B160radioButton.TabIndex = 42;
            this.B160radioButton.Text = "160M";
            this.B160radioButton.UseVisualStyleBackColor = false;
            this.B160radioButton.CheckedChanged += new System.EventHandler(this.B160radioButton_CheckedChanged);
            // 
            // B17radioButton
            // 
            this.B17radioButton.AutoSize = true;
            this.B17radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B17radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B17radioButton.ForeColor = System.Drawing.Color.White;
            this.B17radioButton.Location = new System.Drawing.Point(398, 26);
            this.B17radioButton.Name = "B17radioButton";
            this.B17radioButton.Size = new System.Drawing.Size(59, 22);
            this.B17radioButton.TabIndex = 48;
            this.B17radioButton.Text = "17M";
            this.B17radioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B17radioButton.UseVisualStyleBackColor = false;
            this.B17radioButton.CheckedChanged += new System.EventHandler(this.B17radioButton_CheckedChanged);
            // 
            // B60radioButton
            // 
            this.B60radioButton.AutoSize = true;
            this.B60radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B60radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B60radioButton.ForeColor = System.Drawing.Color.White;
            this.B60radioButton.Location = new System.Drawing.Point(150, 26);
            this.B60radioButton.Name = "B60radioButton";
            this.B60radioButton.Size = new System.Drawing.Size(59, 22);
            this.B60radioButton.TabIndex = 44;
            this.B60radioButton.Text = "60M";
            this.B60radioButton.UseVisualStyleBackColor = false;
            this.B60radioButton.CheckedChanged += new System.EventHandler(this.B60radioButton_CheckedChanged);
            // 
            // B12radioButton
            // 
            this.B12radioButton.AutoSize = true;
            this.B12radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B12radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B12radioButton.ForeColor = System.Drawing.Color.White;
            this.B12radioButton.Location = new System.Drawing.Point(522, 26);
            this.B12radioButton.Name = "B12radioButton";
            this.B12radioButton.Size = new System.Drawing.Size(59, 22);
            this.B12radioButton.TabIndex = 50;
            this.B12radioButton.Text = "12M";
            this.B12radioButton.UseVisualStyleBackColor = false;
            this.B12radioButton.CheckedChanged += new System.EventHandler(this.B12radioButton_CheckedChanged);
            // 
            // B80radioButton
            // 
            this.B80radioButton.AutoSize = true;
            this.B80radioButton.BackColor = System.Drawing.Color.Transparent;
            this.B80radioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B80radioButton.ForeColor = System.Drawing.Color.White;
            this.B80radioButton.Location = new System.Drawing.Point(88, 26);
            this.B80radioButton.Name = "B80radioButton";
            this.B80radioButton.Size = new System.Drawing.Size(59, 22);
            this.B80radioButton.TabIndex = 43;
            this.B80radioButton.Text = "80M";
            this.B80radioButton.UseVisualStyleBackColor = false;
            this.B80radioButton.CheckedChanged += new System.EventHandler(this.B80radioButton_CheckedChanged);
            // 
            // Proficio_Calibrate_Power_hScrollBar
            // 
            this.Proficio_Calibrate_Power_hScrollBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Proficio_Calibrate_Power_hScrollBar.Enabled = false;
            this.Proficio_Calibrate_Power_hScrollBar.LargeChange = 5;
            this.Proficio_Calibrate_Power_hScrollBar.Location = new System.Drawing.Point(284, 216);
            this.Proficio_Calibrate_Power_hScrollBar.Maximum = 102;
            this.Proficio_Calibrate_Power_hScrollBar.Name = "Proficio_Calibrate_Power_hScrollBar";
            this.Proficio_Calibrate_Power_hScrollBar.Size = new System.Drawing.Size(207, 24);
            this.Proficio_Calibrate_Power_hScrollBar.TabIndex = 202;
            this.Proficio_Calibrate_Power_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Proficio_Calibrate_Power_hScrollBar_Scroll);
            // 
            // powerlabel14
            // 
            this.powerlabel14.BackColor = System.Drawing.Color.Gainsboro;
            this.powerlabel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.powerlabel14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerlabel14.ForeColor = System.Drawing.Color.Black;
            this.powerlabel14.Location = new System.Drawing.Point(61, 185);
            this.powerlabel14.Name = "powerlabel14";
            this.powerlabel14.Size = new System.Drawing.Size(209, 23);
            this.powerlabel14.TabIndex = 26;
            this.powerlabel14.Text = " CALIBRATION STEP:";
            this.powerlabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.powerlabel14.Click += new System.EventHandler(this.powerlabel14_Click);
            // 
            // Proficio_Manual_Calibrate_button
            // 
            this.Proficio_Manual_Calibrate_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Proficio_Manual_Calibrate_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proficio_Manual_Calibrate_button.ForeColor = System.Drawing.Color.Black;
            this.Proficio_Manual_Calibrate_button.Location = new System.Drawing.Point(284, 183);
            this.Proficio_Manual_Calibrate_button.Name = "Proficio_Manual_Calibrate_button";
            this.Proficio_Manual_Calibrate_button.Size = new System.Drawing.Size(209, 27);
            this.Proficio_Manual_Calibrate_button.TabIndex = 201;
            this.Proficio_Manual_Calibrate_button.Text = "CALIBRATE";
            this.Proficio_Manual_Calibrate_button.UseVisualStyleBackColor = false;
            this.Proficio_Manual_Calibrate_button.Click += new System.EventHandler(this.Proficio_Manual_Calibrate_button_Click);
            // 
            // powertunebutton1
            // 
            this.powertunebutton1.BackColor = System.Drawing.Color.Gainsboro;
            this.powertunebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.powertunebutton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powertunebutton1.ForeColor = System.Drawing.Color.Black;
            this.powertunebutton1.Location = new System.Drawing.Point(366, 243);
            this.powertunebutton1.Name = "powertunebutton1";
            this.powertunebutton1.Size = new System.Drawing.Size(42, 27);
            this.powertunebutton1.TabIndex = 30;
            this.powertunebutton1.Text = "TX";
            this.powertunebutton1.UseVisualStyleBackColor = false;
            this.powertunebutton1.Click += new System.EventHandler(this.powertunebutton1_Click);
            // 
            // powerrestorebutton2
            // 
            this.powerrestorebutton2.BackColor = System.Drawing.Color.Gainsboro;
            this.powerrestorebutton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.powerrestorebutton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerrestorebutton2.ForeColor = System.Drawing.Color.Black;
            this.powerrestorebutton2.Location = new System.Drawing.Point(499, 183);
            this.powerrestorebutton2.Name = "powerrestorebutton2";
            this.powerrestorebutton2.Size = new System.Drawing.Size(225, 27);
            this.powerrestorebutton2.TabIndex = 31;
            this.powerrestorebutton2.Text = "FACTORY DEFAULTS";
            this.powerrestorebutton2.UseVisualStyleBackColor = false;
            this.powerrestorebutton2.Click += new System.EventHandler(this.powerrestorebutton2_Click);
            // 
            // Audio_tabPage1
            // 
            this.Audio_tabPage1.BackColor = System.Drawing.Color.Black;
            this.Audio_tabPage1.Controls.Add(this.CW_groupBox);
            this.Audio_tabPage1.Location = new System.Drawing.Point(4, 24);
            this.Audio_tabPage1.Name = "Audio_tabPage1";
            this.Audio_tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.Audio_tabPage1.Size = new System.Drawing.Size(806, 481);
            this.Audio_tabPage1.TabIndex = 12;
            this.Audio_tabPage1.Text = "     CW     ";
            this.Audio_tabPage1.ToolTipText = "CW CONTROLS";
            this.Audio_tabPage1.Click += new System.EventHandler(this.Audio_tabPage1_Click);
            this.Audio_tabPage1.Enter += new System.EventHandler(this.Audio_tabPage1_Enter);
            this.Audio_tabPage1.Leave += new System.EventHandler(this.Audio_tabPage1_Leave);
            // 
            // CW_groupBox
            // 
            this.CW_groupBox.Controls.Add(this.Potentia_checkBox);
            this.CW_groupBox.Controls.Add(this.CW_Mode_Phone_checkBox);
            this.CW_groupBox.Controls.Add(this.label7);
            this.CW_groupBox.Controls.Add(this.ritlistBox1);
            this.CW_groupBox.Controls.Add(this.CW_Hold_numericUpDown2);
            this.CW_groupBox.Controls.Add(this.CW_Speed_numericUpDown);
            this.CW_groupBox.Controls.Add(this.CW_Paddle_listBox1);
            this.CW_groupBox.Controls.Add(this.CW_Weight_listBox1);
            this.CW_groupBox.Controls.Add(this.CW_Space_listBox1);
            this.CW_groupBox.Controls.Add(this.CW_Mode_listBox1);
            this.CW_groupBox.Controls.Add(this.label60);
            this.CW_groupBox.Controls.Add(this.label59);
            this.CW_groupBox.Controls.Add(this.label58);
            this.CW_groupBox.Controls.Add(this.label45);
            this.CW_groupBox.Controls.Add(this.label5);
            this.CW_groupBox.Controls.Add(this.label8);
            this.CW_groupBox.Controls.Add(this.CW_Pitch_listBox1);
            this.CW_groupBox.Controls.Add(this.label35);
            this.CW_groupBox.ForeColor = System.Drawing.Color.White;
            this.CW_groupBox.Location = new System.Drawing.Point(16, 17);
            this.CW_groupBox.Name = "CW_groupBox";
            this.CW_groupBox.Size = new System.Drawing.Size(760, 244);
            this.CW_groupBox.TabIndex = 145;
            this.CW_groupBox.TabStop = false;
            this.CW_groupBox.Text = "CW CONTROLS";
            this.CW_groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Potentia_checkBox
            // 
            this.Potentia_checkBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Potentia_checkBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Potentia_checkBox.ForeColor = System.Drawing.Color.Black;
            this.Potentia_checkBox.Location = new System.Drawing.Point(325, 190);
            this.Potentia_checkBox.Name = "Potentia_checkBox";
            this.Potentia_checkBox.Size = new System.Drawing.Size(110, 22);
            this.Potentia_checkBox.TabIndex = 214;
            this.Potentia_checkBox.Text = "POTENTIA";
            this.Potentia_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.Potentia_checkBox, "SET IF THE POTENTIA 50 OR POTENTIA 100 IS ATTACHED.");
            this.Potentia_checkBox.UseVisualStyleBackColor = false;
            this.Potentia_checkBox.CheckedChanged += new System.EventHandler(this.Potentia_checkBox_CheckedChanged);
            // 
            // CW_Mode_Phone_checkBox
            // 
            this.CW_Mode_Phone_checkBox.BackColor = System.Drawing.Color.Gainsboro;
            this.CW_Mode_Phone_checkBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CW_Mode_Phone_checkBox.ForeColor = System.Drawing.Color.Black;
            this.CW_Mode_Phone_checkBox.Location = new System.Drawing.Point(331, 160);
            this.CW_Mode_Phone_checkBox.Name = "CW_Mode_Phone_checkBox";
            this.CW_Mode_Phone_checkBox.Size = new System.Drawing.Size(99, 22);
            this.CW_Mode_Phone_checkBox.TabIndex = 213;
            this.CW_Mode_Phone_checkBox.Text = "PHONES";
            this.toolTip.SetToolTip(this.CW_Mode_Phone_checkBox, "SET AUDIO CONNECTION TO PHONE\r\nWHEN IN CW MODE");
            this.CW_Mode_Phone_checkBox.UseVisualStyleBackColor = false;
            this.CW_Mode_Phone_checkBox.CheckedChanged += new System.EventHandler(this.CW_Mode_Phone_checkBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 157;
            this.label7.Text = "RIT STEP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ritlistBox1
            // 
            this.ritlistBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.ritlistBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ritlistBox1.ForeColor = System.Drawing.Color.Black;
            this.ritlistBox1.FormattingEnabled = true;
            this.ritlistBox1.ItemHeight = 18;
            this.ritlistBox1.Items.AddRange(new object[] {
            "1",
            "10",
            "50",
            "100"});
            this.ritlistBox1.Location = new System.Drawing.Point(39, 49);
            this.ritlistBox1.Name = "ritlistBox1";
            this.ritlistBox1.Size = new System.Drawing.Size(59, 94);
            this.ritlistBox1.TabIndex = 156;
            this.ritlistBox1.SelectedIndexChanged += new System.EventHandler(this.ritlistBox1_SelectedIndexChanged);
            // 
            // CW_Hold_numericUpDown2
            // 
            this.CW_Hold_numericUpDown2.BackColor = System.Drawing.Color.Gainsboro;
            this.CW_Hold_numericUpDown2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CW_Hold_numericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.CW_Hold_numericUpDown2.Location = new System.Drawing.Point(45, 185);
            this.CW_Hold_numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CW_Hold_numericUpDown2.Name = "CW_Hold_numericUpDown2";
            this.CW_Hold_numericUpDown2.Size = new System.Drawing.Size(51, 27);
            this.CW_Hold_numericUpDown2.TabIndex = 153;
            this.toolTip.SetToolTip(this.CW_Hold_numericUpDown2, "HOLD TIME IN MS BEFORE RETURNING TO RX.");
            this.CW_Hold_numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CW_Hold_numericUpDown2.ValueChanged += new System.EventHandler(this.CW_Hold_numericUpDown2_ValueChanged);
            // 
            // CW_Speed_numericUpDown
            // 
            this.CW_Speed_numericUpDown.BackColor = System.Drawing.Color.Gainsboro;
            this.CW_Speed_numericUpDown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CW_Speed_numericUpDown.ForeColor = System.Drawing.Color.Black;
            this.CW_Speed_numericUpDown.Location = new System.Drawing.Point(675, 185);
            this.CW_Speed_numericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.CW_Speed_numericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CW_Speed_numericUpDown.Name = "CW_Speed_numericUpDown";
            this.CW_Speed_numericUpDown.Size = new System.Drawing.Size(47, 27);
            this.CW_Speed_numericUpDown.TabIndex = 151;
            this.CW_Speed_numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CW_Speed_numericUpDown.ValueChanged += new System.EventHandler(this.CW_Speed_numericUpDown_ValueChanged);
            // 
            // CW_Paddle_listBox1
            // 
            this.CW_Paddle_listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.CW_Paddle_listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CW_Paddle_listBox1.ForeColor = System.Drawing.Color.Black;
            this.CW_Paddle_listBox1.FormattingEnabled = true;
            this.CW_Paddle_listBox1.ItemHeight = 18;
            this.CW_Paddle_listBox1.Items.AddRange(new object[] {
            "NORMAL",
            "REVERSE"});
            this.CW_Paddle_listBox1.Location = new System.Drawing.Point(522, 53);
            this.CW_Paddle_listBox1.Name = "CW_Paddle_listBox1";
            this.CW_Paddle_listBox1.Size = new System.Drawing.Size(94, 94);
            this.CW_Paddle_listBox1.TabIndex = 149;
            this.CW_Paddle_listBox1.SelectedIndexChanged += new System.EventHandler(this.CW_Paddle_listBox1_SelectedIndexChanged);
            // 
            // CW_Weight_listBox1
            // 
            this.CW_Weight_listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.CW_Weight_listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CW_Weight_listBox1.ForeColor = System.Drawing.Color.Black;
            this.CW_Weight_listBox1.FormattingEnabled = true;
            this.CW_Weight_listBox1.ItemHeight = 18;
            this.CW_Weight_listBox1.Items.AddRange(new object[] {
            "25",
            "50",
            "75"});
            this.CW_Weight_listBox1.Location = new System.Drawing.Point(414, 53);
            this.CW_Weight_listBox1.Name = "CW_Weight_listBox1";
            this.CW_Weight_listBox1.Size = new System.Drawing.Size(52, 94);
            this.CW_Weight_listBox1.TabIndex = 148;
            this.CW_Weight_listBox1.SelectedIndexChanged += new System.EventHandler(this.CW_Weight_listBox1_SelectedIndexChanged);
            // 
            // CW_Space_listBox1
            // 
            this.CW_Space_listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.CW_Space_listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CW_Space_listBox1.ForeColor = System.Drawing.Color.Black;
            this.CW_Space_listBox1.FormattingEnabled = true;
            this.CW_Space_listBox1.ItemHeight = 18;
            this.CW_Space_listBox1.Items.AddRange(new object[] {
            "ELEMENT",
            "LETTER"});
            this.CW_Space_listBox1.Location = new System.Drawing.Point(266, 53);
            this.CW_Space_listBox1.Name = "CW_Space_listBox1";
            this.CW_Space_listBox1.Size = new System.Drawing.Size(102, 94);
            this.CW_Space_listBox1.TabIndex = 147;
            this.CW_Space_listBox1.SelectedIndexChanged += new System.EventHandler(this.CW_Space_listBox1_SelectedIndexChanged);
            // 
            // CW_Mode_listBox1
            // 
            this.CW_Mode_listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.CW_Mode_listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CW_Mode_listBox1.ForeColor = System.Drawing.Color.Black;
            this.CW_Mode_listBox1.FormattingEnabled = true;
            this.CW_Mode_listBox1.ItemHeight = 18;
            this.CW_Mode_listBox1.Items.AddRange(new object[] {
            "STRAIGHT",
            "IAMBIC-A",
            "IAMBIC-B"});
            this.CW_Mode_listBox1.Location = new System.Drawing.Point(148, 53);
            this.CW_Mode_listBox1.Name = "CW_Mode_listBox1";
            this.CW_Mode_listBox1.Size = new System.Drawing.Size(96, 94);
            this.CW_Mode_listBox1.TabIndex = 145;
            this.CW_Mode_listBox1.SelectedIndexChanged += new System.EventHandler(this.CW_Mode_listBox1_SelectedIndexChanged);
            // 
            // label60
            // 
            this.label60.BackColor = System.Drawing.Color.Gainsboro;
            this.label60.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.Black;
            this.label60.Location = new System.Drawing.Point(523, 21);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(92, 23);
            this.label60.TabIndex = 143;
            this.label60.Text = "PADDLE";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label60.Click += new System.EventHandler(this.label60_Click);
            // 
            // label59
            // 
            this.label59.BackColor = System.Drawing.Color.Gainsboro;
            this.label59.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Black;
            this.label59.Location = new System.Drawing.Point(399, 21);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(83, 23);
            this.label59.TabIndex = 142;
            this.label59.Text = "WEIGHT";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.BackColor = System.Drawing.Color.Gainsboro;
            this.label58.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.Black;
            this.label58.Location = new System.Drawing.Point(277, 21);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(81, 23);
            this.label58.TabIndex = 141;
            this.label58.Text = "SPACE";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.Gainsboro;
            this.label45.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(657, 159);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(82, 23);
            this.label45.TabIndex = 140;
            this.label45.Text = "SPEED";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(157, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 138;
            this.label5.Text = "KEY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 132;
            this.label8.Text = "HOLD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CW_Pitch_listBox1
            // 
            this.CW_Pitch_listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.CW_Pitch_listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CW_Pitch_listBox1.ForeColor = System.Drawing.Color.Black;
            this.CW_Pitch_listBox1.FormattingEnabled = true;
            this.CW_Pitch_listBox1.ItemHeight = 18;
            this.CW_Pitch_listBox1.Items.AddRange(new object[] {
            "400Hz",
            "600Hz",
            "800Hz",
            "1000Hz"});
            this.CW_Pitch_listBox1.Location = new System.Drawing.Point(658, 53);
            this.CW_Pitch_listBox1.Name = "CW_Pitch_listBox1";
            this.CW_Pitch_listBox1.Size = new System.Drawing.Size(79, 94);
            this.CW_Pitch_listBox1.TabIndex = 137;
            this.CW_Pitch_listBox1.SelectedIndexChanged += new System.EventHandler(this.CW_Pitch_listBox1_SelectedIndexChanged);
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.Gainsboro;
            this.label35.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(656, 21);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(82, 23);
            this.label35.TabIndex = 136;
            this.label35.Text = "PITCH";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // MFC
            // 
            this.MFC.BackColor = System.Drawing.Color.Black;
            this.MFC.Controls.Add(this.IQBD_TX_groupBox);
            this.MFC.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MFC.ForeColor = System.Drawing.Color.Black;
            this.MFC.Location = new System.Drawing.Point(4, 24);
            this.MFC.Name = "MFC";
            this.MFC.Padding = new System.Windows.Forms.Padding(3);
            this.MFC.Size = new System.Drawing.Size(806, 481);
            this.MFC.TabIndex = 14;
            this.MFC.Text = "    Tx IQ     ";
            this.MFC.ToolTipText = "SOLIDUS / FORTIS CONTROLS";
            this.MFC.Click += new System.EventHandler(this.MFC_Click);
            this.MFC.Enter += new System.EventHandler(this.MFC_Enter);
            this.MFC.Leave += new System.EventHandler(this.MFC_Leave);
            // 
            // IQBD_TX_groupBox
            // 
            this.IQBD_TX_groupBox.Controls.Add(this.label2);
            this.IQBD_TX_groupBox.Controls.Add(this.TX_IQ_Balance_label);
            this.IQBD_TX_groupBox.Controls.Add(this.IQ_TX_Label);
            this.IQBD_TX_groupBox.Controls.Add(this.Geminus_Select_Band_button);
            this.IQBD_TX_groupBox.Controls.Add(this.IQBD_Meter);
            this.IQBD_TX_groupBox.Controls.Add(this.IQ_TX_Band_button);
            this.IQBD_TX_groupBox.Controls.Add(this.IQ_TX_Button);
            this.IQBD_TX_groupBox.Controls.Add(this.IQBD_Reset_button8);
            this.IQBD_TX_groupBox.Controls.Add(this.IQBD_Auto_button8);
            this.IQBD_TX_groupBox.Controls.Add(this.IQBD_TX_hScrollBar);
            this.IQBD_TX_groupBox.Controls.Add(this.IQBD_TX_Power_hScrollBar);
            this.IQBD_TX_groupBox.Controls.Add(this.IQBD_Monitor_label);
            this.IQBD_TX_groupBox.Controls.Add(this.IQBD_TX_Tune_button);
            this.IQBD_TX_groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IQBD_TX_groupBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQBD_TX_groupBox.ForeColor = System.Drawing.Color.White;
            this.IQBD_TX_groupBox.Location = new System.Drawing.Point(6, 6);
            this.IQBD_TX_groupBox.Name = "IQBD_TX_groupBox";
            this.IQBD_TX_groupBox.Size = new System.Drawing.Size(778, 175);
            this.IQBD_TX_groupBox.TabIndex = 192;
            this.IQBD_TX_groupBox.TabStop = false;
            this.IQBD_TX_groupBox.Text = "TX I/Q CALIBRATION";
            this.IQBD_TX_groupBox.Enter += new System.EventHandler(this.IQBD_groupBox4_Enter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(479, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 204;
            this.label2.Text = "TX IQ POWER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TX_IQ_Balance_label
            // 
            this.TX_IQ_Balance_label.BackColor = System.Drawing.Color.Gainsboro;
            this.TX_IQ_Balance_label.Enabled = false;
            this.TX_IQ_Balance_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_IQ_Balance_label.ForeColor = System.Drawing.Color.Black;
            this.TX_IQ_Balance_label.Location = new System.Drawing.Point(144, 83);
            this.TX_IQ_Balance_label.Name = "TX_IQ_Balance_label";
            this.TX_IQ_Balance_label.Size = new System.Drawing.Size(155, 26);
            this.TX_IQ_Balance_label.TabIndex = 203;
            this.TX_IQ_Balance_label.Text = "TX IQ BALANCE";
            this.TX_IQ_Balance_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IQ_TX_Label
            // 
            this.IQ_TX_Label.BackColor = System.Drawing.Color.Gainsboro;
            this.IQ_TX_Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQ_TX_Label.ForeColor = System.Drawing.Color.Black;
            this.IQ_TX_Label.Location = new System.Drawing.Point(206, 51);
            this.IQ_TX_Label.Name = "IQ_TX_Label";
            this.IQ_TX_Label.Size = new System.Drawing.Size(171, 26);
            this.IQ_TX_Label.TabIndex = 202;
            this.IQ_TX_Label.Text = "TX IQ OFFSET:";
            this.IQ_TX_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IQ_TX_Label.Click += new System.EventHandler(this.IQ_TX_Label_Click);
            // 
            // Geminus_Select_Band_button
            // 
            this.Geminus_Select_Band_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Geminus_Select_Band_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Geminus_Select_Band_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geminus_Select_Band_button.ForeColor = System.Drawing.Color.Black;
            this.Geminus_Select_Band_button.Location = new System.Drawing.Point(401, 51);
            this.Geminus_Select_Band_button.Name = "Geminus_Select_Band_button";
            this.Geminus_Select_Band_button.Size = new System.Drawing.Size(171, 26);
            this.Geminus_Select_Band_button.TabIndex = 201;
            this.Geminus_Select_Band_button.Text = "SELECT BAND";
            this.Geminus_Select_Band_button.UseVisualStyleBackColor = false;
            this.Geminus_Select_Band_button.Click += new System.EventHandler(this.Geminus_Select_Band_button_Click);
            // 
            // IQBD_Meter
            // 
            this.IQBD_Meter.AnalogMeter = false;
            this.IQBD_Meter.DialBackground = System.Drawing.Color.White;
            this.IQBD_Meter.DialTextNegative = System.Drawing.Color.Red;
            this.IQBD_Meter.DialTextPositive = System.Drawing.Color.Black;
            this.IQBD_Meter.DialTextZero = System.Drawing.Color.DarkGreen;
            this.IQBD_Meter.Led1ColorOff = System.Drawing.Color.LawnGreen;
            this.IQBD_Meter.Led1ColorOn = System.Drawing.Color.Red;
            this.IQBD_Meter.Led1Count = 8;
            this.IQBD_Meter.Led2ColorOff = System.Drawing.Color.LawnGreen;
            this.IQBD_Meter.Led2ColorOn = System.Drawing.Color.Red;
            this.IQBD_Meter.Led2Count = 8;
            this.IQBD_Meter.Led3ColorOff = System.Drawing.Color.LawnGreen;
            this.IQBD_Meter.Led3ColorOn = System.Drawing.Color.Red;
            this.IQBD_Meter.Led3Count = 8;
            this.IQBD_Meter.LedSize = new System.Drawing.Size(6, 26);
            this.IQBD_Meter.LedSpace = 1;
            this.IQBD_Meter.Level = 0;
            this.IQBD_Meter.LevelMax = 100;
            this.IQBD_Meter.Location = new System.Drawing.Point(6, 26);
            this.IQBD_Meter.MeterScale = VU_MeterLibrary.MeterScale.Analog;
            this.IQBD_Meter.Name = "IQBD_Meter";
            this.IQBD_Meter.NeedleColor = System.Drawing.Color.Black;
            this.IQBD_Meter.PeakHold = false;
            this.IQBD_Meter.Peakms = 1000;
            this.IQBD_Meter.PeakNeedleColor = System.Drawing.Color.Red;
            this.IQBD_Meter.ShowDialOnly = false;
            this.IQBD_Meter.ShowLedPeak = false;
            this.IQBD_Meter.ShowTextInDial = false;
            this.IQBD_Meter.Size = new System.Drawing.Size(169, 28);
            this.IQBD_Meter.TabIndex = 199;
            this.IQBD_Meter.TextInDial = new string[] {
        "-40",
        "-20",
        "-10",
        "-5",
        "0",
        "+6"};
            this.IQBD_Meter.UseLedLight = true;
            this.IQBD_Meter.VerticalBar = false;
            this.IQBD_Meter.Visible = false;
            this.IQBD_Meter.VuText = "VU";
            this.IQBD_Meter.Load += new System.EventHandler(this.IQBD_Meter_Load);
            // 
            // IQ_TX_Band_button
            // 
            this.IQ_TX_Band_button.BackColor = System.Drawing.Color.Gainsboro;
            this.IQ_TX_Band_button.Enabled = false;
            this.IQ_TX_Band_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IQ_TX_Band_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQ_TX_Band_button.ForeColor = System.Drawing.Color.Black;
            this.IQ_TX_Band_button.Location = new System.Drawing.Point(573, 143);
            this.IQ_TX_Band_button.Name = "IQ_TX_Band_button";
            this.IQ_TX_Band_button.Size = new System.Drawing.Size(171, 26);
            this.IQ_TX_Band_button.TabIndex = 200;
            this.IQ_TX_Band_button.Text = "SELECT BAND";
            this.IQ_TX_Band_button.UseVisualStyleBackColor = false;
            this.IQ_TX_Band_button.Visible = false;
            this.IQ_TX_Band_button.Click += new System.EventHandler(this.IQ_TX_Band_button_Click);
            // 
            // IQ_TX_Button
            // 
            this.IQ_TX_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.IQ_TX_Button.Enabled = false;
            this.IQ_TX_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IQ_TX_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQ_TX_Button.ForeColor = System.Drawing.Color.Black;
            this.IQ_TX_Button.Location = new System.Drawing.Point(324, 83);
            this.IQ_TX_Button.Name = "IQ_TX_Button";
            this.IQ_TX_Button.Size = new System.Drawing.Size(130, 26);
            this.IQ_TX_Button.TabIndex = 199;
            this.IQ_TX_Button.Text = "POWER: 100";
            this.IQ_TX_Button.UseVisualStyleBackColor = false;
            this.IQ_TX_Button.Click += new System.EventHandler(this.IQ_TX_Button_Click);
            // 
            // IQBD_Reset_button8
            // 
            this.IQBD_Reset_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.IQBD_Reset_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IQBD_Reset_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQBD_Reset_button8.ForeColor = System.Drawing.Color.Black;
            this.IQBD_Reset_button8.Location = new System.Drawing.Point(392, 22);
            this.IQBD_Reset_button8.Name = "IQBD_Reset_button8";
            this.IQBD_Reset_button8.Size = new System.Drawing.Size(190, 26);
            this.IQBD_Reset_button8.TabIndex = 196;
            this.IQBD_Reset_button8.Text = "FACTORY DEFAULTS";
            this.IQBD_Reset_button8.UseVisualStyleBackColor = false;
            this.IQBD_Reset_button8.Click += new System.EventHandler(this.IQBD_Reset_button8_Click);
            // 
            // IQBD_Auto_button8
            // 
            this.IQBD_Auto_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.IQBD_Auto_button8.Enabled = false;
            this.IQBD_Auto_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IQBD_Auto_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQBD_Auto_button8.ForeColor = System.Drawing.Color.Black;
            this.IQBD_Auto_button8.Location = new System.Drawing.Point(185, 143);
            this.IQBD_Auto_button8.Name = "IQBD_Auto_button8";
            this.IQBD_Auto_button8.Size = new System.Drawing.Size(192, 26);
            this.IQBD_Auto_button8.TabIndex = 194;
            this.IQBD_Auto_button8.Text = "IQBD INTERNAL";
            this.IQBD_Auto_button8.UseVisualStyleBackColor = false;
            this.IQBD_Auto_button8.Visible = false;
            this.IQBD_Auto_button8.Click += new System.EventHandler(this.IQBD_Auto_button8_Click);
            // 
            // IQBD_TX_hScrollBar
            // 
            this.IQBD_TX_hScrollBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.IQBD_TX_hScrollBar.Enabled = false;
            this.IQBD_TX_hScrollBar.Location = new System.Drawing.Point(111, 112);
            this.IQBD_TX_hScrollBar.Maximum = 209;
            this.IQBD_TX_hScrollBar.Minimum = -200;
            this.IQBD_TX_hScrollBar.Name = "IQBD_TX_hScrollBar";
            this.IQBD_TX_hScrollBar.Size = new System.Drawing.Size(221, 20);
            this.IQBD_TX_hScrollBar.TabIndex = 189;
            this.toolTip.SetToolTip(this.IQBD_TX_hScrollBar, "MOVE SLIDER LEFT OR RIGHT\r\nTO ADJUST TX IQ BALANCE");
            this.IQBD_TX_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.IQBD_TX_hScrollBar_Scroll);
            this.IQBD_TX_hScrollBar.MouseEnter += new System.EventHandler(this.IQBD_hScrollBar1_Mouse_Enter);
            this.IQBD_TX_hScrollBar.MouseLeave += new System.EventHandler(this.IQBD_hScrollBar1_Mouse_Leave);
            // 
            // IQBD_TX_Power_hScrollBar
            // 
            this.IQBD_TX_Power_hScrollBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.IQBD_TX_Power_hScrollBar.Enabled = false;
            this.IQBD_TX_Power_hScrollBar.LargeChange = 5;
            this.IQBD_TX_Power_hScrollBar.Location = new System.Drawing.Point(446, 112);
            this.IQBD_TX_Power_hScrollBar.Maximum = 104;
            this.IQBD_TX_Power_hScrollBar.Name = "IQBD_TX_Power_hScrollBar";
            this.IQBD_TX_Power_hScrollBar.Size = new System.Drawing.Size(221, 20);
            this.IQBD_TX_Power_hScrollBar.TabIndex = 190;
            this.toolTip.SetToolTip(this.IQBD_TX_Power_hScrollBar, "ADJUST OUTPUT POWER");
            this.IQBD_TX_Power_hScrollBar.Value = 100;
            this.IQBD_TX_Power_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.IQBD_TX_Power_hScrollBar_Scroll);
            // 
            // IQBD_Monitor_label
            // 
            this.IQBD_Monitor_label.BackColor = System.Drawing.Color.Gainsboro;
            this.IQBD_Monitor_label.Enabled = false;
            this.IQBD_Monitor_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQBD_Monitor_label.ForeColor = System.Drawing.Color.Black;
            this.IQBD_Monitor_label.Location = new System.Drawing.Point(15, 57);
            this.IQBD_Monitor_label.Name = "IQBD_Monitor_label";
            this.IQBD_Monitor_label.Size = new System.Drawing.Size(98, 26);
            this.IQBD_Monitor_label.TabIndex = 187;
            this.IQBD_Monitor_label.Text = "I/Q VALUE";
            this.IQBD_Monitor_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IQBD_Monitor_label.Visible = false;
            this.IQBD_Monitor_label.Click += new System.EventHandler(this.IQBD_Monitor_label_Click);
            // 
            // IQBD_TX_Tune_button
            // 
            this.IQBD_TX_Tune_button.BackColor = System.Drawing.Color.Gainsboro;
            this.IQBD_TX_Tune_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IQBD_TX_Tune_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQBD_TX_Tune_button.ForeColor = System.Drawing.Color.Black;
            this.IQBD_TX_Tune_button.Location = new System.Drawing.Point(196, 22);
            this.IQBD_TX_Tune_button.Name = "IQBD_TX_Tune_button";
            this.IQBD_TX_Tune_button.Size = new System.Drawing.Size(190, 26);
            this.IQBD_TX_Tune_button.TabIndex = 188;
            this.IQBD_TX_Tune_button.Text = "TX OFF";
            this.IQBD_TX_Tune_button.UseVisualStyleBackColor = false;
            this.IQBD_TX_Tune_button.Click += new System.EventHandler(this.IQBD_TX_Tune_button_Click);
            // 
            // metertab
            // 
            this.metertab.BackColor = System.Drawing.Color.Black;
            this.metertab.Controls.Add(this.Server_Message_label);
            this.metertab.Controls.Add(this.Reset_Logs_button);
            this.metertab.Controls.Add(this.Beta_checkBox);
            this.metertab.Controls.Add(this.Spectrum_button9);
            this.metertab.Controls.Add(this.Colors_groupBox);
            this.metertab.Controls.Add(this.SMeter_groupBox4);
            this.metertab.Controls.Add(this.Freq_Comp_label32);
            this.metertab.Controls.Add(this.groupBox4);
            this.metertab.Controls.Add(this.Time_checkBox2);
            this.metertab.Controls.Add(this.Monitorbutton);
            this.metertab.Controls.Add(this.RPi_Temperature_label1);
            this.metertab.Controls.Add(this.AMP_Current_label5);
            this.metertab.Controls.Add(this.Amplifier_temperature_label58);
            this.metertab.Controls.Add(this.Temperature_label57);
            this.metertab.Controls.Add(this.Relay_Board_checkBox2);
            this.metertab.Controls.Add(this.MSCC_Core_Version_label45);
            this.metertab.Controls.Add(this.MSCC_Display_label44);
            this.metertab.Controls.Add(this.HR50_PPT_listBox1);
            this.metertab.Controls.Add(this.HR50_checkBox2);
            this.metertab.Controls.Add(this.label16);
            this.metertab.Controls.Add(this.HR50_listBox1);
            this.metertab.Controls.Add(this.button2);
            this.metertab.Controls.Add(this.SDRcore_Trans_Version);
            this.metertab.Controls.Add(this.SDRcore_Recv_Version_label16);
            this.metertab.Controls.Add(this.MS_SDR_Version_label16);
            this.metertab.Controls.Add(this.label15);
            this.metertab.Controls.Add(this.label12);
            this.metertab.Controls.Add(this.label11);
            this.metertab.Controls.Add(this.label6);
            this.metertab.Controls.Add(this.firmwarelabel16);
            this.metertab.Controls.Add(this.Transvertercheckbox);
            this.metertab.ForeColor = System.Drawing.Color.Black;
            this.metertab.Location = new System.Drawing.Point(4, 24);
            this.metertab.Name = "metertab";
            this.metertab.Padding = new System.Windows.Forms.Padding(3);
            this.metertab.Size = new System.Drawing.Size(806, 481);
            this.metertab.TabIndex = 7;
            this.metertab.Text = "  Audio / Sys  ";
            this.metertab.ToolTipText = "AUDIO AND SYSTEM CONTROLS";
            this.metertab.Click += new System.EventHandler(this.metertab_Click);
            this.metertab.Enter += new System.EventHandler(this.metertab_Enter);
            this.metertab.Leave += new System.EventHandler(this.metertab_Leave);
            // 
            // Server_Message_label
            // 
            this.Server_Message_label.BackColor = System.Drawing.Color.Gainsboro;
            this.Server_Message_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_Message_label.Location = new System.Drawing.Point(113, 287);
            this.Server_Message_label.Name = "Server_Message_label";
            this.Server_Message_label.Size = new System.Drawing.Size(566, 19);
            this.Server_Message_label.TabIndex = 217;
            this.Server_Message_label.Text = "SERVER MESSAGES";
            this.Server_Message_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.Server_Message_label, "SERVER MESSAGES WILL BE DISPLAYED HERE");
            this.Server_Message_label.Click += new System.EventHandler(this.Server_Message_label_Click);
            // 
            // Reset_Logs_button
            // 
            this.Reset_Logs_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Reset_Logs_button.Enabled = false;
            this.Reset_Logs_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset_Logs_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Logs_button.ForeColor = System.Drawing.Color.Black;
            this.Reset_Logs_button.Location = new System.Drawing.Point(642, 108);
            this.Reset_Logs_button.Name = "Reset_Logs_button";
            this.Reset_Logs_button.Size = new System.Drawing.Size(144, 24);
            this.Reset_Logs_button.TabIndex = 216;
            this.Reset_Logs_button.Text = "RESET LOGS\r\n(NOT YET IMPLEMENTED)";
            this.Reset_Logs_button.UseVisualStyleBackColor = false;
            this.Reset_Logs_button.Visible = false;
            this.Reset_Logs_button.Click += new System.EventHandler(this.Reset_Logs_button_Click);
            // 
            // Beta_checkBox
            // 
            this.Beta_checkBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Beta_checkBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beta_checkBox.ForeColor = System.Drawing.Color.Black;
            this.Beta_checkBox.Location = new System.Drawing.Point(642, 51);
            this.Beta_checkBox.Name = "Beta_checkBox";
            this.Beta_checkBox.Size = new System.Drawing.Size(144, 22);
            this.Beta_checkBox.TabIndex = 209;
            this.Beta_checkBox.Text = "BETA TEST";
            this.Beta_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Beta_checkBox.UseVisualStyleBackColor = false;
            this.Beta_checkBox.CheckedChanged += new System.EventHandler(this.Beta_checkBox_CheckedChanged);
            // 
            // Spectrum_button9
            // 
            this.Spectrum_button9.BackColor = System.Drawing.Color.Gainsboro;
            this.Spectrum_button9.Enabled = false;
            this.Spectrum_button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Spectrum_button9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spectrum_button9.ForeColor = System.Drawing.Color.Black;
            this.Spectrum_button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Spectrum_button9.Location = new System.Drawing.Point(290, 318);
            this.Spectrum_button9.Name = "Spectrum_button9";
            this.Spectrum_button9.Size = new System.Drawing.Size(19, 19);
            this.Spectrum_button9.TabIndex = 207;
            this.Spectrum_button9.Text = "S";
            this.Spectrum_button9.UseVisualStyleBackColor = false;
            this.Spectrum_button9.Visible = false;
            this.Spectrum_button9.Click += new System.EventHandler(this.Spectrum_button9_Click);
            // 
            // Colors_groupBox
            // 
            this.Colors_groupBox.Controls.Add(this.Color_Reset_button5);
            this.Colors_groupBox.Controls.Add(this.Button_Color_label49);
            this.Colors_groupBox.Controls.Add(this.Button_BG_Color_button5);
            this.Colors_groupBox.Controls.Add(this.Button_Text_Color_button5);
            this.Colors_groupBox.Controls.Add(this.button3);
            this.Colors_groupBox.Controls.Add(this.panel1);
            this.Colors_groupBox.Controls.Add(this.Freq_Color_button4);
            this.Colors_groupBox.Controls.Add(this.Boarder_Color_button4);
            this.Colors_groupBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colors_groupBox.ForeColor = System.Drawing.Color.White;
            this.Colors_groupBox.Location = new System.Drawing.Point(13, 138);
            this.Colors_groupBox.Name = "Colors_groupBox";
            this.Colors_groupBox.Size = new System.Drawing.Size(380, 144);
            this.Colors_groupBox.TabIndex = 156;
            this.Colors_groupBox.TabStop = false;
            this.Colors_groupBox.Text = "COLORS";
            // 
            // Color_Reset_button5
            // 
            this.Color_Reset_button5.BackColor = System.Drawing.Color.Gainsboro;
            this.Color_Reset_button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Color_Reset_button5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color_Reset_button5.ForeColor = System.Drawing.Color.Black;
            this.Color_Reset_button5.Location = new System.Drawing.Point(233, 58);
            this.Color_Reset_button5.Name = "Color_Reset_button5";
            this.Color_Reset_button5.Size = new System.Drawing.Size(73, 29);
            this.Color_Reset_button5.TabIndex = 158;
            this.Color_Reset_button5.Text = "RESET";
            this.toolTip.SetToolTip(this.Color_Reset_button5, "RESET ALL COLORS TO DEFAULT");
            this.Color_Reset_button5.UseMnemonic = false;
            this.Color_Reset_button5.UseVisualStyleBackColor = false;
            this.Color_Reset_button5.Click += new System.EventHandler(this.Color_Reset_button5_Click);
            // 
            // Button_Color_label49
            // 
            this.Button_Color_label49.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Color_label49.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Color_label49.ForeColor = System.Drawing.Color.Black;
            this.Button_Color_label49.Location = new System.Drawing.Point(122, 58);
            this.Button_Color_label49.Name = "Button_Color_label49";
            this.Button_Color_label49.Size = new System.Drawing.Size(46, 29);
            this.Button_Color_label49.TabIndex = 157;
            this.Button_Color_label49.Text = "PBs";
            this.Button_Color_label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_BG_Color_button5
            // 
            this.Button_BG_Color_button5.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_BG_Color_button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_BG_Color_button5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_BG_Color_button5.ForeColor = System.Drawing.Color.Black;
            this.Button_BG_Color_button5.Location = new System.Drawing.Point(186, 58);
            this.Button_BG_Color_button5.Name = "Button_BG_Color_button5";
            this.Button_BG_Color_button5.Size = new System.Drawing.Size(29, 29);
            this.Button_BG_Color_button5.TabIndex = 156;
            this.Button_BG_Color_button5.Text = "B";
            this.toolTip.SetToolTip(this.Button_BG_Color_button5, "SET BUTTON BACKGROUND COLOR");
            this.Button_BG_Color_button5.UseVisualStyleBackColor = false;
            this.Button_BG_Color_button5.Click += new System.EventHandler(this.Button_BG_Color_button5_Click);
            // 
            // Button_Text_Color_button5
            // 
            this.Button_Text_Color_button5.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Text_Color_button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Text_Color_button5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Text_Color_button5.ForeColor = System.Drawing.Color.Black;
            this.Button_Text_Color_button5.Location = new System.Drawing.Point(75, 58);
            this.Button_Text_Color_button5.Name = "Button_Text_Color_button5";
            this.Button_Text_Color_button5.Size = new System.Drawing.Size(29, 29);
            this.Button_Text_Color_button5.TabIndex = 155;
            this.Button_Text_Color_button5.Text = "F";
            this.toolTip.SetToolTip(this.Button_Text_Color_button5, "SET BUTTON TEXT COLOR");
            this.Button_Text_Color_button5.UseVisualStyleBackColor = false;
            this.Button_Text_Color_button5.Click += new System.EventHandler(this.Button_Text_Color_button5_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(6, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 29);
            this.button3.TabIndex = 148;
            this.button3.Text = "BACKGROUND";
            this.toolTip.SetToolTip(this.button3, "SET BACKGROUND COLOR");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.Freq_Digit_Test_label58);
            this.panel1.ForeColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(326, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 29);
            this.panel1.TabIndex = 154;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Freq_Digit_Test_label58
            // 
            this.Freq_Digit_Test_label58.AutoSize = true;
            this.Freq_Digit_Test_label58.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Digit_Test_label58.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Digit_Test_label58.ForeColor = System.Drawing.Color.Black;
            this.Freq_Digit_Test_label58.Location = new System.Drawing.Point(12, 2);
            this.Freq_Digit_Test_label58.Name = "Freq_Digit_Test_label58";
            this.Freq_Digit_Test_label58.Size = new System.Drawing.Size(24, 23);
            this.Freq_Digit_Test_label58.TabIndex = 151;
            this.Freq_Digit_Test_label58.Text = "8";
            this.Freq_Digit_Test_label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Freq_Digit_Test_label58.Click += new System.EventHandler(this.Freq_Digit_Test_label58_Click);
            // 
            // Freq_Color_button4
            // 
            this.Freq_Color_button4.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Color_button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Freq_Color_button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Color_button4.ForeColor = System.Drawing.Color.Black;
            this.Freq_Color_button4.Location = new System.Drawing.Point(254, 21);
            this.Freq_Color_button4.Name = "Freq_Color_button4";
            this.Freq_Color_button4.Size = new System.Drawing.Size(66, 29);
            this.Freq_Color_button4.TabIndex = 150;
            this.Freq_Color_button4.Text = "TEXT";
            this.toolTip.SetToolTip(this.Freq_Color_button4, "SET MAIN FREQUENCY\r\nTEXT COLOR");
            this.Freq_Color_button4.UseVisualStyleBackColor = false;
            this.Freq_Color_button4.Click += new System.EventHandler(this.Freq_Color_button4_Click);
            // 
            // Boarder_Color_button4
            // 
            this.Boarder_Color_button4.BackColor = System.Drawing.Color.Gainsboro;
            this.Boarder_Color_button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Boarder_Color_button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boarder_Color_button4.ForeColor = System.Drawing.Color.Black;
            this.Boarder_Color_button4.Location = new System.Drawing.Point(152, 21);
            this.Boarder_Color_button4.Name = "Boarder_Color_button4";
            this.Boarder_Color_button4.Size = new System.Drawing.Size(96, 29);
            this.Boarder_Color_button4.TabIndex = 153;
            this.Boarder_Color_button4.Text = "BORDER";
            this.toolTip.SetToolTip(this.Boarder_Color_button4, "SET MAIN FREQUENCY\r\nBORDER COLOR");
            this.Boarder_Color_button4.UseVisualStyleBackColor = false;
            this.Boarder_Color_button4.Click += new System.EventHandler(this.Boarder_Color_button4_Click);
            // 
            // SMeter_groupBox4
            // 
            this.SMeter_groupBox4.Controls.Add(this.Smeter_Hold_Time_button);
            this.SMeter_groupBox4.Controls.Add(this.Peak_Needle_Delay_button);
            this.SMeter_groupBox4.Controls.Add(this.Smeter_Peak_Needle_Color_button);
            this.SMeter_groupBox4.Controls.Add(this.S_Meter_Color_button);
            this.SMeter_groupBox4.Controls.Add(this.VU_Blink_button);
            this.SMeter_groupBox4.Controls.Add(this.Smeter_Dbm_button);
            this.SMeter_groupBox4.Controls.Add(this.Smeter_Decay);
            this.SMeter_groupBox4.Controls.Add(this.Temperature_Selection_Button);
            this.SMeter_groupBox4.Controls.Add(this.label4);
            this.SMeter_groupBox4.Controls.Add(this.Main_Meter_Temperature_Preferred);
            this.SMeter_groupBox4.Controls.Add(this.Main_Meter_ALC_Preferred);
            this.SMeter_groupBox4.Controls.Add(this.Main_Meter_I_Preferred);
            this.SMeter_groupBox4.Controls.Add(this.Main_Meter_SWR_Preferred);
            this.SMeter_groupBox4.Controls.Add(this.Main_Meter_Power_Preferred);
            this.SMeter_groupBox4.Controls.Add(this.Smeter_Average_button8);
            this.SMeter_groupBox4.Controls.Add(this.Peak_Needle_checkBox2);
            this.SMeter_groupBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMeter_groupBox4.ForeColor = System.Drawing.Color.White;
            this.SMeter_groupBox4.Location = new System.Drawing.Point(400, 138);
            this.SMeter_groupBox4.Name = "SMeter_groupBox4";
            this.SMeter_groupBox4.Size = new System.Drawing.Size(380, 144);
            this.SMeter_groupBox4.TabIndex = 178;
            this.SMeter_groupBox4.TabStop = false;
            this.SMeter_groupBox4.Text = "MAIN METER";
            this.SMeter_groupBox4.Enter += new System.EventHandler(this.SMeter_groupBox4_Enter);
            // 
            // Smeter_Hold_Time_button
            // 
            this.Smeter_Hold_Time_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Smeter_Hold_Time_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Smeter_Hold_Time_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smeter_Hold_Time_button.ForeColor = System.Drawing.Color.Black;
            this.Smeter_Hold_Time_button.Location = new System.Drawing.Point(52, 20);
            this.Smeter_Hold_Time_button.Name = "Smeter_Hold_Time_button";
            this.Smeter_Hold_Time_button.Size = new System.Drawing.Size(39, 26);
            this.Smeter_Hold_Time_button.TabIndex = 219;
            this.Smeter_Hold_Time_button.Text = "10";
            this.toolTip.SetToolTip(this.Smeter_Hold_Time_button, "S METER DECAY TIME (ms)");
            this.Smeter_Hold_Time_button.UseVisualStyleBackColor = false;
            this.Smeter_Hold_Time_button.Click += new System.EventHandler(this.Smeter_Hold_Time_button_Click);
            // 
            // Peak_Needle_Delay_button
            // 
            this.Peak_Needle_Delay_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Peak_Needle_Delay_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Peak_Needle_Delay_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peak_Needle_Delay_button.ForeColor = System.Drawing.Color.Black;
            this.Peak_Needle_Delay_button.Location = new System.Drawing.Point(148, 51);
            this.Peak_Needle_Delay_button.Name = "Peak_Needle_Delay_button";
            this.Peak_Needle_Delay_button.Size = new System.Drawing.Size(24, 24);
            this.Peak_Needle_Delay_button.TabIndex = 218;
            this.Peak_Needle_Delay_button.Text = "1";
            this.toolTip.SetToolTip(this.Peak_Needle_Delay_button, "PEAK NEEDLE HOLD TIME");
            this.Peak_Needle_Delay_button.UseVisualStyleBackColor = false;
            this.Peak_Needle_Delay_button.Click += new System.EventHandler(this.Peak_Needle_Delay_button_Click);
            // 
            // Smeter_Peak_Needle_Color_button
            // 
            this.Smeter_Peak_Needle_Color_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Smeter_Peak_Needle_Color_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Smeter_Peak_Needle_Color_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smeter_Peak_Needle_Color_button.ForeColor = System.Drawing.Color.Black;
            this.Smeter_Peak_Needle_Color_button.Location = new System.Drawing.Point(206, 50);
            this.Smeter_Peak_Needle_Color_button.Name = "Smeter_Peak_Needle_Color_button";
            this.Smeter_Peak_Needle_Color_button.Size = new System.Drawing.Size(126, 26);
            this.Smeter_Peak_Needle_Color_button.TabIndex = 217;
            this.Smeter_Peak_Needle_Color_button.Text = "RED";
            this.toolTip.SetToolTip(this.Smeter_Peak_Needle_Color_button, "PEAK NEEDLE COLOR");
            this.Smeter_Peak_Needle_Color_button.UseVisualStyleBackColor = false;
            this.Smeter_Peak_Needle_Color_button.Click += new System.EventHandler(this.Smeter_Peak_Needle_Color_button_Click);
            // 
            // S_Meter_Color_button
            // 
            this.S_Meter_Color_button.BackColor = System.Drawing.Color.Gainsboro;
            this.S_Meter_Color_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S_Meter_Color_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Meter_Color_button.ForeColor = System.Drawing.Color.Black;
            this.S_Meter_Color_button.Location = new System.Drawing.Point(206, 20);
            this.S_Meter_Color_button.Name = "S_Meter_Color_button";
            this.S_Meter_Color_button.Size = new System.Drawing.Size(126, 26);
            this.S_Meter_Color_button.TabIndex = 216;
            this.S_Meter_Color_button.Text = "MOCCASIN";
            this.toolTip.SetToolTip(this.S_Meter_Color_button, "S METER BACKGROUND COLOR");
            this.S_Meter_Color_button.UseVisualStyleBackColor = false;
            this.S_Meter_Color_button.Click += new System.EventHandler(this.S_Meter_Color_button_Click);
            // 
            // VU_Blink_button
            // 
            this.VU_Blink_button.BackColor = System.Drawing.Color.Gainsboro;
            this.VU_Blink_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.VU_Blink_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VU_Blink_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VU_Blink_button.ForeColor = System.Drawing.Color.Black;
            this.VU_Blink_button.Location = new System.Drawing.Point(227, 113);
            this.VU_Blink_button.Name = "VU_Blink_button";
            this.VU_Blink_button.Size = new System.Drawing.Size(106, 26);
            this.VU_Blink_button.TabIndex = 215;
            this.VU_Blink_button.Text = "VU BLINK";
            this.VU_Blink_button.UseVisualStyleBackColor = false;
            this.VU_Blink_button.Click += new System.EventHandler(this.VU_Blink_button_Click);
            // 
            // Smeter_Dbm_button
            // 
            this.Smeter_Dbm_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Smeter_Dbm_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Smeter_Dbm_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smeter_Dbm_button.ForeColor = System.Drawing.Color.Black;
            this.Smeter_Dbm_button.Location = new System.Drawing.Point(47, 113);
            this.Smeter_Dbm_button.Name = "Smeter_Dbm_button";
            this.Smeter_Dbm_button.Size = new System.Drawing.Size(64, 26);
            this.Smeter_Dbm_button.TabIndex = 214;
            this.Smeter_Dbm_button.Text = "dBm";
            this.toolTip.SetToolTip(this.Smeter_Dbm_button, "S METER TEXT DISPLAY\r\ndbM / S UNITS");
            this.Smeter_Dbm_button.UseVisualStyleBackColor = false;
            this.Smeter_Dbm_button.Click += new System.EventHandler(this.Smeter_Dbm_button_Click);
            // 
            // Smeter_Decay
            // 
            this.Smeter_Decay.BackColor = System.Drawing.Color.Gainsboro;
            this.Smeter_Decay.Checked = true;
            this.Smeter_Decay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Smeter_Decay.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smeter_Decay.ForeColor = System.Drawing.Color.Black;
            this.Smeter_Decay.Location = new System.Drawing.Point(110, 20);
            this.Smeter_Decay.Name = "Smeter_Decay";
            this.Smeter_Decay.Size = new System.Drawing.Size(77, 26);
            this.Smeter_Decay.TabIndex = 212;
            this.Smeter_Decay.Text = "HOLD ";
            this.toolTip.SetToolTip(this.Smeter_Decay, "S METER HOLD ON/OFF");
            this.Smeter_Decay.UseVisualStyleBackColor = false;
            this.Smeter_Decay.CheckedChanged += new System.EventHandler(this.Smeter_Decay_CheckedChanged);
            // 
            // Temperature_Selection_Button
            // 
            this.Temperature_Selection_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Temperature_Selection_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Temperature_Selection_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperature_Selection_Button.ForeColor = System.Drawing.Color.Black;
            this.Temperature_Selection_Button.Location = new System.Drawing.Point(182, 113);
            this.Temperature_Selection_Button.Name = "Temperature_Selection_Button";
            this.Temperature_Selection_Button.Size = new System.Drawing.Size(29, 26);
            this.Temperature_Selection_Button.TabIndex = 208;
            this.Temperature_Selection_Button.Text = "A";
            this.toolTip.SetToolTip(this.Temperature_Selection_Button, "PREFERED TEMPERATURE DISPLAY\r\nA - AMPLIFIER\r\nP - PROFICIO");
            this.Temperature_Selection_Button.UseVisualStyleBackColor = false;
            this.Temperature_Selection_Button.Click += new System.EventHandler(this.Temperature_Selection_Button_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 211;
            this.label4.Text = "METER MODE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label4, "PREFERED METER MODE\r\nIN TUNE MODE");
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Main_Meter_Temperature_Preferred
            // 
            this.Main_Meter_Temperature_Preferred.BackColor = System.Drawing.Color.Gainsboro;
            this.Main_Meter_Temperature_Preferred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Main_Meter_Temperature_Preferred.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Meter_Temperature_Preferred.ForeColor = System.Drawing.Color.Black;
            this.Main_Meter_Temperature_Preferred.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Main_Meter_Temperature_Preferred.Location = new System.Drawing.Point(299, 81);
            this.Main_Meter_Temperature_Preferred.Name = "Main_Meter_Temperature_Preferred";
            this.Main_Meter_Temperature_Preferred.Size = new System.Drawing.Size(19, 26);
            this.Main_Meter_Temperature_Preferred.TabIndex = 210;
            this.Main_Meter_Temperature_Preferred.Text = "T";
            this.toolTip.SetToolTip(this.Main_Meter_Temperature_Preferred, "TEMPERATURE");
            this.Main_Meter_Temperature_Preferred.UseVisualStyleBackColor = false;
            this.Main_Meter_Temperature_Preferred.Click += new System.EventHandler(this.Main_Meter_Temperature_Preferred_Click);
            // 
            // Main_Meter_ALC_Preferred
            // 
            this.Main_Meter_ALC_Preferred.BackColor = System.Drawing.Color.Gainsboro;
            this.Main_Meter_ALC_Preferred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Main_Meter_ALC_Preferred.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Meter_ALC_Preferred.ForeColor = System.Drawing.Color.Black;
            this.Main_Meter_ALC_Preferred.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Main_Meter_ALC_Preferred.Location = new System.Drawing.Point(249, 81);
            this.Main_Meter_ALC_Preferred.Name = "Main_Meter_ALC_Preferred";
            this.Main_Meter_ALC_Preferred.Size = new System.Drawing.Size(19, 26);
            this.Main_Meter_ALC_Preferred.TabIndex = 207;
            this.Main_Meter_ALC_Preferred.Text = "A";
            this.toolTip.SetToolTip(this.Main_Meter_ALC_Preferred, "ALC");
            this.Main_Meter_ALC_Preferred.UseVisualStyleBackColor = false;
            this.Main_Meter_ALC_Preferred.Click += new System.EventHandler(this.Main_Meter_ALC_Preferred_Click);
            // 
            // Main_Meter_I_Preferred
            // 
            this.Main_Meter_I_Preferred.BackColor = System.Drawing.Color.Gainsboro;
            this.Main_Meter_I_Preferred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Main_Meter_I_Preferred.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Meter_I_Preferred.ForeColor = System.Drawing.Color.Black;
            this.Main_Meter_I_Preferred.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Main_Meter_I_Preferred.Location = new System.Drawing.Point(274, 81);
            this.Main_Meter_I_Preferred.Name = "Main_Meter_I_Preferred";
            this.Main_Meter_I_Preferred.Size = new System.Drawing.Size(19, 26);
            this.Main_Meter_I_Preferred.TabIndex = 208;
            this.Main_Meter_I_Preferred.Text = "I";
            this.toolTip.SetToolTip(this.Main_Meter_I_Preferred, "CURRENT (I)");
            this.Main_Meter_I_Preferred.UseVisualStyleBackColor = false;
            this.Main_Meter_I_Preferred.Click += new System.EventHandler(this.Main_Meter_I_Preferred_Click);
            // 
            // Main_Meter_SWR_Preferred
            // 
            this.Main_Meter_SWR_Preferred.BackColor = System.Drawing.Color.Gainsboro;
            this.Main_Meter_SWR_Preferred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Main_Meter_SWR_Preferred.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Meter_SWR_Preferred.ForeColor = System.Drawing.Color.Black;
            this.Main_Meter_SWR_Preferred.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Main_Meter_SWR_Preferred.Location = new System.Drawing.Point(199, 81);
            this.Main_Meter_SWR_Preferred.Name = "Main_Meter_SWR_Preferred";
            this.Main_Meter_SWR_Preferred.Size = new System.Drawing.Size(19, 26);
            this.Main_Meter_SWR_Preferred.TabIndex = 209;
            this.Main_Meter_SWR_Preferred.Text = "S";
            this.toolTip.SetToolTip(this.Main_Meter_SWR_Preferred, "SWR");
            this.Main_Meter_SWR_Preferred.UseVisualStyleBackColor = false;
            this.Main_Meter_SWR_Preferred.Click += new System.EventHandler(this.Main_Meter_SWR_Preferred_Click);
            // 
            // Main_Meter_Power_Preferred
            // 
            this.Main_Meter_Power_Preferred.BackColor = System.Drawing.Color.Gainsboro;
            this.Main_Meter_Power_Preferred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Main_Meter_Power_Preferred.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Meter_Power_Preferred.ForeColor = System.Drawing.Color.Black;
            this.Main_Meter_Power_Preferred.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Main_Meter_Power_Preferred.Location = new System.Drawing.Point(224, 81);
            this.Main_Meter_Power_Preferred.Name = "Main_Meter_Power_Preferred";
            this.Main_Meter_Power_Preferred.Size = new System.Drawing.Size(19, 26);
            this.Main_Meter_Power_Preferred.TabIndex = 206;
            this.Main_Meter_Power_Preferred.Text = "P";
            this.toolTip.SetToolTip(this.Main_Meter_Power_Preferred, "POWER");
            this.Main_Meter_Power_Preferred.UseVisualStyleBackColor = false;
            this.Main_Meter_Power_Preferred.Click += new System.EventHandler(this.Main_Meter_Power_Preferred_Click);
            // 
            // Smeter_Average_button8
            // 
            this.Smeter_Average_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Smeter_Average_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Smeter_Average_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smeter_Average_button8.ForeColor = System.Drawing.Color.Black;
            this.Smeter_Average_button8.Location = new System.Drawing.Point(127, 113);
            this.Smeter_Average_button8.Name = "Smeter_Average_button8";
            this.Smeter_Average_button8.Size = new System.Drawing.Size(39, 26);
            this.Smeter_Average_button8.TabIndex = 185;
            this.Smeter_Average_button8.Text = "20";
            this.toolTip.SetToolTip(this.Smeter_Average_button8, "S METER AVERAGING");
            this.Smeter_Average_button8.UseVisualStyleBackColor = false;
            this.Smeter_Average_button8.Click += new System.EventHandler(this.Smeter_Average_button8_Click);
            // 
            // Peak_Needle_checkBox2
            // 
            this.Peak_Needle_checkBox2.AutoSize = true;
            this.Peak_Needle_checkBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.Peak_Needle_checkBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peak_Needle_checkBox2.ForeColor = System.Drawing.Color.Black;
            this.Peak_Needle_checkBox2.Location = new System.Drawing.Point(64, 52);
            this.Peak_Needle_checkBox2.Name = "Peak_Needle_checkBox2";
            this.Peak_Needle_checkBox2.Size = new System.Drawing.Size(66, 22);
            this.Peak_Needle_checkBox2.TabIndex = 178;
            this.Peak_Needle_checkBox2.Text = "Peak";
            this.toolTip.SetToolTip(this.Peak_Needle_checkBox2, "PEAK NEEDLE ON/OFF");
            this.Peak_Needle_checkBox2.UseVisualStyleBackColor = false;
            this.Peak_Needle_checkBox2.CheckedChanged += new System.EventHandler(this.Peak_Needle_checkBox2_CheckedChanged);
            // 
            // Freq_Comp_label32
            // 
            this.Freq_Comp_label32.BackColor = System.Drawing.Color.Gainsboro;
            this.Freq_Comp_label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Freq_Comp_label32.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq_Comp_label32.ForeColor = System.Drawing.Color.Black;
            this.Freq_Comp_label32.Location = new System.Drawing.Point(315, 314);
            this.Freq_Comp_label32.Name = "Freq_Comp_label32";
            this.Freq_Comp_label32.Size = new System.Drawing.Size(163, 23);
            this.Freq_Comp_label32.TabIndex = 183;
            this.Freq_Comp_label32.Text = "Freq Comp: 0 Hz";
            this.Freq_Comp_label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Freq_Comp_label32.Click += new System.EventHandler(this.Freq_Comp_label32_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Mic_Digital_Pre_Gain_button);
            this.groupBox4.Controls.Add(this.Compression_Up_button);
            this.groupBox4.Controls.Add(this.Compression_Down_button);
            this.groupBox4.Controls.Add(this.Digital_Volume_Attn_button5);
            this.groupBox4.Controls.Add(this.Volume_Attn_button8);
            this.groupBox4.Controls.Add(this.Mic_Pre_Gain_button8);
            this.groupBox4.Controls.Add(this.Compression_Level_hScrollBar1);
            this.groupBox4.Controls.Add(this.Compression_button2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Compression_label44);
            this.groupBox4.Controls.Add(this.Mic_Gain_label2);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(158, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(478, 117);
            this.groupBox4.TabIndex = 182;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AUDIO";
            // 
            // Mic_Digital_Pre_Gain_button
            // 
            this.Mic_Digital_Pre_Gain_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Mic_Digital_Pre_Gain_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mic_Digital_Pre_Gain_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mic_Digital_Pre_Gain_button.ForeColor = System.Drawing.Color.Black;
            this.Mic_Digital_Pre_Gain_button.Location = new System.Drawing.Point(88, 49);
            this.Mic_Digital_Pre_Gain_button.Name = "Mic_Digital_Pre_Gain_button";
            this.Mic_Digital_Pre_Gain_button.Size = new System.Drawing.Size(29, 29);
            this.Mic_Digital_Pre_Gain_button.TabIndex = 218;
            this.Mic_Digital_Pre_Gain_button.Text = "0";
            this.toolTip.SetToolTip(this.Mic_Digital_Pre_Gain_button, "DIGITAL GAIN");
            this.Mic_Digital_Pre_Gain_button.UseVisualStyleBackColor = false;
            this.Mic_Digital_Pre_Gain_button.Click += new System.EventHandler(this.Mic_Digital_Pre_Gain_button_Click);
            // 
            // Compression_Up_button
            // 
            this.Compression_Up_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Compression_Up_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compression_Up_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compression_Up_button.ForeColor = System.Drawing.Color.Black;
            this.Compression_Up_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Compression_Up_button.Location = new System.Drawing.Point(294, 75);
            this.Compression_Up_button.Name = "Compression_Up_button";
            this.Compression_Up_button.Size = new System.Drawing.Size(21, 21);
            this.Compression_Up_button.TabIndex = 214;
            this.Compression_Up_button.UseVisualStyleBackColor = false;
            this.Compression_Up_button.Click += new System.EventHandler(this.Compression_Up_button_Click);
            this.Compression_Up_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Compression_Up_button_Mouse_Down);
            this.Compression_Up_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Compression_Up_button_Mouse_Up);
            // 
            // Compression_Down_button
            // 
            this.Compression_Down_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Compression_Down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compression_Down_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compression_Down_button.ForeColor = System.Drawing.Color.Black;
            this.Compression_Down_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Compression_Down_button.Location = new System.Drawing.Point(164, 75);
            this.Compression_Down_button.Name = "Compression_Down_button";
            this.Compression_Down_button.Size = new System.Drawing.Size(21, 21);
            this.Compression_Down_button.TabIndex = 213;
            this.Compression_Down_button.UseVisualStyleBackColor = false;
            this.Compression_Down_button.Click += new System.EventHandler(this.Compression_Down_button_Click);
            this.Compression_Down_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Compression_Down_button_Mouse_Down);
            this.Compression_Down_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Compression_Down_button_Mouse_Up);
            // 
            // Digital_Volume_Attn_button5
            // 
            this.Digital_Volume_Attn_button5.BackColor = System.Drawing.Color.Gainsboro;
            this.Digital_Volume_Attn_button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Digital_Volume_Attn_button5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digital_Volume_Attn_button5.ForeColor = System.Drawing.Color.Black;
            this.Digital_Volume_Attn_button5.Location = new System.Drawing.Point(406, 49);
            this.Digital_Volume_Attn_button5.Name = "Digital_Volume_Attn_button5";
            this.Digital_Volume_Attn_button5.Size = new System.Drawing.Size(29, 29);
            this.Digital_Volume_Attn_button5.TabIndex = 184;
            this.Digital_Volume_Attn_button5.Text = "0";
            this.toolTip.SetToolTip(this.Digital_Volume_Attn_button5, "DIGITAL ATTENUATION\r\n");
            this.Digital_Volume_Attn_button5.UseVisualStyleBackColor = false;
            this.Digital_Volume_Attn_button5.Click += new System.EventHandler(this.Digital_Volume_Attn_button5_Click);
            // 
            // Volume_Attn_button8
            // 
            this.Volume_Attn_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Volume_Attn_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Volume_Attn_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume_Attn_button8.ForeColor = System.Drawing.Color.Black;
            this.Volume_Attn_button8.Location = new System.Drawing.Point(358, 49);
            this.Volume_Attn_button8.Name = "Volume_Attn_button8";
            this.Volume_Attn_button8.Size = new System.Drawing.Size(29, 29);
            this.Volume_Attn_button8.TabIndex = 183;
            this.Volume_Attn_button8.Text = "0";
            this.toolTip.SetToolTip(this.Volume_Attn_button8, "PHONE ATTENUATION");
            this.Volume_Attn_button8.UseVisualStyleBackColor = false;
            this.Volume_Attn_button8.Click += new System.EventHandler(this.Volume_Attn_button8_Click);
            // 
            // Mic_Pre_Gain_button8
            // 
            this.Mic_Pre_Gain_button8.BackColor = System.Drawing.Color.Gainsboro;
            this.Mic_Pre_Gain_button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mic_Pre_Gain_button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mic_Pre_Gain_button8.ForeColor = System.Drawing.Color.Black;
            this.Mic_Pre_Gain_button8.Location = new System.Drawing.Point(41, 49);
            this.Mic_Pre_Gain_button8.Name = "Mic_Pre_Gain_button8";
            this.Mic_Pre_Gain_button8.Size = new System.Drawing.Size(29, 29);
            this.Mic_Pre_Gain_button8.TabIndex = 182;
            this.Mic_Pre_Gain_button8.Text = "0";
            this.toolTip.SetToolTip(this.Mic_Pre_Gain_button8, "PHONE GAIN");
            this.Mic_Pre_Gain_button8.UseVisualStyleBackColor = false;
            this.Mic_Pre_Gain_button8.Click += new System.EventHandler(this.Mic_Pre_Gain_button8_Click);
            // 
            // Compression_Level_hScrollBar1
            // 
            this.Compression_Level_hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Compression_Level_hScrollBar1.LargeChange = 5;
            this.Compression_Level_hScrollBar1.Location = new System.Drawing.Point(164, 49);
            this.Compression_Level_hScrollBar1.Maximum = 24;
            this.Compression_Level_hScrollBar1.Name = "Compression_Level_hScrollBar1";
            this.Compression_Level_hScrollBar1.Size = new System.Drawing.Size(151, 18);
            this.Compression_Level_hScrollBar1.TabIndex = 161;
            this.Compression_Level_hScrollBar1.TabStop = true;
            this.Compression_Level_hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Compression_Level_hScrollBar1_Scroll);
            this.Compression_Level_hScrollBar1.MouseEnter += new System.EventHandler(this.Compression_Level_hScrollBar1_mouseenter);
            this.Compression_Level_hScrollBar1.MouseLeave += new System.EventHandler(this.Compression_Level_hScrollBar1_mouseleave);
            // 
            // Compression_button2
            // 
            this.Compression_button2.BackColor = System.Drawing.Color.Gainsboro;
            this.Compression_button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Compression_button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compression_button2.ForeColor = System.Drawing.Color.Black;
            this.Compression_button2.Location = new System.Drawing.Point(164, 19);
            this.Compression_button2.Name = "Compression_button2";
            this.Compression_button2.Size = new System.Drawing.Size(151, 23);
            this.Compression_button2.TabIndex = 160;
            this.Compression_button2.Text = "COMPRESSION";
            this.Compression_button2.UseVisualStyleBackColor = false;
            this.Compression_button2.Click += new System.EventHandler(this.Compression_button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(322, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 180;
            this.label1.Text = "VOLUME ATTN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Compression_label44
            // 
            this.Compression_label44.BackColor = System.Drawing.Color.Gainsboro;
            this.Compression_label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Compression_label44.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compression_label44.ForeColor = System.Drawing.Color.Black;
            this.Compression_label44.Location = new System.Drawing.Point(205, 75);
            this.Compression_label44.Name = "Compression_label44";
            this.Compression_label44.Size = new System.Drawing.Size(65, 21);
            this.Compression_label44.TabIndex = 162;
            this.Compression_label44.Text = "0";
            this.Compression_label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mic_Gain_label2
            // 
            this.Mic_Gain_label2.BackColor = System.Drawing.Color.Gainsboro;
            this.Mic_Gain_label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Mic_Gain_label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mic_Gain_label2.ForeColor = System.Drawing.Color.Black;
            this.Mic_Gain_label2.Location = new System.Drawing.Point(6, 19);
            this.Mic_Gain_label2.Name = "Mic_Gain_label2";
            this.Mic_Gain_label2.Size = new System.Drawing.Size(151, 23);
            this.Mic_Gain_label2.TabIndex = 164;
            this.Mic_Gain_label2.Text = "MIC GAIN";
            this.Mic_Gain_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mic_Gain_label2.Click += new System.EventHandler(this.Mic_Gain_label2_Click);
            // 
            // Time_checkBox2
            // 
            this.Time_checkBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.Time_checkBox2.Enabled = false;
            this.Time_checkBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_checkBox2.ForeColor = System.Drawing.Color.Black;
            this.Time_checkBox2.Location = new System.Drawing.Point(8, 16);
            this.Time_checkBox2.Name = "Time_checkBox2";
            this.Time_checkBox2.Size = new System.Drawing.Size(144, 22);
            this.Time_checkBox2.TabIndex = 179;
            this.Time_checkBox2.Text = "TIME DISPL";
            this.toolTip.SetToolTip(this.Time_checkBox2, "TIME DISPLAY ON MAIN TAB");
            this.Time_checkBox2.UseVisualStyleBackColor = false;
            this.Time_checkBox2.CheckedChanged += new System.EventHandler(this.Time_checkBox2_CheckedChanged);
            // 
            // Monitorbutton
            // 
            this.Monitorbutton.BackColor = System.Drawing.Color.Gainsboro;
            this.Monitorbutton.Enabled = false;
            this.Monitorbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Monitorbutton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitorbutton.ForeColor = System.Drawing.Color.Black;
            this.Monitorbutton.Location = new System.Drawing.Point(493, 311);
            this.Monitorbutton.Name = "Monitorbutton";
            this.Monitorbutton.Size = new System.Drawing.Size(114, 30);
            this.Monitorbutton.TabIndex = 67;
            this.Monitorbutton.Text = "Log Monitor";
            this.Monitorbutton.UseVisualStyleBackColor = false;
            this.Monitorbutton.Visible = false;
            this.Monitorbutton.Click += new System.EventHandler(this.Monitorbutton_Click);
            // 
            // RPi_Temperature_label1
            // 
            this.RPi_Temperature_label1.BackColor = System.Drawing.Color.Gainsboro;
            this.RPi_Temperature_label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RPi_Temperature_label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPi_Temperature_label1.ForeColor = System.Drawing.Color.Black;
            this.RPi_Temperature_label1.Location = new System.Drawing.Point(206, 346);
            this.RPi_Temperature_label1.Name = "RPi_Temperature_label1";
            this.RPi_Temperature_label1.Size = new System.Drawing.Size(190, 23);
            this.RPi_Temperature_label1.TabIndex = 166;
            this.RPi_Temperature_label1.Text = "PROCESSOR: 0°C";
            this.RPi_Temperature_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RPi_Temperature_label1.Click += new System.EventHandler(this.RPi_Temperature_label1_Click);
            // 
            // AMP_Current_label5
            // 
            this.AMP_Current_label5.BackColor = System.Drawing.Color.Gainsboro;
            this.AMP_Current_label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AMP_Current_label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMP_Current_label5.ForeColor = System.Drawing.Color.Black;
            this.AMP_Current_label5.Location = new System.Drawing.Point(588, 346);
            this.AMP_Current_label5.Name = "AMP_Current_label5";
            this.AMP_Current_label5.Size = new System.Drawing.Size(190, 23);
            this.AMP_Current_label5.TabIndex = 145;
            this.AMP_Current_label5.Text = "PA I (ma): 00000";
            this.AMP_Current_label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AMP_Current_label5.Click += new System.EventHandler(this.AMP_Current_label5_Click);
            // 
            // Amplifier_temperature_label58
            // 
            this.Amplifier_temperature_label58.BackColor = System.Drawing.Color.Gainsboro;
            this.Amplifier_temperature_label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Amplifier_temperature_label58.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amplifier_temperature_label58.ForeColor = System.Drawing.Color.Black;
            this.Amplifier_temperature_label58.Location = new System.Drawing.Point(397, 346);
            this.Amplifier_temperature_label58.Name = "Amplifier_temperature_label58";
            this.Amplifier_temperature_label58.Size = new System.Drawing.Size(190, 23);
            this.Amplifier_temperature_label58.TabIndex = 144;
            this.Amplifier_temperature_label58.Text = "PA TEMP: 0°C";
            this.Amplifier_temperature_label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Amplifier_temperature_label58.Click += new System.EventHandler(this.Amplifier_temperature_label58_Click);
            // 
            // Temperature_label57
            // 
            this.Temperature_label57.BackColor = System.Drawing.Color.Gainsboro;
            this.Temperature_label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Temperature_label57.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperature_label57.ForeColor = System.Drawing.Color.Black;
            this.Temperature_label57.Location = new System.Drawing.Point(15, 346);
            this.Temperature_label57.Name = "Temperature_label57";
            this.Temperature_label57.Size = new System.Drawing.Size(190, 23);
            this.Temperature_label57.TabIndex = 141;
            this.Temperature_label57.Text = "PROFICIO: WARMING";
            this.Temperature_label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Temperature_label57.Click += new System.EventHandler(this.Temperature_label57_Click_1);
            // 
            // Relay_Board_checkBox2
            // 
            this.Relay_Board_checkBox2.AutoSize = true;
            this.Relay_Board_checkBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.Relay_Board_checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relay_Board_checkBox2.ForeColor = System.Drawing.Color.Black;
            this.Relay_Board_checkBox2.Location = new System.Drawing.Point(10, 318);
            this.Relay_Board_checkBox2.Name = "Relay_Board_checkBox2";
            this.Relay_Board_checkBox2.Size = new System.Drawing.Size(122, 20);
            this.Relay_Board_checkBox2.TabIndex = 131;
            this.Relay_Board_checkBox2.Text = "RELAY BOARD";
            this.Relay_Board_checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Relay_Board_checkBox2.UseVisualStyleBackColor = false;
            this.Relay_Board_checkBox2.Visible = false;
            this.Relay_Board_checkBox2.CheckedChanged += new System.EventHandler(this.Relay_Board_checkBox2_CheckedChanged);
            // 
            // MSCC_Core_Version_label45
            // 
            this.MSCC_Core_Version_label45.BackColor = System.Drawing.Color.Gainsboro;
            this.MSCC_Core_Version_label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MSCC_Core_Version_label45.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSCC_Core_Version_label45.Location = new System.Drawing.Point(39, 404);
            this.MSCC_Core_Version_label45.Name = "MSCC_Core_Version_label45";
            this.MSCC_Core_Version_label45.Size = new System.Drawing.Size(123, 23);
            this.MSCC_Core_Version_label45.TabIndex = 126;
            this.MSCC_Core_Version_label45.Text = "Firmware Version: ";
            this.MSCC_Core_Version_label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MSCC_Core_Version_label45.Click += new System.EventHandler(this.MSCC_Core_Version_label45_Click);
            // 
            // MSCC_Display_label44
            // 
            this.MSCC_Display_label44.BackColor = System.Drawing.Color.Gainsboro;
            this.MSCC_Display_label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MSCC_Display_label44.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSCC_Display_label44.Location = new System.Drawing.Point(39, 378);
            this.MSCC_Display_label44.Name = "MSCC_Display_label44";
            this.MSCC_Display_label44.Size = new System.Drawing.Size(124, 23);
            this.MSCC_Display_label44.TabIndex = 125;
            this.MSCC_Display_label44.Text = "MSCC";
            this.MSCC_Display_label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HR50_PPT_listBox1
            // 
            this.HR50_PPT_listBox1.BackColor = System.Drawing.Color.White;
            this.HR50_PPT_listBox1.Enabled = false;
            this.HR50_PPT_listBox1.ForeColor = System.Drawing.Color.Black;
            this.HR50_PPT_listBox1.FormattingEnabled = true;
            this.HR50_PPT_listBox1.ItemHeight = 18;
            this.HR50_PPT_listBox1.Items.AddRange(new object[] {
            "PPT",
            "COR",
            "QRP"});
            this.HR50_PPT_listBox1.Location = new System.Drawing.Point(694, 318);
            this.HR50_PPT_listBox1.Name = "HR50_PPT_listBox1";
            this.HR50_PPT_listBox1.ScrollAlwaysVisible = true;
            this.HR50_PPT_listBox1.Size = new System.Drawing.Size(84, 22);
            this.HR50_PPT_listBox1.TabIndex = 124;
            this.HR50_PPT_listBox1.Visible = false;
            this.HR50_PPT_listBox1.SelectedIndexChanged += new System.EventHandler(this.HR50_PPT_listBox1_SelectedIndexChanged);
            // 
            // HR50_checkBox2
            // 
            this.HR50_checkBox2.AutoSize = true;
            this.HR50_checkBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.HR50_checkBox2.Enabled = false;
            this.HR50_checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HR50_checkBox2.ForeColor = System.Drawing.Color.Black;
            this.HR50_checkBox2.Location = new System.Drawing.Point(15, 262);
            this.HR50_checkBox2.Name = "HR50_checkBox2";
            this.HR50_checkBox2.Size = new System.Drawing.Size(91, 20);
            this.HR50_checkBox2.TabIndex = 123;
            this.HR50_checkBox2.Text = "BY PASS";
            this.HR50_checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HR50_checkBox2.UseVisualStyleBackColor = false;
            this.HR50_checkBox2.Visible = false;
            this.HR50_checkBox2.CheckedChanged += new System.EventHandler(this.HR50_checkBox2_CheckedChanged);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Gainsboro;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Enabled = false;
            this.label16.Location = new System.Drawing.Point(138, 317);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 23);
            this.label16.TabIndex = 122;
            this.label16.Text = "HARDROCK 50";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Visible = false;
            // 
            // HR50_listBox1
            // 
            this.HR50_listBox1.BackColor = System.Drawing.Color.White;
            this.HR50_listBox1.Enabled = false;
            this.HR50_listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HR50_listBox1.ForeColor = System.Drawing.Color.Black;
            this.HR50_listBox1.FormattingEnabled = true;
            this.HR50_listBox1.ItemHeight = 15;
            this.HR50_listBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.HR50_listBox1.Location = new System.Drawing.Point(6, 288);
            this.HR50_listBox1.Name = "HR50_listBox1";
            this.HR50_listBox1.Size = new System.Drawing.Size(94, 19);
            this.HR50_listBox1.TabIndex = 121;
            this.HR50_listBox1.Visible = false;
            this.HR50_listBox1.SelectedIndexChanged += new System.EventHandler(this.HR50_listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(686, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 22);
            this.button2.TabIndex = 83;
            this.button2.Text = "CLOSED";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SDRcore_Trans_Version
            // 
            this.SDRcore_Trans_Version.BackColor = System.Drawing.Color.Gainsboro;
            this.SDRcore_Trans_Version.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SDRcore_Trans_Version.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDRcore_Trans_Version.Location = new System.Drawing.Point(483, 404);
            this.SDRcore_Trans_Version.Name = "SDRcore_Trans_Version";
            this.SDRcore_Trans_Version.Size = new System.Drawing.Size(123, 23);
            this.SDRcore_Trans_Version.TabIndex = 79;
            this.SDRcore_Trans_Version.Text = "Firmware Version: ";
            this.SDRcore_Trans_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SDRcore_Trans_Version.Click += new System.EventHandler(this.SDRcore_Trans_Version_Click);
            // 
            // SDRcore_Recv_Version_label16
            // 
            this.SDRcore_Recv_Version_label16.BackColor = System.Drawing.Color.Gainsboro;
            this.SDRcore_Recv_Version_label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SDRcore_Recv_Version_label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDRcore_Recv_Version_label16.Location = new System.Drawing.Point(335, 404);
            this.SDRcore_Recv_Version_label16.Name = "SDRcore_Recv_Version_label16";
            this.SDRcore_Recv_Version_label16.Size = new System.Drawing.Size(123, 23);
            this.SDRcore_Recv_Version_label16.TabIndex = 78;
            this.SDRcore_Recv_Version_label16.Text = "Firmware Version: ";
            this.SDRcore_Recv_Version_label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SDRcore_Recv_Version_label16.Click += new System.EventHandler(this.SDRcore_Recv_Version_label16_Click);
            // 
            // MS_SDR_Version_label16
            // 
            this.MS_SDR_Version_label16.BackColor = System.Drawing.Color.Gainsboro;
            this.MS_SDR_Version_label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MS_SDR_Version_label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_SDR_Version_label16.Location = new System.Drawing.Point(187, 404);
            this.MS_SDR_Version_label16.Name = "MS_SDR_Version_label16";
            this.MS_SDR_Version_label16.Size = new System.Drawing.Size(123, 23);
            this.MS_SDR_Version_label16.TabIndex = 77;
            this.MS_SDR_Version_label16.Text = "Firmware Version: ";
            this.MS_SDR_Version_label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MS_SDR_Version_label16.Click += new System.EventHandler(this.MS_SDR_Version_label16_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Gainsboro;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(482, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 23);
            this.label15.TabIndex = 76;
            this.label15.Text = "SDRcore-trans";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(334, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 23);
            this.label12.TabIndex = 75;
            this.label12.Text = "SDRcore-recv";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(187, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 23);
            this.label11.TabIndex = 74;
            this.label11.Text = "MS-sdr";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 73;
            this.label6.Text = "Mark II";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // firmwarelabel16
            // 
            this.firmwarelabel16.BackColor = System.Drawing.Color.Gainsboro;
            this.firmwarelabel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firmwarelabel16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmwarelabel16.Location = new System.Drawing.Point(631, 404);
            this.firmwarelabel16.Name = "firmwarelabel16";
            this.firmwarelabel16.Size = new System.Drawing.Size(123, 23);
            this.firmwarelabel16.TabIndex = 71;
            this.firmwarelabel16.Text = "Firmware Version: ";
            this.firmwarelabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firmwarelabel16.Click += new System.EventHandler(this.firmwarelabel16_Click_1);
            // 
            // Transvertercheckbox
            // 
            this.Transvertercheckbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Transvertercheckbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transvertercheckbox.ForeColor = System.Drawing.Color.Black;
            this.Transvertercheckbox.Location = new System.Drawing.Point(642, 16);
            this.Transvertercheckbox.Name = "Transvertercheckbox";
            this.Transvertercheckbox.Size = new System.Drawing.Size(144, 22);
            this.Transvertercheckbox.TabIndex = 69;
            this.Transvertercheckbox.Text = "TRANSVERTER";
            this.Transvertercheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.Transvertercheckbox, "EXPAND 10M OPERATIONS TO 30MHz");
            this.Transvertercheckbox.UseVisualStyleBackColor = false;
            this.Transvertercheckbox.CheckedChanged += new System.EventHandler(this.Transvertercheckbox_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // Smeter_Timer
            // 
            this.Smeter_Timer.Enabled = true;
            this.Smeter_Timer.Interval = 30;
            this.Smeter_Timer.Tick += new System.EventHandler(this.Smeter_Timer_Tick);
            // 
            // Waterfall_timer
            // 
            this.Waterfall_timer.Tick += new System.EventHandler(this.Waterfall_timer_Tick);
            // 
            // Master_State_Machine_Timer
            // 
            this.Master_State_Machine_Timer.Interval = 1;
            this.Master_State_Machine_Timer.Tick += new System.EventHandler(this.Master_State_Machine_Tick);
            // 
            // PA_Calibrate_Timer
            // 
            this.PA_Calibrate_Timer.Interval = 1500;
            this.PA_Calibrate_Timer.Tick += new System.EventHandler(this.PA_Calibrate_Timer_Tick);
            // 
            // Proficio_Calibrate_timer
            // 
            this.Proficio_Calibrate_timer.Interval = 2000;
            this.Proficio_Calibrate_timer.Tick += new System.EventHandler(this.Proficio_Calibrate_timer_Tick);
            // 
            // PA_Display_Power_Timer
            // 
            this.PA_Display_Power_Timer.Interval = 500;
            this.PA_Display_Power_Timer.Tick += new System.EventHandler(this.PA_Display_Power_Timer_Tick);
            // 
            // ALC_Blink_timer1
            // 
            this.ALC_Blink_timer1.Interval = 2000;
            this.ALC_Blink_timer1.Tick += new System.EventHandler(this.ALC_Blink_timer1_Tick);
            // 
            // Main_Frequency_Update_timer4
            // 
            this.Main_Frequency_Update_timer4.Enabled = true;
            this.Main_Frequency_Update_timer4.Interval = 1;
            this.Main_Frequency_Update_timer4.Tick += new System.EventHandler(this.Main_Frequency_Update_timer4_Tick);
            // 
            // Mouse_Timer
            // 
            this.Mouse_Timer.Interval = 500;
            this.Mouse_Timer.Tick += new System.EventHandler(this.Mouse_Timer_Tick);
            // 
            // MFC_Update_Timer
            // 
            this.MFC_Update_Timer.Interval = 500;
            this.MFC_Update_Timer.Tick += new System.EventHandler(this.MFC_Update_Timer_Tick);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
            // 
            // Message_Blink_timer
            // 
            this.Message_Blink_timer.Interval = 500;
            this.Message_Blink_timer.Tick += new System.EventHandler(this.Message_Blink_timer_Tick);
            // 
            // Freq_Cal_Smeter_Timer
            // 
            this.Freq_Cal_Smeter_Timer.Interval = 30;
            this.Freq_Cal_Smeter_Timer.Tick += new System.EventHandler(this.Freq_Cal_Smeter_Timer_Tick);
            // 
            // Windows_Move_timer
            // 
            this.Windows_Move_timer.Interval = 1;
            this.Windows_Move_timer.Tick += new System.EventHandler(this.Windows_Move_timer_Tick);
            // 
            // Clock_timer
            // 
            this.Clock_timer.Enabled = true;
            this.Clock_timer.Interval = 1;
            this.Clock_timer.Tick += new System.EventHandler(this.Clock_timer_Tick);
            // 
            // GEM_BCN_Button_1
            // 
            this.GEM_BCN_Button_1.AutoSize = true;
            this.GEM_BCN_Button_1.BackColor = System.Drawing.Color.Transparent;
            this.GEM_BCN_Button_1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GEM_BCN_Button_1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEM_BCN_Button_1.ForeColor = System.Drawing.Color.White;
            this.GEM_BCN_Button_1.Location = new System.Drawing.Point(408, 12);
            this.GEM_BCN_Button_1.Name = "GEM_BCN_Button_1";
            this.GEM_BCN_Button_1.Size = new System.Drawing.Size(80, 27);
            this.GEM_BCN_Button_1.TabIndex = 53;
            this.GEM_BCN_Button_1.Text = "BCN1";
            this.GEM_BCN_Button_1.UseVisualStyleBackColor = false;
            this.GEM_BCN_Button_1.CheckedChanged += new System.EventHandler(this.GEM_BCN_Button_1_CheckedChanged);
            // 
            // GEM_BCN_Button_2
            // 
            this.GEM_BCN_Button_2.AutoSize = true;
            this.GEM_BCN_Button_2.BackColor = System.Drawing.Color.Transparent;
            this.GEM_BCN_Button_2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GEM_BCN_Button_2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEM_BCN_Button_2.ForeColor = System.Drawing.Color.White;
            this.GEM_BCN_Button_2.Location = new System.Drawing.Point(533, 12);
            this.GEM_BCN_Button_2.Name = "GEM_BCN_Button_2";
            this.GEM_BCN_Button_2.Size = new System.Drawing.Size(80, 27);
            this.GEM_BCN_Button_2.TabIndex = 54;
            this.GEM_BCN_Button_2.Text = "BCN2";
            this.GEM_BCN_Button_2.UseVisualStyleBackColor = false;
            this.GEM_BCN_Button_2.CheckedChanged += new System.EventHandler(this.GEM_BCN_Button_2_CheckedChanged);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(814, 509);
            this.ControlBox = false;
            this.Controls.Add(this.powertabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MSCC GEMINUS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Main_MouseWheel);
            this.powertabControl1.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.GEM_Group_Box.ResumeLayout(false);
            this.GEM_Group_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWaterfall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpectrum)).EndInit();
            this.RIT_groupBox4.ResumeLayout(false);
            this.RIT_groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Band_Set_2.ResumeLayout(false);
            this.Band_Set_2.PerformLayout();
            this.TX.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Power_Meter_Hold)).EndInit();
            this.freqcaltab.ResumeLayout(false);
            this.Freq_Cal_groupBox4.ResumeLayout(false);
            this.IQ_groupBox3.ResumeLayout(false);
            this.IQ_groupBox3.PerformLayout();
            this.powertabPage1.ResumeLayout(false);
            this.AMP_groupBox3.ResumeLayout(false);
            this.AMP_groupBox3.PerformLayout();
            this.Proficio_Band_Cal_groupBox.ResumeLayout(false);
            this.Proficio_Band_Cal_groupBox.PerformLayout();
            this.Transceiver_Calibrate_groupBox.ResumeLayout(false);
            this.Proficio_Pwr_groupBox6.ResumeLayout(false);
            this.Proficio_Pwr_groupBox6.PerformLayout();
            this.Audio_tabPage1.ResumeLayout(false);
            this.CW_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CW_Hold_numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CW_Speed_numericUpDown)).EndInit();
            this.MFC.ResumeLayout(false);
            this.IQBD_TX_groupBox.ResumeLayout(false);
            this.metertab.ResumeLayout(false);
            this.metertab.PerformLayout();
            this.Colors_groupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SMeter_groupBox4.ResumeLayout(false);
            this.SMeter_groupBox4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.HScrollBar ritScroll;
        private System.Windows.Forms.Button buttReset;
        private System.Windows.Forms.TabControl powertabControl1;
        private System.Windows.Forms.TabPage powertabPage1;
        private System.Windows.Forms.Label powerlabel14;
        private System.Windows.Forms.Button ritbutton1;
        private System.Windows.Forms.TabPage freqcaltab;
        private System.Windows.Forms.Button powerrestorebutton2;
        private System.Windows.Forms.Button powertunebutton1;
        private System.Windows.Forms.Button mainmodebutton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Freqbutton3;
        private System.Windows.Forms.Button buttTune;
        private System.Windows.Forms.RadioButton B160radioButton;
        private System.Windows.Forms.RadioButton B10radioButton;
        private System.Windows.Forms.RadioButton B12radioButton;
        private System.Windows.Forms.RadioButton B15radioButton;
        private System.Windows.Forms.RadioButton B17radioButton;
        private System.Windows.Forms.RadioButton B20radioButton;
        private System.Windows.Forms.RadioButton B30radioButton;
        private System.Windows.Forms.RadioButton B40radioButton;
        private System.Windows.Forms.RadioButton B60radioButton;
        private System.Windows.Forms.RadioButton B80radioButton;
        private System.Windows.Forms.HScrollBar MicVolume_hScrollBar1;
        private System.Windows.Forms.HScrollBar Volume_hScrollBar1;
        private System.Windows.Forms.TabPage TX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button TX_Mute_button2;
        private System.Windows.Forms.Button Volume_Mute_button2;
        private System.Windows.Forms.Label AM_Carrier_label2;
        private System.Windows.Forms.HScrollBar AM_Carrier_hScrollBar1;
        private System.Windows.Forms.TabPage Audio_tabPage1;
        private System.Windows.Forms.Label Time_display_label33;
        private System.Windows.Forms.Label Time_display_UTC_label34;
        private System.Windows.Forms.ListBox TX_Bandwidth_listBox1;
        private System.Windows.Forms.HScrollBar Power_hScrollBar1;
        private System.Windows.Forms.Label Power_label34;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.HScrollBar CW_Power_hScrollBar1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label CW_Power_label36;
        private System.Windows.Forms.Label SSB_Power_label36;
        private System.Windows.Forms.Label AM_Carrier_label36;
        private System.Windows.Forms.Label Tune_Power_label37;
        private System.Windows.Forms.HScrollBar Tune_Power_hScrollBar1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button LeftResetbutton2;
        private System.Windows.Forms.HScrollBar LefthScrollBar1;
        private System.Windows.Forms.Button IQ_Commit_button2;
        private System.Windows.Forms.TextBox IQLefttextBox2;
        private System.Windows.Forms.HScrollBar NB_hScrollBar1;
        private System.Windows.Forms.HScrollBar NR_hScrollBar1;
        private System.Windows.Forms.ListBox AGC_listBox1;
        private System.Windows.Forms.Label AGC_label2;
        private Button IQ_RX_button;
        private System.Windows.Forms.Timer timer2;
        private Button IQ_Reset_All_button2;
        private GroupBox Freq_Cal_groupBox4;
        private GroupBox IQ_groupBox3;
        private ProgressBar Calibration_progressBar1;
        private Button NR_button3;
        private Button NB_button2;
        private Button NB_ON_OFF_button2;
        private HScrollBar NB_Threshold_hScrollBar1;
        private Label NB_Threshold_label1;
        private Label NB_label16;
        private TabPage metertab;
        private Label SDRcore_Trans_Version;
        private Label SDRcore_Recv_Version_label16;
        private Label MS_SDR_Version_label16;
        private Label label15;
        private Label label12;
        private Label label11;
        private Label label6;
        private Label firmwarelabel16;
        private CheckBox Transvertercheckbox;
        private Button Monitorbutton;
        private Button button2;
        private ListBox HR50_listBox1;
        private Label label16;
        private CheckBox HR50_checkBox2;
        private ListBox HR50_PPT_listBox1;
        private Label StartUP_label44;
        private System.Windows.Forms.Timer timer3;
        private Label MSCC_Core_Version_label45;
        private Label MSCC_Display_label44;
        private TextBox Cal_Freq_textBox2;
        private Button QRP_Button;
        private Button Tune_vButton2;
        private HScrollBar IQ_Freq_hScrollBar1;
        private CheckBox IQ_UP24KHz_checkBox2;
        private Button Reset_Freq_button3;
        //private Nevron.UI.WinForm.Docking.NDockManager nDockManager1;
        //private Nevron.UI.WinForm.Controls.NButton Test_nButton1;
        //private Nevron.UI.WinForm.Controls.NButton nButton1;
        private Label UTC_Date_label46;
        private Label Local_Date_label46;
        private Button Freq_Check_Button;
        private Label label53;
        private ListBox Default_High_Cut_listBox1;
        private Label label52;
        private ListBox Default_CW_Filter_listBox1;
        private Label label51;
        private ListBox Default_Low_Cut_listBox1;
        private Label label50;
        private CheckBox Relay_Board_checkBox2;
        private HScrollBar AGC_hScrollBar1;
        private Label label55;
        private TabPage MFC;
        private Label Temperature_label57;
        private CheckBox Auto_Zero_checkBox2;
        private CheckBox Band_Change_Auto_Tune_checkBox2;
        private Label Amplifier_temperature_label58;
        private Label AMP_Current_label5;
        private Button NR_Button;
        private Label NR_label5;
        private CheckBox Full_Power_checkBox1;
        private Button button3;
        private ColorDialog colorDialog1;
        private Button Boarder_Color_button4;
        private Label Freq_Digit_Test_label58;
        private Button Freq_Color_button4;
        private Panel panel1;
        private GroupBox groupBox3;
        private Label Decimal_label58;
        private Label Decimal_label59;
        private GroupBox Colors_groupBox;
        private Button Compression_button4;
        private Button ACG_button;
        private Label Reverse_Power_label43;
        private Label Forward_Power_label43;
        private Label SWR_Value_label43;
        private Label Reverse_label58;
        private Label Forward_label43;
        private VU_MeterLibrary.VuMeter Reverse_Meter;
        private Label SWR_label1;
        private VU_MeterLibrary.VuMeter Forward_Meter;
        private GroupBox CW_groupBox;
        private Label label8;
        private ListBox CW_Pitch_listBox1;
        private Label label35;
        private NumericUpDown CW_Hold_numericUpDown2;
        private NumericUpDown CW_Speed_numericUpDown;
        private ListBox CW_Paddle_listBox1;
        private ListBox CW_Weight_listBox1;
        private ListBox CW_Space_listBox1;
        private ListBox CW_Mode_listBox1;
        private Label label60;
        private Label label59;
        private Label label58;
        private Label label45;
        private Label label5;
        private Button Compression_button2;
        private HScrollBar Compression_Level_hScrollBar1;
        private Label Compression_label44;
        private Button Freq_Cal_Reset_button4;
        private Label Freq_CAl_Progress_Lable;
        private Label Mic_Gain_label2;
        private Label Meter_hold_label43;
        private NumericUpDown Power_Meter_Hold;
        private Label RPi_Temperature_label1;
        private FontDialog fontDialog1;
        private Button button4;
        //private ToolTip Smeter_toolTip;
        private Label Power_Value_label2;
        private System.Windows.Forms.Timer Smeter_Timer;
        public VU_MeterLibrary.VuMeter vuMeter1;
        private Label label7;
        private ListBox ritlistBox1;
        private Button VFO_button;
        private GroupBox RIT_groupBox4;
        private System.Windows.Forms.Timer Waterfall_timer;
        private Button Spectrum_Controls_button3;
        private GroupBox SMeter_groupBox4;
        private Button Split_Button;
        private Button Audio_Digital_button3;
        private CheckBox Time_checkBox2;
        private Label label1;
        private CheckBox Peak_Needle_checkBox2;
        private HScrollBar Main_Power_hScrollBar1;
        private CheckBox Minimize_checkBox2;
        private TextBox ritfreqtextBox1;
        private Button IQBD_TX_Tune_button;
        private Label IQBD_Monitor_label;
        private HScrollBar IQBD_TX_Power_hScrollBar;
        private HScrollBar IQBD_TX_hScrollBar;
        private GroupBox IQBD_TX_groupBox;
        private Label XCRV_Power_Display_label33;
        private GroupBox groupBox4;
        private System.Windows.Forms.Timer Master_State_Machine_Timer;
        private Label Volume_textBox2;
        private Label Microphone_textBox2;
        private Label Freq_Comp_label32;
        /*private Label Freq_Poiner_7;
        private Label Freq_Poiner_6;
        private Label Freq_Poiner_5;
        private Label Freq_Poiner_4;
        private Label Freq_Poiner_3;
        private Label Freq_Poiner_2;
        private Label Freq_Poiner_1;
        private Label Freq_Poiner_0;
        */
        private Label Tenmillions;
        private Label Millions;
        private Label Hundredthousand;
        private Label Tenthousands;
        private Label Hundreds;
        private Label Tens;
        private Label Ones;
        private Label Thousands;
        private Label Freq_Pointer_5;
        private Label Freq_Pointer_4;
        private Label Freq_Pointer_3;
        private Label Freq_Pointer_2;
        private Label Freq_Pointer_1;
        private Label Freq_Pointer_0;
        private Label Freq_Pointer_7;
        private Label Freq_Pointer_6;
        private GroupBox groupBox5;
        private Label NB_Pulse_lable;
        private Label NB_Threshold_label;
        private Label AGC_Value_label;
        private Button Step_button8;
        private Button High_Cut_button8;
        private Button Low_Cut_Filter_button8;
        private Button CW_Filter_button8;
        private Label Dbm_Value_label9;
        private Label Dbm_label9;
        private GroupBox Proficio_Pwr_groupBox6;
        private Button Monitor_button8;
        private Button Mic_Pre_Gain_button8;
        private Button Volume_Attn_button8;
        private Button Smeter_Average_button8;
        private Button IQBD_Auto_button8;
        private Button IQBD_Reset_button8;
        private Button PA_button;
        private Button Meter_Temperature_button8;
        private Button Meter_ALC_button8;
        private Button Meter_I_button8;
        private Button Meter_SWR_button8;
        private Button Meter_Power_button8;
        private System.Windows.Forms.Timer PA_Calibrate_Timer;
        private System.Windows.Forms.Timer Proficio_Calibrate_timer;
        private Button Proficio_Calibrate_button8;
        private GroupBox Proficio_Band_Cal_groupBox;
        private Button Proficio_Band_Calibrated_10_button;
        private Button Proficio_Band_Calibrated_12_button;
        private Button Proficio_Band_Calibrated_15_button;
        private Button Proficio_Band_Calibrated_17_button;
        private Button Proficio_Band_Calibrated_20_button;
        private Button Proficio_Band_Calibrated_30_button;
        private Button Proficio_Band_Calibrated_40_button;
        private Button Proficio_Band_Calibrated_60_button;
        private Button Proficio_Band_Calibrated_80_button;
        private Button Proficio_Band_Calibrated_160_button;
        private Label label48;
        private Label label47;
        private Label label44;
        private Label label42;
        private Label label41;
        private Label label40;
        private Label label38;
        private Label label31;
        private Label label30;
        private Label label9;
        private System.Windows.Forms.Timer PA_Display_Power_Timer;
        private Button Spectrum_button9;
        private Button Digital_Volume_Attn_button5;
        private Button Button_Text_Color_button5;
        private Button Button_BG_Color_button5;
        private Label Button_Color_label49;
        private System.Windows.Forms.Timer ALC_Blink_timer1;
        private Button ALC_ON_OFF_button5;
        private System.Windows.Forms.Timer Main_Frequency_Update_timer4;
        private Button Color_Reset_button5;
        private Button IQ_TX_Button;
        private Button IQ_TX_Band_button;
        private VU_MeterLibrary.VuMeter IQBD_Meter;
        private Button Main_Meter_Temperature_Preferred;
        private Button Main_Meter_ALC_Preferred;
        private Button Main_Meter_I_Preferred;
        private Button Main_Meter_SWR_Preferred;
        private Button Main_Meter_Power_Preferred;
        private Label label4;
        private Button GEN_button;
        private GroupBox Band_Set_2;
        private RadioButton Russian_Radio_Button;
        private RadioButton WWV1_Radio_Button;
        private RadioButton WWV2_Radio_Button;
        private RadioButton WWV3_Radio_Button;
        private RadioButton WWV4_Radio_Button;
        private RadioButton CHU2_Radio_Button;
        private RadioButton Spare_Radio_Button;
        private RadioButton CHU1_Radio_Button;
        private Button Temperature_Selection_Button;
        private Button Freq_Down_button;
        private Button Freq_Up_button;
        private Button Main_Freq_KB_button;
        private Button MIC_Gain_Down_button;
        private Button MIC_Gain_UP_button;
        private Button Volume_Down_button;
        private Button Volume_UP_button;
        private System.Windows.Forms.Timer Mouse_Timer;
        private Button Set_Calibration_button;
        private VU_MeterLibrary.VuMeter IQ_Image_meter;
        private VU_MeterLibrary.VuMeter Freq_Cal_Meter;
        private Label label49;
        private Button RIT_Up_button;
        private Button RIT_Down_button;
        private CheckBox Smeter_Decay;
        private CheckBox CW_Mode_Phone_checkBox;
        private Label TX_Tab_Band_label;
        private Button Freq_Auto_Calibrate_button;
        private Label Freq_Calibration_Status_label;
        private Button Proficio_Manual_Calibrate_button;
        private HScrollBar Proficio_Calibrate_Power_hScrollBar;
        private System.Windows.Forms.Timer MFC_Update_Timer;
        private Label Smeter_Display_Value_label;
        private Button Smeter_Dbm_button;
        private Button VU_Blink_button;
        private Button S_Meter_Color_button;
        private Button Geminus_Band_Calibrated_630_button;
        private Button Geminus_Band_Calibrated_2200_button;
        private Label B630_Calibration_Status_label;
        private Label B2200_Calibration_Status_label;
        private RadioButton B630_radioButton;
        private RadioButton B2200_radioButton;
        private Button Geminus_Select_Band_button;
        private Button Out_Of_Band_button;
        private Button Freq_Stack_button;
        private Button Freq_Add_Stack_Button;
        private CheckBox Beta_checkBox;
        private Button Smeter_Peak_Needle_Color_button;
        private Button Peak_Needle_Delay_button;
        private Button Compression_Up_button;
        private Button Compression_Down_button;
        private ToolTip toolTip;
        private Button VFOB_TX_Indicator_button;
        private Button VFOB_Active_button;
        private Label Error_Message_label;
        private Button Smeter_Hold_Time_button;
        private Button Reset_Logs_button;
        private Button Auto_Tune_button;
        private Button Auto_Tune_Time_button;
        private Button Message_button;
        private Label Server_Message_label;
        private System.Windows.Forms.Timer Message_Blink_timer;
        private Label Signal_Average_label;
        private System.Windows.Forms.Timer Freq_Cal_Smeter_Timer;
        private HScrollBar Adjust_PPM_Coarse_hScrollBar;
        private GroupBox AMP_groupBox3;
        private Button PA_Calibrate_button;
        private HScrollBar PA_hScrollBar;
        private Button PA_Power_Limit_button;
        private Button PA_TX_button8;
        private Button Calibration_Band_button8;
        private Button PA_Reset_button8;
        private Button Solidus_Fan_On_Temperature_button8;
        private Button Fan_Control_button8;
        private Button Solidus_Bias_button8;
        private Label label32;
        private Label Power_calibration_label58;
        private Label AMP_Raw_Bias_label5;
        private Label AMP_Temp_MFC_AMP_label5;
        private Label AMP_label57;
        private GroupBox Transceiver_Calibrate_groupBox;
        private Label IQ_TX_Label;
        private Button Freq_Cal_Loose_button;
        private CheckBox Potentia_checkBox;
        private Label PPM_Coarse_Value_Label;
        private System.Windows.Forms.Timer Windows_Move_timer;
        public PictureBox picSpectrum;
        public PictureBox picWaterfall;
        private Label TX_IQ_Balance_label;
        private Label label2;
        private Button Mic_Digital_Pre_Gain_button;
        private GroupBox GEM_Group_Box;
        private RadioButton MF_Button;
        private RadioButton LF_Button;
        private System.Windows.Forms.Timer Clock_timer;
        private RadioButton GEM_GEN_Butt;
        private RadioButton GEM_BCN_Button;
        private RadioButton GEM_BCN_Button_2;
        private RadioButton GEM_BCN_Button_1;
        //private Label Freq_CAl_Progress_Label;
    }
}

