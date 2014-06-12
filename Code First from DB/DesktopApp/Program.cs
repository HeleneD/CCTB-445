using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. saying main application will be threadsafe
        /// /// global application error handling could be here
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.ThreadException += Application_ThreadException;

            Application.Run(new MainForm());
        }

        //const string message + " An unhandled exception.{0}{1}";
        //private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        //{
        //// handle
        //string exceptionDetail = "Top Level Exception: {2} {0} {3}";
        //Exception root = e.Exception;
        //exceptionDetail}
    }
}
