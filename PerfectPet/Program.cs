using System;
using System.Windows.Forms;
using PerfectPet.Container;

namespace PerfectPet
{
    static class Program
    {
        public static string AppTitle = "Perfect Pet Kennel Management Software";
        public static bool CompanyExists;
        public static int CompanyId = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Bootstrapper.BootstrapStructuremap();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHome());

        }
    }
}
