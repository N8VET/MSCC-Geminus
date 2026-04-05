//=================================================================
// display.cs
//=================================================================
// PowerSDR is a C# implementation of a Software Defined Radio.
// Copyright (C) 2004, 2005, 2006  FlexRadio Systems
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
//    12100 Technology Blvd.
//    Austin, TX 78727
//    USA
//=================================================================

/*
 *  Changes for Multus SDR, LLC.
 *  Copyright (C)2019
*/

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
//using System.Linq.Expressions;
//using System.ComponentModel;
using System.Runtime.InteropServices;
//using MSCC_Waterfall;

namespace OmniaGUI
{
    public enum RenderType
    {
        HARDWARE = 0,
        SOFTWARE,
        NONE,
    }
    public static class Display_GDI
    {
        #region Variable Declaration
        //private static int pass_count = 0;
        //private static double avg_last_ddsfreq = 0;				// Used to move the display average when tuning
        //private static double avg_last_dttsp_osc = 0;

        public static Bitmap master_bmp;  				    // Bitmap for use when drawing
        private static Bitmap waterfall_bmp;					// saved waterfall picture for display
        private static int[] histogram_data;					// histogram display buffer
        private static int[] histogram_history;					// histogram counter
        public const float CLEAR_FLAG = -999.999F;				// for resetting buffers
        public const int BUFFER_SIZE = 4096;
        public static float[] new_display_data;					// Buffer used to store the new data from the DSP for the display
        public static float[] new_scope_data;					// Buffer used to store the new data from the DSP for the scope
        public static float[] new_waterfall_data;    			// Buffer used to store the new data from the DSP for the waterfall
        public static float[] current_display_data;				// Buffer used to store the current data for the display
        public static float[] current_scope_data;   		    // Buffer used to store the current data for the scope
        public static float[] current_waterfall_data;		    // Buffer used to store the current data for the waterfall
        public static float[] waterfall_display_data;            // Buffer for waterfall

        public static float[] average_buffer;					// Averaged display data buffer for Panadapter
        public static float[] average_waterfall_buffer;  		// Averaged display data buffer for Waterfall
        public static float[] peak_buffer;						// Peak hold display data buffer
        public static Mutex display_data_mutex = new Mutex();

        public static int server_W = 1024;                       // for Server screen width
        public static int client_W = 1024;                       // for Client screen width
        public static byte[] server_display_data;
        public static byte[] client_display_data;
        private static System.Drawing.Font swr_font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
        public static string panadapter_img = "";
        public static int sample_rate = 96000;
        //public static Bitmap img = Properties.Resources.BITMAP1;
        public static double SampleRate
        {
            get { return sample_rate; }
            set
            {
                sample_rate = (int)value;
                //int i = SetSampleRate(sample_rate);
            }
        }

        #endregion

        #region Properties

        private static ColorSheme color_sheme = ColorSheme.original;        // yt7pwr
        public static ColorSheme ColorSheme
        {
            get { return color_sheme; }

            set { color_sheme = value; }
        }

        private static bool reverse_waterfall = false;
        public static bool ReverseWaterfall
        {
            get { return reverse_waterfall; }
            set { reverse_waterfall = value; }
        }

        //private static int H = 397;	// target height
        //private static int W = 760; // target width

        public static Size window_size;
        /*public static Size Window_size
        {
            get { return window_size; }
            set
            {
                window_size = value;
                H = window_size.Height;
                W = window_size.Width;
            }
        }*/

        private static bool mox = false;
        public static bool MOX
        {
            get { return mox; }
            set { mox = value; }
        }

        private static DisplayMode current_display_mode = DisplayMode.WATERFALL;
        public static DisplayMode CurrentDisplayMode // changes yt7pwr
        {
            get { return current_display_mode; }
            set
            {
                current_display_mode = value;
            }
        }

        private static bool waterfall_ready = true;					// True when waterfall is ready to accept new data

        public static bool Waterfall_Ready
        {
            get { return waterfall_ready; }
            set { waterfall_ready = value; }
        }

        private static bool waterfall_data_ready = false;	    // True when there is new display data ready from the DSP
        public static bool WaterfallDataReady
        {
            get { return waterfall_data_ready; }
            set { waterfall_data_ready = value; }
        }

        private static Color grid_text_color = Color.White;
        public static Color GridTextColor
        {
            get { return grid_text_color; }
            set
            {
                grid_text_color = value;
            }
        }

        private static Color grid_zero_color = Color.Red;
        public static Color GridZeroColor
        {
            get { return grid_zero_color; }
            set
            {
                grid_zero_color = value;
            }
        }

        private static Color cursor_color = Color.White;
        public static Color CursorColor
        {
            get { return cursor_color; }
            set
            {
                cursor_color = value;

            }
        }

        private static int cursor_position;
        public static int CursorPosition
        {
            get { return cursor_position; }
            set
            {
                cursor_position = value;
            }
        }

        private static Color marker_filter_color = Color.White;
        public static Color MarkerFilterColor
        {
            get { return marker_filter_color; }
            set
            {
                marker_filter_color = value;
            }
        }

        private static Color display_background_color = Color.Black;
        public static Color DisplayBackgroundColor
        {
            get { return display_background_color; }
            set
            {
                display_background_color = value;
            }
        }

        private static Color waterfall_center_marker_color = Color.White;
        public static Color Waterfall_center_marker_Color
        {
            get { return waterfall_center_marker_color; }
            set { waterfall_center_marker_color = value; }
        }
        private static Color waterfall_low_color = Color.Black;
        public static Color WaterfallLowColor
        {
            get { return waterfall_low_color; }
            set { waterfall_low_color = value; }
        }

        private static Color waterfall_mid_color = Color.Red;
        public static Color WaterfallMidColor
        {
            get { return waterfall_mid_color; }
            set { waterfall_mid_color = value; }
        }

        private static Color waterfall_high_color = Color.Yellow;
        public static Color WaterfallHighColor
        {
            get { return waterfall_high_color; }
            set { waterfall_high_color = value; }
        }

        private static float waterfall_high_threshold = -80.0F;
        public static float WaterfallHighThreshold
        {
            get { return waterfall_high_threshold; }
            set { waterfall_high_threshold = value; }
        }

        private static float waterfall_low_threshold = -110.0F;
        public static float WaterfallLowThreshold
        {
            get { return waterfall_low_threshold; }
            set { waterfall_low_threshold = value; }
        }

        private static float display_line_width = 1.0F;

        private static bool data_ready = true;					// true when the waterfall is ready to accept new data
        public static bool DataReady
        {
            get { return data_ready; }
            set { data_ready = value; }
        }

        #endregion

        #region General Routines

        public static int Spectrum_Rectangle_X = 0;
        public static int Spectrum_Rectangle_Y = 0;
        public static int Spectrum_Rectangle_Width = 0;
        public static int Spectrum_Rectangle_Height = 0;
        public static int Spectrum_Rectangle_Fill_X = 0;
        public static int Spectrum_Rectangle_Fill_Y = 0;
        public static int Spectrum_Rectangle_Fill_Width = 0;
        public static int Spectrum_Rectangle_Fill_Height = 0;

        public static void Set_Spectrum_Box_dimensions(int W, int H)
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
        public static void Initialize_Spectrum_Box(Graphics g, int W, int H)
        {
            Set_Spectrum_Box_dimensions(W, H);
        }
        public static void Init()               // changes yt7pwr
        {
            try
            {
                histogram_data = new int[Waterfall_Panadapter_Controls.Width];
                histogram_history = new int[Waterfall_Panadapter_Controls.Width];
                for (int i = 0; i < Waterfall_Panadapter_Controls.Width; i++)
                {
                    histogram_data[i] = Int32.MaxValue;
                    histogram_history[i] = 0;
                }

                if (waterfall_bmp != null)
                {
                    waterfall_bmp.Dispose();
                }

                if (master_bmp != null)
                    master_bmp.Dispose();
                //master_bmp = new Bitmap(Form1.Spectrum_Panadapter_Controls.Width, 
                //    Form1.Spectrum_Panadapter_Controls.Height, PixelFormat.Format24bppRgb);                // initialize paterfall display    
                master_bmp = new Bitmap(Waterfall_Panadapter_Controls.Width,
                   Waterfall_Panadapter_Controls.Height, PixelFormat.Format32bppPArgb);                // initialize paterfall display
                waterfall_bmp = new Bitmap(Waterfall_Panadapter_Controls.Width,
                    Waterfall_Panadapter_Controls.Height, PixelFormat.Format24bppRgb);             // initialize waterfall display
                
                average_buffer = new float[BUFFER_SIZE];                                  // initialize averaging buffer array
                average_buffer[0] = CLEAR_FLAG;                                           // set the clear flag
                average_waterfall_buffer = new float[BUFFER_SIZE];                        // initialize averaging buffer array
                average_waterfall_buffer[0] = CLEAR_FLAG;                                 // set the clear flag
                peak_buffer = new float[BUFFER_SIZE];
                peak_buffer[0] = CLEAR_FLAG;
                //scope_min = new float[W];
                //scope_max = new float[W];
                new_display_data = new float[BUFFER_SIZE];
                new_scope_data = new float[BUFFER_SIZE];
                new_waterfall_data = new float[BUFFER_SIZE];
                current_display_data = new float[BUFFER_SIZE];
                current_scope_data = new float[BUFFER_SIZE];
                current_waterfall_data = new float[BUFFER_SIZE];
                waterfall_display_data = new float[BUFFER_SIZE];
                if (Waterfall_Controls.waterfall_data == null || Waterfall_Controls.waterfall_data.Length <
                    Waterfall_Panadapter_Controls.Width)
                {
                    Waterfall_Controls.waterfall_data = new float[Waterfall_Panadapter_Controls.Width];
                    Waterfall_Controls.new_waterfall_data = new float[Waterfall_Panadapter_Controls.Width];
                    Waterfall_Controls.current_waterfall_data = new float[Waterfall_Panadapter_Controls.Width];
                    Write_Waterfall_Debug_Message(" Init -> W: " + Convert.ToString(Waterfall_Panadapter_Controls.Width) + " H: " + 
                        Convert.ToString(Waterfall_Panadapter_Controls.Height));
                    Write_Waterfall_Debug_Message(" Init - > waterfall_data created");// array of points to display
                }
                for (int i = 0; i < BUFFER_SIZE; i++)
                {
                    new_display_data[i] = -200.0f;
                    new_scope_data[i] = -200.0f;
                    new_waterfall_data[i] = -200.0f;
                    current_display_data[i] = -200.0f;
                    current_scope_data[i] = -200.0f;
                    current_waterfall_data[i] = -200.0f;
                    waterfall_display_data[i] = -200.0f;
                }

                if (display_data_mutex == null)
                    display_data_mutex = new Mutex();

                server_display_data = new byte[server_W];
                client_display_data = new byte[client_W];
                Main_form.waterfall_initialized = true;
            }
            catch (Exception ex)
            {
                String Message = " Init " + ex.ToString();
                Write_Waterfall_Debug_Message(Message);
                Debug.Write(ex.ToString());
            }
        }
        public static bool Close() // yt7pwr
        {
            bool status = false;
            try
            {
                histogram_data = null;
                histogram_history = null;

                if (waterfall_bmp != null)
                    waterfall_bmp.Dispose();

                average_buffer = null;
                average_waterfall_buffer = null;
                peak_buffer = null;
                //scope_min = null;
                //scope_max = null;
                new_display_data = null;
                new_scope_data = null;
                new_waterfall_data = null;
                current_display_data = null;
                current_scope_data = null;
                current_waterfall_data = null;
                waterfall_display_data = null;
                if (display_data_mutex != null)
                    display_data_mutex = null;
                server_display_data = null;
                client_display_data = null;
            }
            catch (Exception ex)
            {
                String Message = " Close " + ex.ToString();
                Write_Waterfall_Debug_Message(Message);
                Debug.Write(ex.ToString());
            }
            status = true;
            return status;
        }

        #endregion

        public static int previous_filter = 10;  // Spectrum_Window_controls.Waterfall_Controls.Markers.band_marker_high;
        public static char previous_mode = 'N'; //Spectrum_Last_used.Current_mode;
        public static int pic_line_center = 0;
        public static int pic_line_bottom = 0;
        public static int pic_high_cursor = 0;
        public static int pic_low_cursor = 0;
        public static int space = 0;
        public static int pan_buff_count = 0;
        public static int pan_buff_limit = 0;
        public static float previous_ratio = 100.0f;
        public static int G_Height = 0;
        public static int G_Width = 0;
        public static bool waterfall_operation_complete = true;
        public static int count = 0;
        public const int GRAPH_OFFSET_ADJUSTMENT = 4;
        public static void Write_Waterfall_Debug_Message(String Message)
        {
            var thisForm2 = Application.OpenForms.OfType<Main_form>().Single();
            thisForm2.Write_Message(Message);
        }
        public static void Display_Cursor()
        {
            using (Graphics gr = Graphics.FromImage(waterfall_bmp))
            {
                int cursor_bottom = waterfall_bmp.Height;
                Pen cursor = new Pen(new SolidBrush(cursor_color), display_line_width);
                gr.DrawLine(cursor, cursor_position, 0, cursor_position, cursor_bottom);
            }
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
        public static int Get_CW_Offset()
        {
            int offset = 0;

            if (Waterfall_Last_used.Current_mode == 'C')
            {
                switch (Waterfall_Filter_control.CW_Pitch_Index)
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
        public static void Display_Filter_Markers()
        {
            int pixel_ratio = 0;
            int cw_offset = 0;
            String Message;

            Pen cursor_pen = new Pen(marker_filter_color, 1.0f);
            cursor_pen.EndCap = LineCap.Triangle;
            //cursor_pen.DashPattern = new float[] { 4.0F, 10.0F, 4.0F, 10.0F };
            cursor_pen.DashStyle = DashStyle.Solid;
            cw_offset = Get_CW_Offset();
            pixel_ratio = Waterfall_Controls.Markers.DISPLAY_BANDWIDTH / waterfall_bmp.Width;
            if (Waterfall_Last_used.Current_mode != 'A')
            {
                pic_line_center = (waterfall_bmp.Width / 2)  + cw_offset + GRAPH_OFFSET_ADJUSTMENT;
            }
            else
            {
                pic_line_center = (waterfall_bmp.Width / 2) + (Waterfall_Controls.Markers.AM_RX_OFFSET) + GRAPH_OFFSET_ADJUSTMENT;
            }
            pic_line_bottom = waterfall_bmp.Height;
            int filter_size = Filter_size(Waterfall_Controls.Markers.band_marker_high);
            int cursor_marker = filter_size / pixel_ratio;
            pic_high_cursor = pic_line_center + cursor_marker;
            pic_low_cursor = pic_line_center - cursor_marker;

            Message = "Display_Cursors -> pic_line_center: " + Convert.ToString(pic_line_center);
            //Write_Debug_Message(Message);
            Message = "Display_Cursors -> pic_high_cursor: " + Convert.ToString(pic_high_cursor);
            //Write_Debug_Message(Message);
            //using (Graphics gr = Form1.Waterfall_Controls.Waterfall_graphics)
            using (Graphics gr = Graphics.FromImage(waterfall_bmp))
            {
                switch (Waterfall_Last_used.Current_mode)
                {
                    case 'A':
                        gr.DrawLine(cursor_pen, pic_high_cursor, 0, pic_high_cursor, pic_line_bottom);
                        gr.DrawLine(cursor_pen, pic_low_cursor, 0, pic_low_cursor, pic_line_bottom);
                        break;
                    case 'U':
                        gr.DrawLine(cursor_pen, pic_high_cursor, 0, pic_high_cursor, pic_line_bottom);
                        break;
                    case 'L':
                        gr.DrawLine(cursor_pen, pic_low_cursor, 0, pic_low_cursor, pic_line_bottom);
                        break;
                }
            }
        }
        public static void Waterfall_zoom(int width_delta)
        {
            String Message;
            int waterfall_buffer_index = 0;
            int Y = 0;
            int zoom_limit = 0;
            int waterfall_limit = Waterfall_Controls.waterfall_data.Length;
            int pan_buff_start = Waterfall_Controls.Wheel_value;
            int pan_buff_stop = pan_buff_limit - Waterfall_Controls.Wheel_value;
            int pan_buff_size = pan_buff_stop - pan_buff_start;
            float ratio = (float)waterfall_limit / (float)pan_buff_size;

            Waterfall_Controls.Zoom_process = true;
            zoom_limit = pan_buff_limit - Waterfall_Controls.Wheel_value;
            for (pan_buff_count = Waterfall_Controls.Wheel_value;
                pan_buff_count < zoom_limit; pan_buff_count++)
            {
                Y = (Waterfall_Controls.Display_Buffer.Y_value[pan_buff_count]);
                Message = " Zoom -> count: " + Convert.ToString(pan_buff_count) + " limit: " +
                        Convert.ToString(zoom_limit) + " Ratio: " + Convert.ToString((int)ratio);
                if (previous_ratio != ratio)
                {
                    Write_Waterfall_Debug_Message(Message);
                    previous_ratio = ratio;
                }
                //if (Y <= Waterfall_form.low_thread_hold)
                //{
                //    Y = Y + Waterfall_form.zero_gain;
                //}
                if ((int)ratio == 0)
                {
                    if ((pan_buff_count % (width_delta + 2)) == 0)
                    {
                        Display_GDI.new_waterfall_data[waterfall_buffer_index] = Y;
                        Message = " Modulous applied: pan_buff_count: " +
                            Convert.ToString(pan_buff_count) +
                            " delta:" + Convert.ToString(width_delta);
                        //Write_Debug_Message(Message);
                    }
                    else
                    {
                        Display_GDI.new_waterfall_data[waterfall_buffer_index++] = Y;
                        Message = " Modulous not applied";
                        //Write_Debug_Message(Message);
                    }
                }
                else
                {
                    for (int x = 0; x < ratio; x++)
                    {
                        // waterfall_buffer_index = waterfall_buffer_index + x;
                        /*if ((pan_buff_count % (width_delta + 2)) == 0)
                        {
                            Display_GDI.new_waterfall_data[waterfall_buffer_index] = Y;
                            Message = " Modulous applied: pan_buff_count: " +
                                Convert.ToString(pan_buff_count) +
                                " delta:" + Convert.ToString(width_delta);
                            //Write_Debug_Message(Message);
                        }
                        else*/
                        //{
                        Display_GDI.new_waterfall_data[waterfall_buffer_index++] = Y;
                        Message = " Modulous not applied";
                        //Write_Debug_Message(Message);
                        // }
                    }
                }
            }
            Waterfall_Controls.Zoom_process = false;
        }
        public static void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            String Message;
            try
            {
                //Local_Debug_Message(" pictureBox_Paint. CALLED");
                e.Graphics.DrawImage(waterfall_bmp, 0, 0, G_Width, G_Height);
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                Message = " pictureBox_Paint. " + ex.ToString();
                Write_Waterfall_Debug_Message(Message);
            }
        }
        unsafe public static void DrawWaterfall(Graphics g, int W, int H)  // changes yt7pwr
        {
            String Message;
            int center_marker_on = 0;

            int i = 0;
            int R = 0, G = 0, B = 0;
            int pixel_size = 3;
            byte* row = null;

            int seconds = 0;
            int my_x0 = 5;
            int my_y0 = 0;
            int my_x1 = waterfall_bmp.Width;
            int my_y1 = 0;
            bool blank = false;
            //int x = 0;

            G_Height = H;
            G_Width = W;
            System.Drawing.Font font = new System.Drawing.Font("Arial", 8);
            SolidBrush grid_text_brush = new SolidBrush(Color.White);
            //waterfall_low_threshold = Window_controls.Waterfall_Controls.zero;
            waterfall_low_threshold = -110.0F;

            if ((Waterfall_Panadapter_Controls.Window_Minimized == false))

            {
                //Waterfall_Ready = false;
                Array.Copy(Waterfall_Controls.current_waterfall_data, 0, Waterfall_Controls.waterfall_data, 0, W);
                //Display_Filter_Markers();
                //Display_Cursor();

                Rectangle rect = new Rectangle(0, 0, waterfall_bmp.Width, waterfall_bmp.Height);
                BitmapData bitmapData = waterfall_bmp.LockBits(rect, ImageLockMode.ReadWrite, waterfall_bmp.PixelFormat);

                if (reverse_waterfall)
                {
                    try
                    {
                        // scroll image up
                        IntPtr source = bitmapData.Scan0 + bitmapData.Stride;
                        IntPtr dest = bitmapData.Scan0;
                        int bytes = Math.Abs(bitmapData.Stride) * bitmapData.Height;
                        byte[] dest_bytes = new byte[bytes];
                        Marshal.Copy(source, dest_bytes, 0, bytes);
                        Marshal.Copy(dest_bytes, 0, dest, bytes);
                        row = (byte*)(bitmapData.Scan0.ToInt32() + bytes - bitmapData.Stride);

                    }
                    catch (Exception ex)
                    {
                        Debug.Write(ex.ToString());
                        Message = " DrawWaterfallDisplay -> Reverse: " + ex.ToString();
                        Write_Waterfall_Debug_Message(Message);
                    }
                }
                else
                {
                    try
                    {
                        // scroll image down
                        IntPtr dest = bitmapData.Scan0 + bitmapData.Stride;
                        IntPtr source = bitmapData.Scan0;
                        int bytes = Math.Abs(bitmapData.Stride) * bitmapData.Height;
                        byte[] dest_bytes = new byte[bytes];
                        Marshal.Copy(source, dest_bytes, 0, bytes);
                        Marshal.Copy(dest_bytes, 0, dest, (bytes - bitmapData.Stride));
                        row = (byte*)(bitmapData.Scan0.ToInt32());
                    }
                    catch (Exception ex)
                    {
                        Debug.Write(ex.ToString());
                        Message = " DrawWaterfallDisplay -> Normal: " + ex.ToString();
                        Write_Waterfall_Debug_Message(Message);
                    }
                }
                i = 0;
                blank = false;

                switch (color_sheme)
                {
                    case (ColorSheme.original):                        // tri color only
                        {
                            for (i = 0; i < W; i++) // for each pixel in the new line
                            {
                                if (i == (pic_line_center))
                                {
                                    blank = true;
                                    if (center_marker_on++ < 10)
                                    {
                                        R = waterfall_center_marker_color.R;
                                        G = waterfall_center_marker_color.G;
                                        B = waterfall_center_marker_color.B;
                                    }
                                    else
                                    {
                                        if (center_marker_on < 20)
                                        {
                                            R = WaterfallLowColor.R;
                                            G = WaterfallLowColor.G;
                                            B = WaterfallLowColor.B;
                                        }
                                        else
                                        {
                                            center_marker_on = 0;
                                        }
                                    }
                                    //    Message = " i: " + Convert.ToString(i) + " pic_line_center: " + Convert.ToString(pic_line_center);
                                    //Write_Debug_Message(Message);
                                }
                                else
                                {
                                    blank = false;
                                }
                                if (!blank)
                                {
                                    if (Waterfall_Controls.waterfall_data[i] <= waterfall_low_threshold) // if less than low threshold,
                                    {                                                 // just use low color
                                        R = WaterfallLowColor.R;
                                        G = WaterfallLowColor.G;
                                        B = WaterfallLowColor.B;
                                    }
                                    else
                                        if (Waterfall_Controls.waterfall_data[i] >= waterfall_high_threshold)   // if more than high threshold, 
                                    {                                                           //just use high color
                                        R = WaterfallHighColor.R;
                                        G = WaterfallHighColor.G;
                                        B = WaterfallHighColor.B;
                                        //Message = " high threadhold Data: " + Convert.ToString(waterfall_data[i]) +
                                        //    " Threadhold: " + Convert.ToString(waterfall_high_threshold);
                                        //Write_Debug_Message(Message);
                                    }
                                    else
                                        if (Waterfall_Controls.waterfall_data[i] > waterfall_low_threshold &&
                                        Waterfall_Controls.waterfall_data[i] <
                                        waterfall_high_threshold) // use a color between high and low
                                    {

                                        float percent = (Waterfall_Controls.waterfall_data[i] - waterfall_low_threshold) /
                                            (waterfall_high_threshold - waterfall_low_threshold);
                                        if (percent <= 0.5) // use a gradient between low and mid colors
                                        {
                                            percent *= 2;

                                            R = (int)((1 - percent) * WaterfallLowColor.R + percent * WaterfallMidColor.R);
                                            G = (int)((1 - percent) * WaterfallLowColor.G + percent * WaterfallMidColor.G);
                                            B = (int)((1 - percent) * WaterfallLowColor.B + percent * WaterfallMidColor.B);
                                        }
                                        else                // use a gradient between mid and high colors
                                        {
                                            percent = (float)(percent - 0.5) * 2;

                                            R = (int)((1 - percent) * WaterfallMidColor.R + percent * WaterfallHighColor.R);
                                            G = (int)((1 - percent) * WaterfallMidColor.G + percent * WaterfallHighColor.G);
                                            B = (int)((1 - percent) * WaterfallMidColor.B + percent * WaterfallHighColor.B);
                                        }
                                    }
                                }
                                row[i * pixel_size + 0] = (byte)B;  // set color in memory
                                row[i * pixel_size + 1] = (byte)G;
                                row[i * pixel_size + 2] = (byte)R;
                            }
                        }
                        break;

                    case (ColorSheme.enhanced):
                        {
                            // draw new data
                            for (i = 0; i < W; i++) // for each pixel in the new line
                            {
                                if (i == (pic_line_center))
                                {
                                    blank = true;
                                    if (center_marker_on++ < 10)
                                    {
                                        R = waterfall_center_marker_color.R;
                                        G = waterfall_center_marker_color.G;
                                        B = waterfall_center_marker_color.B;
                                    }
                                    else
                                    {
                                        if (center_marker_on < 20)
                                        {
                                            R = WaterfallLowColor.R;
                                            G = WaterfallLowColor.G;
                                            B = WaterfallLowColor.B;
                                        }
                                        else
                                        {
                                            center_marker_on = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    blank = false;
                                }
                                if (!blank)
                                {
                                    if (Waterfall_Controls.waterfall_data[i] <= waterfall_low_threshold)
                                    {
                                        R = WaterfallLowColor.R;
                                        G = WaterfallLowColor.G;
                                        B = WaterfallLowColor.B;
                                    }
                                    else if (Waterfall_Controls.waterfall_data[i] >= WaterfallHighThreshold)
                                    {
                                        R = 192;
                                        G = 124;
                                        B = 255;
                                    }
                                    else // value is between low and high
                                    {
                                        float range = WaterfallHighThreshold - waterfall_low_threshold;
                                        float offset = Waterfall_Controls.waterfall_data[i] - waterfall_low_threshold;
                                        float overall_percent = offset / range; // value from 0.0 to 1.0 where 1.0 is high and 0.0 is low.

                                        if (overall_percent < (float)2 / 9) // background to blue
                                        {
                                            float local_percent = overall_percent / ((float)2 / 9);
                                            R = (int)((1.0 - local_percent) * WaterfallLowColor.R);
                                            G = (int)((1.0 - local_percent) * WaterfallLowColor.G);
                                            B = (int)(WaterfallLowColor.B + local_percent * (255 - WaterfallLowColor.B));
                                        }
                                        else if (overall_percent < (float)3 / 9) // blue to blue-green
                                        {
                                            float local_percent = (overall_percent - (float)2 / 9) / ((float)1 / 9);
                                            R = 0;
                                            G = (int)(local_percent * 255);
                                            B = 255;
                                        }
                                        else if (overall_percent < (float)4 / 9) // blue-green to green
                                        {
                                            float local_percent = (overall_percent - (float)3 / 9) / ((float)1 / 9);
                                            R = 0;
                                            G = 255;
                                            B = (int)((1.0 - local_percent) * 255);
                                        }
                                        else if (overall_percent < (float)5 / 9) // green to red-green
                                        {
                                            float local_percent = (overall_percent - (float)4 / 9) / ((float)1 / 9);
                                            R = (int)(local_percent * 255);
                                            G = 255;
                                            B = 0;
                                        }
                                        else if (overall_percent < (float)7 / 9) // red-green to red
                                        {
                                            float local_percent = (overall_percent - (float)5 / 9) / ((float)2 / 9);
                                            R = 255;
                                            G = (int)((1.0 - local_percent) * 255);
                                            B = 0;
                                        }
                                        else if (overall_percent < (float)8 / 9) // red to red-blue
                                        {
                                            float local_percent = (overall_percent - (float)7 / 9) / ((float)1 / 9);
                                            R = 255;
                                            G = 0;
                                            B = (int)(local_percent * 255);
                                        }
                                        else // red-blue to purple end
                                        {
                                            float local_percent = (overall_percent - (float)8 / 9) / ((float)1 / 9);
                                            R = (int)((0.75 + 0.25 * (1.0 - local_percent)) * 255);
                                            G = (int)(local_percent * 255 * 0.5);
                                            B = 255;
                                        }
                                    }
                                }
                                row[i * pixel_size + 0] = (byte)B;
                                row[i * pixel_size + 1] = (byte)G;
                                row[i * pixel_size + 2] = (byte)R;
                            }
                        }
                        break;

                    case (ColorSheme.SPECTRAN):
                        {
                            // draw new data
                            for (i = 0; i < W; i++) // for each pixel in the new line
                            {
                                if (i == (pic_line_center))
                                {
                                    blank = true;
                                    if (center_marker_on++ < 10)
                                    {
                                        R = waterfall_center_marker_color.R;
                                        G = waterfall_center_marker_color.G;
                                        B = waterfall_center_marker_color.B;
                                    }
                                    else
                                    {
                                        if (center_marker_on < 20)
                                        {
                                            R = WaterfallLowColor.R;
                                            G = WaterfallLowColor.G;
                                            B = WaterfallLowColor.B;
                                        }
                                        else
                                        {
                                            center_marker_on = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    blank = false;
                                }
                                if (!blank)
                                {
                                    if (Waterfall_Controls.waterfall_data[i] <= waterfall_low_threshold)
                                    {
                                        R = 0;
                                        G = 0;
                                        B = 0;
                                    }
                                    else if (Waterfall_Controls.waterfall_data[i] >= WaterfallHighThreshold) // white
                                    {
                                        R = 240;
                                        G = 240;
                                        B = 240;
                                    }
                                    else // value is between low and high
                                    {
                                        float range = WaterfallHighThreshold - waterfall_low_threshold;
                                        float offset = Waterfall_Controls.waterfall_data[i] - waterfall_low_threshold;
                                        float local_percent = ((100.0f * offset) / range);

                                        if (local_percent < 5.0f)
                                        {
                                            R = G = 0;
                                            B = (int)local_percent * 5;
                                        }
                                        else if (local_percent < 11.0f)
                                        {
                                            R = G = 0;
                                            B = (int)local_percent * 5;
                                        }
                                        else if (local_percent < 22.0f)
                                        {
                                            R = G = 0;
                                            B = (int)local_percent * 5;
                                        }
                                        else if (local_percent < 44.0f)
                                        {
                                            R = G = 0;
                                            B = (int)local_percent * 5;
                                        }
                                        else if (local_percent < 51.0f)
                                        {
                                            R = G = 0;
                                            B = (int)local_percent * 5;
                                        }
                                        else if (local_percent < 66.0f)
                                        {
                                            R = G = (int)(local_percent - 50) * 2;
                                            B = 255;
                                        }
                                        else if (local_percent < 77.0f)
                                        {
                                            R = G = (int)(local_percent - 50) * 3;
                                            B = 255;
                                        }
                                        else if (local_percent < 88.0f)
                                        {
                                            R = G = (int)(local_percent - 50) * 4;
                                            B = 255;
                                        }
                                        else if (local_percent < 99.0f)
                                        {
                                            R = G = (int)(local_percent - 50) * 5;
                                            B = 255;
                                        }
                                    }
                                }
                                // set pixel color
                                row[i * pixel_size + 0] = (byte)B;  // set color in memory
                                row[i * pixel_size + 1] = (byte)G;
                                row[i * pixel_size + 2] = (byte)R;
                            }
                        }
                        break;

                    case (ColorSheme.BLACKWHITE):
                        {
                            // draw new data
                            for (i = 0; i < W; i++) // for each pixel in the new line
                            {
                                if (i == (pic_line_center))
                                {
                                    blank = true;
                                    if (center_marker_on++ < 10)
                                    {
                                        R = waterfall_center_marker_color.R;
                                        G = waterfall_center_marker_color.G;
                                        B = waterfall_center_marker_color.B;
                                    }
                                    else
                                    {
                                        if (center_marker_on < 20)
                                        {
                                            R = WaterfallLowColor.R;
                                            G = WaterfallLowColor.G;
                                            B = WaterfallLowColor.B;
                                        }
                                        else
                                        {
                                            center_marker_on = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    blank = false;
                                }
                                if (!blank)
                                {
                                    if (Waterfall_Controls.waterfall_data[i] <= waterfall_low_threshold)
                                    {
                                        R = 0;
                                        G = 0;
                                        B = 0;
                                    }
                                    else if (Waterfall_Controls.waterfall_data[i] >= WaterfallHighThreshold) // white
                                    {
                                        R = 255;
                                        G = 255;
                                        B = 255;
                                    }
                                    else // value is between low and high
                                    {
                                        float range = WaterfallHighThreshold - waterfall_low_threshold;
                                        float offset = Waterfall_Controls.waterfall_data[i] - waterfall_low_threshold;
                                        float overall_percent = offset / range; // value from 0.0 to 1.0 where 1.0 is high and 0.0 is low.
                                        float local_percent = ((100.0f * offset) / range);
                                        //float contrast = (console.SetupForm.DisplayContrast / 100);
                                        R = (int)((local_percent / 100) * 255);
                                        G = R;
                                        B = R;
                                    }
                                }
                                // set pixel color
                                row[i * pixel_size + 0] = (byte)B;  // set color in memory
                                row[i * pixel_size + 1] = (byte)G;
                                row[i * pixel_size + 2] = (byte)R;
                            }
                        }
                        break;
                }
                waterfall_bmp.UnlockBits(bitmapData);
                if (current_display_mode == DisplayMode.WATERFALL)
                {
                    //g.DrawImageUnscaled(waterfall_bmp, 0, 0);  // draw the image on the background	
                    g.DrawImage(waterfall_bmp, 0, 0, W, (H));
                }
                else
                {
                    //g.DrawImageUnscaled(waterfall_bmp, 0, 0);
                    g.DrawImage(waterfall_bmp, 0, 0, W, (H));
                }
                using (Graphics gr = Graphics.FromImage(waterfall_bmp))
                {
                    //gr.SmoothingMode = SmoothingMode.AntiAlias;
                    Pen time_mark_pen = new Pen(Color.White, 1);

                    if (Waterfall_Controls.Time_grid != 0)
                    {
                        seconds = DateTime.Now.Second;
                        if (Waterfall_Controls.seconds != seconds)
                        {
                            if ((seconds % Waterfall_Controls.Time_grid) == 0)
                            {
                                if (!reverse_waterfall)
                                {
                                    my_x0 = 0;
                                    my_y0 = 0;
                                    my_x1 = waterfall_bmp.Width;
                                    my_y1 = 0;
                                }
                                else
                                {
                                    my_x0 = 0;
                                    my_y0 = waterfall_bmp.Height - 12;
                                    my_x1 = waterfall_bmp.Width;
                                    my_y1 = waterfall_bmp.Height - 12;
                                }
                                gr.DrawLine(time_mark_pen, (my_x0 + 32), (my_y0 + 10), (my_x1), (my_y1 + 10));
                                gr.DrawString(DateTime.UtcNow.ToString("mm:ss"), font, grid_text_brush, my_x0 + 2, my_y0);
                                Waterfall_Controls.seconds = seconds;
                            }
                        }
                    }
                }
                Display_Filter_Markers();
            }
            Waterfall_Ready = true;
        }
    }
}