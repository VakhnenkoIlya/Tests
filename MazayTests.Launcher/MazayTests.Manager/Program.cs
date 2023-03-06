using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazayTests.Manager
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IFSRepository filerepo = new FSRepository();
            if (Directory.Exists("Tests") && Directory.GetDirectories("Tests").Length > 0)
            {
                Application.Run(new ManagerTestsForm(filerepo));
            }
            else
            {
                Application.Run(new StartForm());
            }  
        }
    }
}
