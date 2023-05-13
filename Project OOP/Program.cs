using Project_OOP.Forms;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_OOP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AttachConsole(-1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthenForm());
        }

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
    }
}