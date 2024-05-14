using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiDeo
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            KontrolerKomunikacije.Instance.MarkicaIzmenjena += MarkicaIzmenjenaHandler;
            this.Text = KontrolerKomunikacije.Instance.prijavljenaInstitucija.Naziv;
            txtSearch.Visible = false;
            lblLupa.Visible = false;

        }
        private string signal;
        List<Markica> markice;
        private void izmeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            lblLupa.Visible = true;
            markice = KontrolerKomunikacije.Instance.GetMarkice();
            if (dgvZaSearch.Columns.Count != 0)
            {
                dgvZaSearch.Columns.Clear();
            }
            dgvZaSearch.Columns.Add("MarkicaID", "MarkicaID");
            dgvZaSearch.Columns["MarkicaID"].Visible = false;
            dgvZaSearch.Columns.Add("Naziv", "Naziv");
            dgvZaSearch.Columns.Add("Godina", "Godina");
            dgvZaSearch.Columns.Add("Opis", "Opis");
            dgvZaSearch.Columns.Add("Vrednost", "Vrednost");
            dgvZaSearch.Columns.Add("Drzava", "Drzava");
            dgvZaSearch.Columns.Add("Dizajner", "Dizajner");
            dgvZaSearch.Columns.Add("Kategorije", "Kategorije");
            foreach (Markica markica in markice)
            {
                string kategorijeString = string.Join(", ", markica.Kategorije.Select(k => k.Naziv));
                dgvZaSearch.Rows.Add(markica.MarkicaID, markica.Naziv, markica.Godina, markica.Opis, markica.Vrednost, markica.Drzava, markica.Dizajner, kategorijeString);
            }
            signal = "Markica";
        }
        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KontrolerKomunikacije.Instance.OdjaviAdmina();
            KontrolerKomunikacije.Instance.PrikaziFrmLogin();
            this.Close();
        }
        private void kreirajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmIzlozba izlozbaa = new FrmIzlozba();
            izlozbaa.Show();
        }
        List<Izlozba> izlozbe;
        private void vidiSveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            txtSearch.Text = "";
            lblLupa.Visible = true;

            if (dgvZaSearch.Columns.Count != 0)
            {
                dgvZaSearch.Columns.Clear();
            }
            dgvZaSearch.Columns.Add("Naziv", "Naziv");
            dgvZaSearch.Columns.Add("DatumOdrzavanja", "Datum Održavanja");
            dgvZaSearch.Columns.Add("MestoOdrzavanja", "Mesto Održavanja");
            dgvZaSearch.Columns.Add("DodatniDetalji", "Dodatni Detalji");
            dgvZaSearch.Columns.Add("Rezervacije", "Broj Rezervacija");

            izlozbe = KontrolerKomunikacije.Instance.GetIzlozbePlus();

            foreach (Izlozba izlozba in izlozbe)
            {
                int brojRezervacija = izlozba.Rezervacije != null ? izlozba.Rezervacije.Count : 0;
                dgvZaSearch.Rows.Add(izlozba.Naziv, izlozba.DatumOdrzavanja, izlozba.MestoOdrzavanja, izlozba.DodatniDetalji, brojRezervacija);
            }
            signal = "Izlozba";

        }
        private void MarkicaIzmenjenaHandler(object sender, EventArgs e)
        {
            markice = KontrolerKomunikacije.Instance.GetMarkice();

            dgvZaSearch.Rows.Clear();
            foreach (Markica markica in markice)
            {
                string kategorijeString = string.Join(", ", markica.Kategorije.Select(k => k.Naziv));
                dgvZaSearch.Rows.Add(markica.MarkicaID, markica.Naziv, markica.Godina, markica.Opis, markica.Vrednost + " $", markica.Drzava, markica.Dizajner, kategorijeString);
            }
        }
        private void kreirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markice = KontrolerKomunikacije.Instance.GetMarkice();
            if (dgvZaSearch.Columns.Count != 0)
            {
                dgvZaSearch.Columns.Clear();
            }
            dgvZaSearch.Columns.Add("MarkicaID", "MarkicaID");
            dgvZaSearch.Columns["MarkicaID"].Visible = false;
            dgvZaSearch.Columns.Add("Naziv", "Naziv");
            dgvZaSearch.Columns.Add("Godina", "Godina");
            dgvZaSearch.Columns.Add("Opis", "Opis");
            dgvZaSearch.Columns.Add("Vrednost", "Vrednost");
            dgvZaSearch.Columns.Add("Drzava", "Drzava");
            dgvZaSearch.Columns.Add("Dizajner", "Dizajner");
            dgvZaSearch.Columns.Add("Kategorije", "Kategorije");
            foreach (Markica markica in markice)
            {
                string kategorijeString = string.Join(", ", markica.Kategorije.Select(k => k.Naziv));
                dgvZaSearch.Rows.Add(markica.MarkicaID, markica.Naziv, markica.Godina, markica.Opis, markica.Vrednost + " $", markica.Drzava, markica.Dizajner, kategorijeString);
            }
            KontrolerKomunikacije.Instance.PrikaziFrmMarkica();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string pretraga = txtSearch.Text.ToLower();

            switch (signal)
            {
                case "Markica":
                    List<Markica> rezultatiM = KontrolerKomunikacije.Instance.PretraziMarkice(pretraga);
                    if (rezultatiM.Count == 0) MessageBox.Show("Nije moguce naci markice po zadatom nazivu");
                    dgvZaSearch.DataSource = null;
                    dgvZaSearch.Rows.Clear();
                    foreach (Markica markica in rezultatiM)
                    {
                        string kategorijeString = markica.Kategorije != null ? string.Join(", ", markica.Kategorije.Select(k => k.Naziv)) : " ";
                        dgvZaSearch.Rows.Add(markica.MarkicaID, markica.Naziv, markica.Godina, markica.Opis, markica.Vrednost, markica.Drzava, markica.Dizajner, kategorijeString);
                    }
                    break;

                case "Izlozba":
                    List<Izlozba> rezultatiI = KontrolerKomunikacije.Instance.PretraziIzlozbe(pretraga);

                    dgvZaSearch.DataSource = null;
                    dgvZaSearch.Rows.Clear();
                    foreach (Izlozba izlozba in rezultatiI)
                    {
                        int brojRezervacija = izlozba.Rezervacije != null ? izlozba.Rezervacije.Count : 0;
                        dgvZaSearch.Rows.Add(izlozba.Naziv, izlozba.DatumOdrzavanja, izlozba.MestoOdrzavanja, izlozba.DodatniDetalji, brojRezervacija);
                    }
                    break;


            }
        }
        int godina;
        float vrednost;
        private void dgvZaSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvZaSearch.Rows.Count)
            {
                DataGridViewRow red = dgvZaSearch.Rows[e.RowIndex];

                Markica markica = new Markica();
                markica.Naziv = red.Cells["Naziv"].Value.ToString();
                if (red.Cells["Godina"].Value != null && !string.IsNullOrEmpty(red.Cells["Godina"].Value.ToString()))
                {
                    if (int.TryParse(red.Cells["Godina"].Value.ToString(), out int godina))
                        markica.Godina = godina;
                    else
                    {
                        Console.WriteLine("Nije moguca konverzija godine u int.");
                        markica.Godina = 1840;
                    }
                }
                markica.Opis = red.Cells["Opis"].Value.ToString();
                if (float.TryParse(red.Cells["Vrednost"].Value.ToString(), out vrednost))
                {
                    markica.Vrednost = vrednost;
                }
                else
                {
                    Console.WriteLine("Nije moguca konverzija vrednosti u float.");
                    markica.Vrednost = 0.0f;
                }
                markica.Drzava = red.Cells["Drzava"].Value.ToString();
                markica.Dizajner = red.Cells["Dizajner"].Value.ToString();
                markica.Slika = "slika.jpg";
                if (red.Cells["MarkicaID"].Value != null && !string.IsNullOrEmpty(red.Cells["MarkicaID"].Value.ToString()))
                {
                    if (int.TryParse(red.Cells["MarkicaID"].Value.ToString(), out int markicaID))
                        markica.MarkicaID = markicaID;
                    else
                    {
                        Console.WriteLine("Nije moguca konverzija id u int.");
                    }
                }
                string kategorijeString = red.Cells["Kategorije"].Value.ToString();
                List<string> kategorije = kategorijeString.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                FrmMarkica formaIzmena = new FrmMarkica(markica, kategorije);
                formaIzmena.Show();
            }

        }
    }
}



