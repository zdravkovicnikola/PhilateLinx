using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KorisnickiInterfejs.Forme
{
    public partial class FrmMain : Form
    {
        public static DataGridView dgvPris;
        public static Label lblPris;
        public FrmMain()
        {
            InitializeComponent();
            dgvPrisustvo.Visible = false;
            lblPrisustvuju.Visible = false;
            dgvPris = dgvPrisustvo;
            lblPris = lblPrisustvuju;
            lblLupa.Visible = false;
        }

        private void pretraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kreiranje TextBox-a za unos kriterijuma
            System.Windows.Forms.TextBox textBoxPretraga = new System.Windows.Forms.TextBox();
            textBoxPretraga.Location = new Point(10, 10); // Podesite poziciju TextBox-a prema potrebi
            textBoxPretraga.Size = new Size(200, 20); // Podesite veličinu TextBox-a prema potrebi
            textBoxPretraga.Font = new Font("Bodoni MT", 12);
            // Dodajte TextBox u formu
            this.Controls.Add(textBoxPretraga);
            lblLupa.Visible = true;
        }

        private void kreirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzlozbaa izlozbaa = new FrmIzlozbaa(dgvPris, lblPris);
            izlozbaa.Show();
        }

        private void udjiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
