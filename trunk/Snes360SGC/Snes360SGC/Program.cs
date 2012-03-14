using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Snes360SGC.Tools.Settings;

namespace Snes360SGC
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Settings localSettings;// = Settings.getInstance();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new SplashScreen());
            SplashScreen splash = new SplashScreen();
            splash.ShowDialog();

           
            
            Application.Run(new Main());
        }
    }
}
