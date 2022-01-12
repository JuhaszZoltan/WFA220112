using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220112
{
    internal static class Program
    {
        public static string ConnectionString =>
            @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=utiroda;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
