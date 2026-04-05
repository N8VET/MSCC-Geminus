//=================================================================
// display.cs
//=================================================================
// PowerSDR is a C# implementation of a Software Defined Radio.
// Copyright (C) 2004-2009  FlexRadio Systems
// Copyright (C) 2010-2013 Doug Wigley (W5WC)
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// You may contact us via email at: sales@flex-radio.com.
// Paper mail may be sent to: 
//    FlexRadio Systems
//    8900 Marybank Dr.
//    Austin, TX 78750
//    USA
//=================================================================
//
// Waterfall AGC Modifications Copyright (C) 2013 Phil Harman (VK6APH)
// DirectX functions borrowed from GeneisisRadio Copyright (C)2010,2011,2012 YT7PWR Goran Radivojevic
//

using System.Linq;

namespace OmniaGUI
{
    using System;
    // using System.IO;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Drawing.Drawing2D;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
   
   class Spectrum_Display
    {
        #region Variable Declaration
        public const float CLEAR_FLAG = -999.999F;				// for resetting buffers
        public const int BUFFER_SIZE = 16384;
        public static DisplayMode current_display_mode = DisplayMode.PANADAPTER;
        //public static Console console;
        //private static Mutex background_image_mutex;			// used to lock the base display image
        //private static Bitmap background_bmp;					// saved background picture for display
        //private static Bitmap display_bmp;					// Bitmap for use when drawing
        public static string background_image = null;
        private static int[] histogram_data = null;					// histogram display buffer
        private static int[] histogram_history;					// histogram counter
        public static float[] new_display_data;					// Buffer used to store the new data from the DSP for the display
        public static float[] current_display_data;				// Buffer used to store the current data for the display
        public static float[] new_display_data_bottom;
        public static float[] current_display_data_bottom;
        public static float[] new_waterfall_data;
        public static float[] current_waterfall_data;
        public static float[] new_waterfall_data_bottom;
        public static float[] current_waterfall_data_bottom;
        public static float[] rx1_average_buffer;					// Averaged display data buffer
        public static float[] rx2_average_buffer;
        public static float[] rx1_peak_buffer;						// Peak hold display data buffer
        public static float[] rx2_peak_buffer;
        public static Mutex render_mutex = new Mutex();
        private static Point[] points = null;
        private static Point[] Filter_points = null;
        public static bool DX_reinit = false;
        //public static String Message;

        private static bool pan_fill = true;
        public static bool PanFill
        {
            get { return pan_fill; }
            set { pan_fill = value; }
        }
        //private static int H = 0;	// target height
        private static int W = 0;	// target width
      
        private static int rx_display_low = -4000;
        public static int RXDisplayLow
        {
            get { return rx_display_low; }
            set { rx_display_low = value; }
        }
        private static int rx_display_high = 4000;
        public static int RXDisplayHigh
        {
            get { return rx_display_high; }
            set { rx_display_high = value; }
        }
        private static int rx2_display_low = -4000;
        private static int rx2_display_high = 4000;
        private static int tx_display_low = -4000;
        private static int tx_display_high = 4000;
        public static int TXDisplayHigh
        {
            get { return tx_display_high; }
            set { tx_display_high = value; }
        }
        private static int tx_sample_rate = 96000;
        private static bool mox = false;
        public static bool MOX
        {
            get { return mox; }
            set { mox = value; }
        }
        private static bool data_ready = true;					// True when there is new display data ready from the DSP
        public static bool DataReady
        {
            get { return data_ready; }
            set { data_ready = value; }
        }
        public static float display_avg_mult_old = 1 - (float)1 / 5;
        public static float display_avg_mult_new = (float)1 / 5;
        public static float waterfall_avg_mult_old = 1 - (float)1 / 18;
        public static float waterfall_avg_mult_new = (float)1 / 18;
        public static float rx2_waterfall_avg_mult_old = 1 - (float)1 / 18;
        public static float rx2_waterfall_avg_mult_new = (float)1 / 18;
        private static int spectrum_grid_max = 7000;
        private static int spectrum_grid_min = 0;
        private static int rx2_spectrum_grid_max = 0;
        private static int rx2_spectrum_grid_min = -160;
        private static int tx_spectrum_grid_max = 30;
        private static int tx_spectrum_grid_min = -100;
        private static Color band_edge_color = Color.Red;
        private static Pen band_edge_pen = new Pen(band_edge_color);
        private static Color tx_band_edge_color = Color.Red;
        private static Pen tx_band_edge_pen = new Pen(tx_band_edge_color);
        private static Color sub_rx_zero_line_color = Color.LightSkyBlue;
        private static Pen sub_rx_zero_line_pen = new Pen(sub_rx_zero_line_color);
        private static Color sub_rx_filter_color = Color.Blue;
        private static SolidBrush sub_rx_filter_brush = new SolidBrush(sub_rx_filter_color);
        private static Color grid_text_color = Color.Yellow;
        private static SolidBrush grid_text_brush = new SolidBrush(grid_text_color);
        private static Pen grid_text_pen = new Pen(grid_text_color);
        private static Color grid_tx_text_color = Color.FromArgb(255, Color.Yellow);
        private static SolidBrush grid_tx_text_brush = new SolidBrush(Color.FromArgb(255, grid_tx_text_color));
        private static Color grid_zero_color = Color.Red;
        private static Pen grid_zero_pen = new Pen(grid_zero_color);
        private static Color tx_grid_zero_color = Color.FromArgb(255, Color.Red);
        private static Pen tx_grid_zero_pen = new Pen(Color.FromArgb(255, tx_grid_zero_color));
        private static Color grid_color = Color.FromArgb(65, 255, 255, 255);
        private static Pen grid_pen = new Pen(grid_color);
        private static Color tx_vgrid_color = Color.FromArgb(65, 255, 255, 255);
        private static Pen tx_vgrid_pen = new Pen(tx_vgrid_color);
        private static Color hgrid_color = Color.White;
        private static Pen hgrid_pen = new Pen(hgrid_color);
        private static Color tx_hgrid_color = Color.White;
        private static Pen tx_hgrid_pen = new Pen(tx_hgrid_color);
        private static Color data_line_color = Color.Transparent;
        public static Color DataLineColor
        {
            get { return data_line_color; }
            set
            {
                data_line_color = value;
                data_line_pen.Color = data_line_color;
            }
        }
        private static bool spectrum_is_ready = false;					// True when there is new display data ready from the DSP
        public static bool Spectrum_Ready
        {
            get { return spectrum_is_ready; }
            set { spectrum_is_ready = value; }
        }
        private static Pen data_line_pen = new Pen(new SolidBrush(data_line_color), 1.0F);
        private static Pen data_line_fpen = new Pen(Color.FromArgb(100, data_line_color));
        public static Color Spectrum_Fill_Color
        {
            get { return data_line_fpen.Color; }
            set
            {
                data_line_fpen.Color = value;
            }
        }
        private static Color tx_data_line_color = Color.Red;
        private static Pen tx_data_line_pen = new Pen(new SolidBrush(tx_data_line_color), 1.0F);
        private static Pen tx_data_line_fpen = new Pen(Color.FromArgb(100, tx_data_line_color));
        private static Color grid_pen_dark = Color.FromArgb(65, 255, 255, 255);
        private static Pen grid_pen_inb = new Pen(grid_pen_dark);
        private static Color tx_vgrid_pen_fine = Color.FromArgb(65, 255, 255, 255);
        private static Pen tx_vgrid_pen_inb = new Pen(tx_vgrid_pen_fine);
        private static Color display_filter_color = Color.FromArgb(65, 255, 255, 255);
        private static SolidBrush display_filter_brush = new SolidBrush(display_filter_color);
        private static Pen cw_zero_pen = new Pen(Color.FromArgb(255, display_filter_color));
        private static Color tx_filter_color = Color.FromArgb(65, 255, 255, 255);
        private static SolidBrush tx_filter_brush = new SolidBrush(tx_filter_color);
        private static Color display_filter_tx_color = Color.Yellow;
        private static Pen tx_filter_pen = new Pen(display_filter_tx_color);
        private static Color display_background_color = Color.Black;
        private static SolidBrush display_background_brush = new SolidBrush(display_background_color);
        private static Color tx_display_background_color = Color.Black;
        private static SolidBrush tx_display_background_brush = new SolidBrush(tx_display_background_color);
        private static SolidBrush pana_text_brush = new SolidBrush(Color.Khaki);
        private static System.Drawing.Font pana_font = new System.Drawing.Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        private static Pen dhp = new Pen(Color.FromArgb(0, 255, 0)),
                           dhp1 = new Pen(Color.FromArgb(150, 0, 0, 255)),
                           dhp2 = new Pen(Color.FromArgb(150, 255, 0, 0));
        private static System.Drawing.Font font14 = new System.Drawing.Font("Arial", 14, FontStyle.Bold),
                            font9 = new System.Drawing.Font("Arial", 9);
        #endregion   

        #region GDI+ General Routines
        public static void Init()
        {
            histogram_data = new int[W];
            histogram_history = new int[W];
            for (int i = 0; i < W; i++)
            {
                histogram_data[i] = Int32.MaxValue;
                histogram_history[i] = 0;
            }
            rx1_average_buffer = new float[BUFFER_SIZE];	// initialize averaging buffer array
            rx1_average_buffer[0] = CLEAR_FLAG;		// set the clear flag

            rx2_average_buffer = new float[BUFFER_SIZE];	// initialize averaging buffer array
            rx2_average_buffer[0] = CLEAR_FLAG;		// set the clear flag

            rx1_peak_buffer = new float[BUFFER_SIZE];
            rx1_peak_buffer[0] = CLEAR_FLAG;

            rx2_peak_buffer = new float[BUFFER_SIZE];
            rx2_peak_buffer[0] = CLEAR_FLAG;

            new_display_data = new float[BUFFER_SIZE];
            current_display_data = new float[BUFFER_SIZE];
            new_display_data_bottom = new float[BUFFER_SIZE];
            current_display_data_bottom = new float[BUFFER_SIZE];
            new_waterfall_data = new float[BUFFER_SIZE];
            current_waterfall_data = new float[BUFFER_SIZE];
            new_waterfall_data_bottom = new float[BUFFER_SIZE];
            current_waterfall_data_bottom = new float[BUFFER_SIZE];

            for (int i = 0; i < BUFFER_SIZE; i++)
            {
                new_display_data[i] = -200.0f;
                current_display_data[i] = -200.0f;
                new_display_data_bottom[i] = -200.0f;
                current_display_data_bottom[i] = -200.0f;
                new_waterfall_data[i] = -200.0f;
                current_waterfall_data[i] = -200.0f;
                new_waterfall_data_bottom[i] = -200.0f;
                current_waterfall_data_bottom[i] = -200.0f;
            }
        }
        #endregion
     
        #region Drawing Routines
        private static float[] scope_max = new float[W];
        private static float[] scope2_min = new float[W];
        private static float[] scope2_max = new float[W];
        public static int Spectrum_Rectangle_X = 0;
        public static int Spectrum_Rectangle_Y = 0;
        public static int Spectrum_Rectangle_Width = 0;
        public static int Spectrum_Rectangle_Height = 0;
        public static int Spectrum_Rectangle_Fill_X = 0;
        public static int Spectrum_Rectangle_Fill_Y = 0;
        public static int Spectrum_Rectangle_Fill_Width = 0;
        public static int Spectrum_Rectangle_Fill_Height = 0;
        public const int GRAPH_CENTER_OFFSET_ADJUSTMENT = 4;
        public const int GRAPH_CURSOR_OFFSET_ADJUSTMENT = -18;
        public static int G_Width = 0;
        public static int G_Height = 0;
        public static bool box_displayed = false;
        public static bool spectrum_entered = false;
        public static bool cursor_displayed = false;

        public static void Local_Debug_Message(String Message)
        {
            var thisForm2 = Application.OpenForms.OfType<Main_form>().Single();
            thisForm2.Write_Debug_Message (Message);
        }     
        public static void Set_Spectrum_Box_dimensions(int W,int H)
        {
            Spectrum_Rectangle_X = 0;
            Spectrum_Rectangle_Y = 0;
            Spectrum_Rectangle_Width = W;
            Spectrum_Rectangle_Height = H;
            Spectrum_Rectangle_Fill_X = Spectrum_Rectangle_X;
            Spectrum_Rectangle_Fill_Y = Spectrum_Rectangle_Y;
            Spectrum_Rectangle_Fill_Width = Spectrum_Rectangle_Width;
            Spectrum_Rectangle_Fill_Height = Spectrum_Rectangle_Height;
        }
        public static int Get_CW_Offset()
        {
            int offset = 0;

            if (Spectrum_Last_used.Current_mode == 'C')
            {
                switch (Spectrum_Filter_control.CW_Pitch_Index)
                {
                    case 0:
                        offset = 4;
                        break;
                    case 1:
                        offset = 5;
                        break;
                    case 2:
                        offset = 7;
                        break;
                    case 3:
                        offset = 8;
                        break;
                    case 4:
                        offset = 9;
                        break;
                }
            }
            return offset;
        }
        public static int Filter_size(int filter_index)
        {
            int size = 0;
            switch (filter_index)
            {
                case 4:
                    size = 2400;
                    break;
                case 3:
                    size = 2700;
                    break;
                case 2:
                    size = 3000;
                    break;
                case 1:
                    size = 4000;
                    break;
                case 0:
                    size = 5500;
                    break;
            }
            return size;
        }
        public static void Initialize_Spectrum_Box(Graphics g, int W, int H)
        {
            String Message;
            Set_Spectrum_Box_dimensions(W, H);
            SolidBrush clearbrush = new SolidBrush(Spectrum_Panadapter_Controls.Panadapter_Colors.Background_Color);
            g.FillRectangle(clearbrush, Spectrum_Rectangle_Fill_X, Spectrum_Rectangle_Fill_Y,
                                                                Spectrum_Rectangle_Fill_Width, Spectrum_Rectangle_Fill_Height);
            Message = " Initialize_Spectrum_Box W: " + Convert.ToString(W) + "H: " + Convert.ToString(H);
            Local_Debug_Message(Message);
        }
        public static bool DrawPanadapter(Graphics g, int W, int H, int rx, bool bottom)
        {
            int pixel_ratio = 0;
            int cw_offset = 0;
            int center_line = 0;
            int line_bottom = 0;
            int line_top = 3;
            int cursor_position_x = 0;
            int cursor_position_y = 0;
            int cursor_bottom = 0;
            String Message;
            int USB_Marker = 0;
            int LSB_Marker = 0;
            float slope = 0.0F;                     // samples to process per pixel
            int num_samples = 0;                    // number of samples to process
            int start_sample_index = 0;             // index to begin looking at samples
            int Low = 0;// rx_display_low;
            int High = 0;// rx_display_high;
                         // int yRange = spectrum_grid_max - spectrum_grid_min;
            bool local_mox = false;
            bool displayduplex = false;
            float ratio = 0.0f;
            int i = 0;
            //int y = 0;
            int i_offset = 0;
            int gain = 0;

            int grid_max = 0;
            int grid_min = 0;
            G_Width = W;
            G_Height = H;

            //Message = " DrawPanadapter W: " + Convert.ToString(W);
            //Local_Debug_Message(Message);
            Pen filer_pen = new Pen(Spectrum_Panadapter_Controls.Panadapter_Colors.Marker_Color, 1.0f);
            Pen center_pen = new Pen(Spectrum_Panadapter_Controls.Panadapter_Colors.Marker_Color, 2.0f);
            filer_pen.EndCap = LineCap.Triangle;
            filer_pen.DashStyle = DashStyle.Solid;
            center_pen.EndCap = LineCap.Triangle;
            center_pen.DashStyle = DashStyle.Solid;
            SolidBrush grid_text_brush = new SolidBrush(Spectrum_Panadapter_Controls.Panadapter_Colors.Cursor_Color);
            Pen cursor_pen = new Pen(Spectrum_Panadapter_Controls.Panadapter_Colors.Cursor_Color, 1.0f);
            cursor_pen.EndCap = LineCap.Triangle;
            cursor_pen.DashStyle = DashStyle.Solid;
            System.Drawing.Font freq_font = new System.Drawing.Font("Arial", 10);
            pixel_ratio = (Spectrum_Filter_control.Markers.DISPLAY_BANDWIDTH -
               Spectrum_Panadapter_Controls.Start_X_Position) / W;
            cw_offset = Get_CW_Offset();
            if (Spectrum_Last_used.Current_mode != 'A')
            {
                center_line = (W / 2) + (cw_offset) + GRAPH_CENTER_OFFSET_ADJUSTMENT;
            }
            else
            {
                center_line = (W / 2) + (Spectrum_Filter_control.Markers.AM_RX_OFFSET) + GRAPH_CENTER_OFFSET_ADJUSTMENT;
            }
            line_bottom = H;
            int filter_size = Filter_size(Spectrum_Filter_control.Markers.band_marker_high);
            int filter_marker = filter_size / pixel_ratio;
            USB_Marker = center_line + filter_marker;
            LSB_Marker = center_line - filter_marker;

            //Spectrum_Ready = false;
            if (pan_fill)
            {
                if (points == null || points.Length < W + 2)
                    points = new Point[W + 2];
                if(Filter_points == null || Filter_points.Length < W)
                    Filter_points = new Point[W];          // array of points to display
            }
            else
            {
                if (points == null || points.Length < W)
                    points = new Point[W];          // array of points to display
                if (Filter_points == null || Filter_points.Length < W)
                    Filter_points = new Point[W];          // array of points to display
            }


            Set_Spectrum_Box_dimensions(W, H);
            //SolidBrush shadebrush = new SolidBrush(Color.Red);
            SolidBrush clearbrush = new SolidBrush(Spectrum_Panadapter_Controls.Panadapter_Colors.Background_Color);
            g.FillRectangle(clearbrush, Spectrum_Rectangle_Fill_X, Spectrum_Rectangle_Fill_Y,
                                                                Spectrum_Rectangle_Fill_Width, Spectrum_Rectangle_Fill_Height);

            if (Spectrum_Panadapter_Controls.Monitor && Spectrum_Master_Controls.TX_On == 1)
            {
                //Display_TX_Filter_Markers(g, W, Spectrum_Rectangle_Fill_Height);

            }
            else
            {
                //Display_Filter_Markers(g, W, Spectrum_Rectangle_Fill_Height);
            }

            gain = H + Spectrum_Panadapter_Controls.Spectrum_Gain;
            ratio = (float)gain / 7000.0f;

            if (rx == 2)
            {
                if (local_mox)// && tx_on_vfob)
                {
                    Low = tx_display_low;
                    High = tx_display_high;
                    grid_max = tx_spectrum_grid_max;
                    grid_min = tx_spectrum_grid_min;
                }
                else
                {
                    Low = rx2_display_low;
                    High = rx2_display_high;
                    grid_max = rx2_spectrum_grid_max;
                    grid_min = rx2_spectrum_grid_min;
                }
            }
            else
            {
                if (local_mox)  // && !tx_on_vfob)
                {
                    if (!displayduplex)
                    {
                        Low = tx_display_low;
                        High = tx_display_high;
                    }
                    else
                    {
                        Low = rx_display_low;
                        High = rx_display_high;
                    }

                    grid_max = tx_spectrum_grid_max;
                    grid_min = tx_spectrum_grid_min;
                }
                else
                {
                    Low = rx_display_low;
                    High = rx_display_high;
                    grid_max = spectrum_grid_max;
                    grid_min = spectrum_grid_min;
                }
            }

            int yRange = grid_max - grid_min;
            int width = High - Low;
            Array.Copy(new_display_data, current_display_data, current_display_data.Length);
            Main_form.process_spectrum_count = W;
            Main_form.process_spectrum_op_code = H;
            //Message = " Initialize_Spectrum_Box W: " + Convert.ToString(W) + "H: " + Convert.ToString(H);
            if (local_mox && !displayduplex)// || rx1_dsp_mode == DSPMode.DRM)
            {
                start_sample_index = (BUFFER_SIZE >> 1) + ((Low * BUFFER_SIZE) / tx_sample_rate);
                num_samples = (width * BUFFER_SIZE / tx_sample_rate);
                if (start_sample_index < 0) start_sample_index += 16384;
                if ((num_samples - start_sample_index) > (BUFFER_SIZE + 1))
                    num_samples = (BUFFER_SIZE - start_sample_index);

                //Debug.WriteLine("start_sample_index: "+start_sample_index);
                slope = (float)num_samples / (float)W;
            }

            try
            {
                for (i = 0; i < W; i++)
                {
                    i_offset = i;
                    points[i_offset].X = i_offset;
                    points[i_offset].Y = (int)(current_display_data[i_offset] * ratio);
                    points[i_offset].Y = gain - points[i_offset].Y;
                    points[i_offset].Y = points[i_offset].Y - Spectrum_Panadapter_Controls.Spectrum_Base_Line;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
            try
            {
                switch (Spectrum_Last_used.Current_mode)
                {
                    case 'A':
                        g.DrawLine(filer_pen, USB_Marker, line_top, USB_Marker, line_bottom);
                        g.DrawLine(filer_pen, LSB_Marker, line_top, LSB_Marker, line_bottom);
                        break;
                    case 'U':
                        g.DrawLine(filer_pen, USB_Marker, line_top, USB_Marker, line_bottom);
                        break;
                    case 'L':
                        g.DrawLine(filer_pen, LSB_Marker, line_top, LSB_Marker, line_bottom);
                        break;
                }
                g.DrawLine(center_pen, center_line, 0, center_line, line_bottom);
                if (pan_fill)
                {
                    points[W].X = W;
                    points[W].Y = H - Spectrum_Panadapter_Controls.Spectrum_Base_Line;
                    points[W + 1].X = 0;
                    points[W + 1].Y = H - Spectrum_Panadapter_Controls.Spectrum_Base_Line;

                    g.FillPolygon(data_line_fpen.Brush, points);
                    points[W] = points[W - 1];
                    points[W + 1] = points[W - 1];
                    data_line_pen.Color = data_line_color;
                    g.DrawLines(data_line_pen, points);
                }
                else
                {
                    g.DrawLines(data_line_pen, points);
                }
                if (Spectrum_Panadapter_Controls.Display_Cursor == true)
                {
                    Message = " Display_Cursors -> cursor_position_x: " + Convert.ToString(cursor_position_x +
                                                                            " cursor_position_y: " + Convert.ToString(cursor_position_y));
                    Local_Debug_Message(Message);
                   
                    cursor_position_x = (int)Spectrum_Panadapter_Controls.Mouse_event.User_Cursor_x;
                    //cursor_position_y = (int)Spectrum_Panadapter_Controls.Mouse_event.User_Cursor_y;
                    cursor_bottom = H;
                    g.DrawLine(cursor_pen, cursor_position_x + (GRAPH_CURSOR_OFFSET_ADJUSTMENT), 0 + 1, 
                        cursor_position_x + (GRAPH_CURSOR_OFFSET_ADJUSTMENT), cursor_bottom - 1);
                    if (cursor_position_x > (W - 80))
                    {
                        g.DrawString(Spectrum_Panadapter_Controls.Cursor_Controls.Cursor_freq,
                             freq_font, grid_text_brush, cursor_position_x - 80, cursor_bottom - 60);
                    }
                    else
                    {
                        g.DrawString(Spectrum_Panadapter_Controls.Cursor_Controls.Cursor_freq,
                           freq_font, grid_text_brush, cursor_position_x + 8, cursor_bottom - 60);
                    }
                }

            }
            catch (Exception ex)
            {
                //Trace.WriteLine(ex);
                Local_Debug_Message(" FillPolygon or Drawlines FAILED.  Error: " + Convert.ToString(ex));

            }
            points = null;
            Filter_points = null;
            //Spectrum_Ready = true;
            return true;
        }
        public static void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            //Local_Debug_Message(" pictureBox_Paint. CALLED");
            e.Graphics.DrawImage(Spectrum_Panadapter_Controls.bm, 0, 0, G_Width, G_Height);
        }

        private static bool rx1_waterfall_agc = false;
        public static bool RX1WaterfallAGC
        {
            get { return rx1_waterfall_agc; }
            set { rx1_waterfall_agc = value; }
        }
        private static bool rx2_waterfall_agc = false;
        public static bool RX2WaterfallAGC
        {
            get { return rx2_waterfall_agc; }
            set { rx2_waterfall_agc = value; }
        }
        private static int waterfall_update_period = 100; // in ms
        public static int WaterfallUpdatePeriod
        {
            get { return waterfall_update_period; }
            set { waterfall_update_period = value; }
        }
        private static int rx2_waterfall_update_period = 100; // in ms
        public static int RX2WaterfallUpdatePeriod
        {
            get { return rx2_waterfall_update_period; }
            set { rx2_waterfall_update_period = value; }
        }
        #endregion
    }
}