using Semcon_Holiday_and_Timebank_Emailer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semcon_Holiday_and_Timebank_Emailer
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
            //Thread thread = new Thread(new ThreadStart(StartSplash));
            //thread.Start();
            //Thread.Sleep(2000);

            //thread.Abort();
            Application.Run(new SplashScreen());
        }
        static void StartSplash()
        {
            Application.Run(new SplashScreen());
        }
    }
}
