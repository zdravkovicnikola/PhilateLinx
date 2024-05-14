using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiDeo
{
    public partial class FrmIzlozba : Form
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
            "Smederevo",
            "Kragujevac",
            "Zenica",
            "Prilep",
            "Cacak",
            "Kraljevo"
        };
        public FrmIzlozba()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
            cmbIzbor.DataSource = gradovi;
            cmbIzbor.SelectedIndex = -1;
            rtbDetalji.Text = "Nema detalja, sve je jasno.";
            dtpDatum.MinDate = DateTime.Now.Date.AddDays(1);
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            string mesto;
            string naziv = txtNaziv.Text;
            if (string.IsNullOrEmpty(naziv))
            {
                txtNaziv.BackColor = Color.Salmon;
                return;
            }
            string detalji = rtbDetalji.Text;
            if (string.IsNullOrEmpty(detalji))
            {
                rtbDetalji.Text = "Nema detalja, sve je jasno.";
            }
            if (cmbIzbor.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbIzbor, "Mesto odrzavanja je neophodno za kreiranje izlozbe.");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbIzbor, ""); 
                mesto = cmbIzbor.SelectedItem.ToString();
            }
            DateTime datum = dtpDatum.Value.Date;

            Izlozba izlozba = new Izlozba()
            {
                Naziv = naziv,
                DatumOdrzavanja = datum,
                MestoOdrzavanja = mesto,
                DodatniDetalji = detalji
            };

            if (KontrolerKomunikacije.Instance.KreirajIzlozbu(izlozba))
            {
                MessageBox.Show("Izlozba uspesno kreirana, srecno!");
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Vec ste kreirali pomenutu izlozbu.");
                return;
            }

        }
    }
}
