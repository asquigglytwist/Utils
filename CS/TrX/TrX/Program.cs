using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrX
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
            Logger.LogT("Initialization Begin.");
            Application.Run(new frmMain());
        }

        internal static string GetTypeName()
        {
            return "program";
        }
    }
}
