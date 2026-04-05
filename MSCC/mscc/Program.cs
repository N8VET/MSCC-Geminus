using System;
using System.Diagnostics;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmniaGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            using (Mutex mutex = new Mutex(false, @"Global\" + appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("MSCC IS CURRENTLY RUNNING", "MSCC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                Process[] processes = Process.GetProcessesByName("MSCC");

                foreach (Process proc in processes)
                {
                    Master_Controls.proc_name = proc.ProcessName;
                }
                GC.Collect();
                Application.Run(new Main_form());
            }
        }
        private static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";
    }
}
