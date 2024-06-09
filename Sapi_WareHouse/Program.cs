using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Sapi_WareHouse.models;

namespace Sapi_WareHouse
{
    static class Program
    {
        public static bool Belepett = false;
        public static dolgozo LoggedInUser;
        public static LoginForm l;
        public static bool popup; 

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists(Environment.CurrentDirectory+"popupconfig.txt"))
            {
                File.Create(Environment.CurrentDirectory + "popupconfig.txt");
                File.WriteAllText(Environment.CurrentDirectory+"popupconfig.txt", "True");
           
            }
            popup = bool.Parse(File.ReadAllText(Environment.CurrentDirectory + "popuconfig.txt"));
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            l = new LoginForm();
            l.ShowDialog();
            //Belepett = true; SQL sql = new SQL(); LoggedInUser = sql.Dolgozok.First();
            if (Belepett == true) Application.Run(new Fomenu());
           
           
        }
    }
}
