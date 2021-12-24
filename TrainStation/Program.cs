using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>z
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Employee());
        }
    }
}
