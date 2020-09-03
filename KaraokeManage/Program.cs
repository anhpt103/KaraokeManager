using KaraokeManage.Common;
using KaraokeManage.Views;
using System;
using System.Windows.Forms;

namespace KaraokeManage
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
            Connection.SetDBConnection();
            Application.Run(new FrmMain());
        }
    }
}
