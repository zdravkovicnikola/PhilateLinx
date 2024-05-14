using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiDeo
{
    public partial class FrmKorisnik : Form
    {
        bool kraj = false;
        List<Izlozba> listaIzlozbi = new List<Izlozba>() { };
        List<Rezervacija> listaRezervacija = new List<Rezervacija>() { };
        List<Markica> markice;
        bool signal = false;
        public FrmKorisnik()
        {
            InitializeComponent();
            KontrolerKomunikacije.Instance.MarkicaIzmenjena += MarkicaIzmenjenaHandler;
            lblLupa.Visible = false;
            txtSearch.Visible = false;
            lblUsername.Text = KontrolerKomunikacije.Instance.prijavljeniKorisnik.KorisnickoIme;
            dgvIzlozbe.DataSource = KontrolerKomunikacije.Instance.GetIzlozbe();
            #region punimo_Markice
            markice = KontrolerKomunikacije.Instance.GetMarkice();
            dgvMarkice.Columns.Add("MarkicaID", "MarkicaID");
            dgvMarkice.Columns.Add("Naziv", "Naziv");
            dgvMarkice.Columns.Add("Godina", "Godina");
            dgvMarkice.Columns.Add("Opis", "Opis");
            dgvMarkice.Columns.Add("Vrednost", "Vrednost");
            dgvMarkice.Columns.Add("Drzava", "Drzava");
            dgvMarkice.Columns.Add("Dizajner", "Dizajner");
            dgvMarkice.Columns.Add("Kategorije", "Kategorije");
            dgvMarkice.Columns["MarkicaID"].Visible = false; 
            dgvMarkice.Columns.Add("KolekcijaID", "KolekcijaID");
            dgvMarkice.Columns["KolekcijaID"].Visible = false;
            foreach (Markica markica in markice)
            {
                string kategorijeString = string.Join(", ", markica.Kategorije.Select(k => k.Naziv));
                dgvMarkice.Rows.Add(markica.MarkicaID, markica.Naziv, markica.Godina, markica.Opis, markica.Vrednost + " $", markica.Drzava, markica.Dizajner, kategorijeString);
            }
            #endregion

            AzurirajDGVRezervacija();

            kraj = false;
            Thread nit1 = new Thread(OsveziDGVIzlozba);
            nit1.Start();
        }

        private void MarkicaIzmenjenaHandler(object sender, EventArgs e)
        {

            markice = KontrolerKomunikacije.Instance.GetMarkice();

            dgvMarkice.Rows.Clear();

            foreach (Markica markica in markice)
            {
                string kategorijeString = string.Join(", ", markica.Kategorije.Select(k => k.Naziv));
                dgvMarkice.Rows.Add(markica.MarkicaID, markica.Naziv, markica.Godina, markica.Opis, markica.Vrednost + " $", markica.Drzava, markica.Dizajner, kategorijeString);
            }
        }
        private void AzurirajDGVRezervacija()
        {
            listaRezervacija = KontrolerKomunikacije.Instance.GetRezervacije();
            dgvRezervacije.Columns.Clear();

            dgvRezervacije.Columns.Add("Naziv", "Naziv");
            dgvRezervacije.Columns.Add("Datum", "Datum");
            foreach (Rezervacija rezervacije in listaRezervacija)
            {
                dgvRezervacije.Rows.Add(rezervacije.Izlozba.Naziv, rezervacije.Izlozba.DatumOdrzavanja);
            }
        }
        private void OsveziDGVIzlozba()
        {
            Thread.Sleep(3000);
            while (!kraj)
            {
                try
                {
                    if (listaIzlozbi.Count() != KontrolerKomunikacije.Instance.GetIzlozbe().Count())
                    {
                        listaIzlozbi = KontrolerKomunikacije.Instance.GetIzlozbe();
                        this.Invoke(new Action(() => { dgvIzlozbe.DataSource = null; dgvIzlozbe.DataSource = KontrolerKomunikacije.Instance.GetIzlozbe(); dgvIzlozbe.Columns[0].Visible = false; }));
                    }
                    Thread.Sleep(10000);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    kraj = true;
                    this.BeginInvoke(new Action(() => { this.Close(); KontrolerKomunikacije.Instance.PrikaziFrmLogin(); }));
                }
            }


        }
        private void pretraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            lblLupa.Visible = true;
            markice = KontrolerKomunikacije.Instance.GetMarkice();
            dgvMarkice.Rows.Clear();
            foreach (Markica markica in markice)
            {
                string kategorijeString = string.Join(", ", markica.Kategorije.Select(k => k.Naziv));
                dgvMarkice.Rows.Add(markica.MarkicaID, markica.Naziv, markica.Godina, markica.Opis, markica.Vrednost + " $", markica.Drzava, markica.Dizajner, kategorijeString);
            }
        }
        private void kreirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzlozba izlozbaa = new FrmIzlozba();
            izlozbaa.Show();
        }
        private void btnRezervisi_Click(object sender, EventArgs e)
        {

            if (dgvIzlozbe.SelectedCells.Count == 0)
            {
                MessageBox.Show("Niste izabrali ni jednu izložbu za rezervaciju.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult rezultat = MessageBox.Show("Da li ste sigurni da želite napraviti rezervaciju?", "Potvrda rezervacije", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                int index = dgvIzlozbe.SelectedCells[0].RowIndex;
                Izlozba trazeni = dgvIzlozbe.Rows[index].DataBoundItem as Izlozba;
                if (!KontrolerKomunikacije.Instance.KreirajRezervaciju(trazeni))
                {
                    MessageBox.Show("Vec ste rezervisali pomenutu izlozbu.");
                    return;
                }
                MessageBox.Show("Rezervacija uspešno kreirana!");
                AzurirajDGVRezervacija();
            }
            else
            {
                MessageBox.Show("Rezervacija otkazana.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnUkloniRezervaciju_Click(object sender, EventArgs e)
        {
            if (dgvRezervacije.SelectedCells.Count == 0)
            {
                MessageBox.Show("Niste izabrali ni jednu rezervaciju.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowIndex = dgvRezervacije.SelectedCells[0].RowIndex;

            if (rowIndex >= 0 && rowIndex < dgvRezervacije.Rows.Count)
            {
                List<string> vrednosti = new List<string>();

                foreach (DataGridViewCell cell in dgvRezervacije.Rows[rowIndex].Cells)
                {
                    vrednosti.Add(cell.Value?.ToString() ?? string.Empty);
                }
                DialogResult rezultat = MessageBox.Show($"Da li ste sigurni da želite otkazati rezervaciju za {vrednosti[0]}?", "Otkazivanje rezervacije", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rezultat == DialogResult.Yes)
                {
                    string dateString = vrednosti[1];
                    DateTime parsedDate = DateTime.Parse(dateString);

                    foreach (Rezervacija r in listaRezervacija)
                    {
                        if (r.Izlozba.Naziv == vrednosti[0] && r.Izlozba.DatumOdrzavanja == parsedDate)
                        {
                            if (!KontrolerKomunikacije.Instance.ObrisiRezervaciju(r))
                            {
                                MessageBox.Show("Nije moguce otkazati rezervaciju.");
                                return;
                            }
                        }
                    }

                    AzurirajDGVRezervacija();
                }
                else
                {
                    MessageBox.Show("Rezervacija otkazana.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KontrolerKomunikacije.Instance.Odjavi();
            kraj = true;
            KontrolerKomunikacije.Instance.PrikaziFrmLogin();
            this.Close();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string pretraga = txtSearch.Text.ToLower();
            List<Markica> rezultati = KontrolerKomunikacije.Instance.PretraziMarkice(pretraga);
            if (rezultati.Count == 0) MessageBox.Show("Nije moguce naci markice po zadatom nazivu");
            PrikaziRezultate(rezultati);
        }
        private void PrikaziRezultate(List<Markica> rezultati)
        {
            dgvMarkice.DataSource = null;

            dgvMarkice.Rows.Clear();
            foreach (Markica markica in rezultati)
            {
                string kategorijeString = markica.Kategorije != null ? string.Join(", ", markica.Kategorije.Select(k => k.Naziv)) : " ";
                dgvMarkice.Rows.Add(markica.MarkicaID, markica.Naziv, markica.Godina, markica.Opis, markica.Vrednost + " $", markica.Drzava, markica.Dizajner, kategorijeString);
            }
        }
        private void dgvMarkice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMarkice.Rows.Count)
            {
                DataGridViewRow red = dgvMarkice.Rows[e.RowIndex];

                Markica markica = new Markica();
                markica.Naziv = red.Cells["Naziv"].Value.ToString();
                if (red.Cells["MarkicaID"].Value != null && !string.IsNullOrEmpty(red.Cells["MarkicaID"].Value.ToString()))
                {
                    if (int.TryParse(red.Cells["MarkicaID"].Value.ToString(), out int markicaID))
                        markica.MarkicaID = markicaID;
                    else
                    {
                        Console.WriteLine("Nije moguca konverzija id u int.");
                    }
                }
                if (signal)
                {
                    DialogResult rezultat = MessageBox.Show($"Da li ste sigurni da želite da izbacite {markica.Naziv} iz svoje kolekciju?", "Kolekcija", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (rezultat == DialogResult.Yes)
                    {
                        Kolekcija kolekcija = new Kolekcija();
                        kolekcija.Markica = markica;

                        if (red.Cells["KolekcijaID"].Value != null && !string.IsNullOrEmpty(red.Cells["KolekcijaID"].Value.ToString()))
                        {
                            if (int.TryParse(red.Cells["KolekcijaID"].Value.ToString(), out int markicaID))
                                kolekcija.KolekcijaID = markicaID;
                            else
                            {
                                Console.WriteLine("Nije moguca konverzija id u int.");
                            }
                        }

                        if (!KontrolerKomunikacije.Instance.IzbaciIzKolekcije(kolekcija))
                        {
                            MessageBox.Show("Nije moguce izbaciti trazenu markicu iz kolekcije.");
                            return;
                        }
                        else
                        {
                            MessageBox.Show($"Makrica {kolekcija.Markica.Naziv} je uspešno izbačena iz kolekcije.");
                            Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Vaš zahtev za otkazivanje izbacivanja {markica.Naziv} iz kolekcije je uspešno zabeležen.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { 
                DialogResult rezultat = MessageBox.Show($"Da li ste sigurni da želite da dodate {markica.Naziv} u svoju kolekciju?", "Kolekcija", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rezultat == DialogResult.Yes) { 
                    if (!KontrolerKomunikacije.Instance.UbaciUKolekciju(markica))
                {
                    MessageBox.Show("Markica vec postoji u kolekciji.");
                    return;
                }
                        MessageBox.Show($"Makrica {markica.Naziv} je uspešno ubačena u kolekciju.");
                    }
                else
                {
                    MessageBox.Show($"Vaš zahtev za otkazivanje dodavanja {markica.Naziv} u kolekciju je uspešno zabeležen.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }

            }
        }

        private void udjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
            signal = true;
        }


        private void Refresh()
        {
            List<Kolekcija> kolekcija = KontrolerKomunikacije.Instance.GetKolekcija();
            dgvMarkice.DataSource = null;

            dgvMarkice.Rows.Clear();
            foreach (Kolekcija markica in kolekcija)
            {
                string kategorijeString = markica.Markica.Kategorije != null ? string.Join(", ", markica.Markica.Kategorije.Select(k => k.Naziv)) : " ";
                dgvMarkice.Rows.Add(markica.Markica.MarkicaID, markica.Markica.Naziv, markica.Markica.Godina, markica.Markica.Opis, markica.Markica.Vrednost + " $", markica.Markica.Drzava, markica.Markica.Dizajner, kategorijeString, markica.KolekcijaID);
            }
        }

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markice = KontrolerKomunikacije.Instance.GetMarkice();
            dgvMarkice.DataSource = null;

            dgvMarkice.Rows.Clear();
            foreach (Markica markica in markice)
            {
                string kategorijeString = markica.Kategorije != null ? string.Join(", ", markica.Kategorije.Select(k => k.Naziv)) : " ";
                dgvMarkice.Rows.Add(markica.MarkicaID, markica.Naziv, markica.Godina, markica.Opis, markica.Vrednost + " $", markica.Drzava, markica.Dizajner, kategorijeString);
            }
            signal = false;
        }
    }
}



