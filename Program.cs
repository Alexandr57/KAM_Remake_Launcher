using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KAM_Remake_Launcher
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.AppDomain.CurrentDomain.UnhandledException += (sender, e) => { if (e.ExceptionObject != null) System.IO.File.AppendAllText(System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Alexandr_77.log"), e.ExceptionObject.ToString() + "\r\n\r\n"); };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AL7_frmMain());
        }
    }
}
