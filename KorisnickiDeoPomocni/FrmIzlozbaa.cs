using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kor
{
    public partial class FrmIzlozbaa : Form
    {
        List<string> gradovi = new List<string>
        {
            "Beograd",
            "Zagreb",
            "Sarajevo",
            "Skopje",
            "Ljubljana",
            "Podgorica",
            "Pristina",
            "Split",
            "Novi Sad",
            "Banja Luka",
            "Mostar",
            "Niš",
            "Prizren",
            "Subotica",
            "Bitola",
            "Kragujevac",
            "Zenica",
            "Prilep",
            "Čačak",
            "Kraljevo"
        };
        private DataGridView dgvPris;
        private Label lblPris;

        public FrmIzlozbaa()
        {
            InitializeComponent();
            cmbIzbor.DataSource = gradovi;
        }

        public FrmIzlozbaa(DataGridView dgvPris, Label lblPris)
        {
            InitializeComponent();
            cmbIzbor.DataSource = gradovi;
            this.dgvPris = dgvPris;
            this.lblPris = lblPris;

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            dgvPris.Visible = true;
            lblPris.Visible = true;
            this.Close();
        }
    }
}
