using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiDeo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            UCLogin.UCLogin login = new UCLogin.UCLogin(this);
            pnlLogin.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            
        }

        private void registrujSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCLogin.UCRegister registerUserControl = new UCLogin.UCRegister(this);

            this.ClientSize = new System.Drawing.Size(registerUserControl.Width, registerUserControl.Height);

            pnlLogin.Controls.Clear(); 
            pnlLogin.Controls.Add(registerUserControl);

        }
    }
}
