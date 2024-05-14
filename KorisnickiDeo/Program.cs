using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiDeo
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

            while (true)
            {
                try
                {
                    Application.Run(new FrmLogin());
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ServerCommunicationException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
