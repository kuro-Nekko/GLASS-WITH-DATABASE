using static System.Globalization.Calendar;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLASS_WITH_DATABASE
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new loadingScreen());
            //Application.Run(new logInScreen());
            //Application.Run(new calendar());
            Application.Run(new teacherHome());
        }
    }
}
