using Logika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerskiDeo
{
    public partial class FrmServer : Form
    {
        Server server;
        public FrmServer()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            server = new Server();
            if (server.Start())
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                MessageBox.Show("Server je pokrenut!");
                lblPoruka.Text = "Server je pokrenut!";
                Thread nit = new Thread(server.Listen);
                nit.Start();
            }
            else
            {
                MessageBox.Show("Server je vec pokrenut");
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            server?.Stop();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            MessageBox.Show("Server je zaustavljen!");
            Kontroler.Instance.OdjaviSveKorisnike();
            lblPoruka.Text = "Server je zaustavljen!";
        }
        private void frmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
