using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificationWindows
{
    internal class Process
    {
        //launch a invisible cmd in admin mode
        public static string LaunchCmd(string command)
        {
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            procStartInfo.Verb = "runas";
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            proc.WaitForExit();
            return proc.StandardOutput.ReadToEnd();

        }

        //launch sfc /scannow command using LaunchCmd method
        public static void LaunchSfc()
        {
            string output = LaunchCmd("sfc /scannow");
            switch (output)
            {

            }

        }
    }
}
