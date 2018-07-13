using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneFlasher
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
            Application.Run(new Form1());
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            string romDir = Path.GetTempPath().Replace("\\", "/") + "74cded5d19a9d6c7c36f7d74be42ce0c1e722698";
            if (Directory.Exists(romDir)) Directory.Delete(romDir, true);
        }
    }
}
