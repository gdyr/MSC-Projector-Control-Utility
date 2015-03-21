using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PJControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Find projector details

            Object pjIP = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\MSC\PJControl", "IPAddress", null);
            if (pjIP == null)
            {
                MessageBox.Show("Projector Control is not configured on this computer.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PJOverlay(new Projector((string) pjIP)));
        }
    }
}
