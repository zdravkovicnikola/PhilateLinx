using KorisnickiInterfejs.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.UCLogin
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            //Communication.Instance.Connect();
            FrmMain main = new FrmMain();
            main.Show();
        }
    }
}
