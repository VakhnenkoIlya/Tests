using MazayTests.Core;
using System;
using System.Windows.Forms;

namespace MazayTests.Player
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
            //Application.Run(new RunTestForm(Interactive));
            string path = "";

            if (args.Length > 0)
            {
                path = args[0];
            }
            //Application.Run(new OpenFileDialog());
            Application.Run(new MainForm(new TestBuilder().OpenTest(path)));
        }
    }
}
