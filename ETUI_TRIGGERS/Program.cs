using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ETUI_TRIGGERS
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
            
            Application.Run(new WelcomeScreen());
            //Application.Run(new TriggerEditor());
            //Application.Run(new SelectOperation());
            //Application.Run(new Dock());
        }
    }
}
