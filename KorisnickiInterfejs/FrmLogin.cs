using Forme.UCLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Forme
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            UCLogin.UCLogin login = new UCLogin.UCLogin();
            pnlLoginFrm.Controls.Add(login);
            login.Dock = DockStyle.Fill;
        }

        private void pomocniMeni_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registrujSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCLogin.UCRegister registerUserControl = new UCLogin.UCRegister();

            // Postavljanje veličine glavne forme da odgovara veličini UserControl-a za register
            this.ClientSize = new System.Drawing.Size(registerUserControl.Width, registerUserControl.Height);

            // Postavljanje UserControl-a za register kao trenutni UserControl
            pnlLoginFrm.Controls.Clear(); // Brišemo trenutni UserControl
            pnlLoginFrm.Controls.Add(registerUserControl); // Dodajemo UserControl za register u Panel
        }
    }
}
