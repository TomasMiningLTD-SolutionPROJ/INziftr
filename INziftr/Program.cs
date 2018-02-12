using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace INziftr
{
    internal static class Program
    {
        public static Process PriorProcess()
        // Returns a System.Diagnostics.Process pointing to
        // a pre-existing process with the same name as the
        // current one, if any; or null if the current process
        // is unique.
        {
            var curr = Process.GetCurrentProcess();
            var procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (Process p in procs)
            {
                if ((p.Id != curr.Id) &&
                    (p.MainModule.FileName == curr.MainModule.FileName))
                    return p;
            }
            return null;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (PriorProcess() != null)
            {
            }
            else
            {
                Global.coreCount = Environment.ProcessorCount;

                var mos = new ManagementObjectSearcher(@"root\CIMV2", @"SELECT * FROM Win32_Processor");
                foreach (ManagementObject mo in mos.Get())
                {
                    Global.processorname += mo[@"Name"];
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}