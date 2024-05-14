using Domen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiDeo
{

    public partial class FrmMarkica : Form
    {
      

        List<string> drzave = new List<string>
{
    "Srbija", "Hrvatska", "Bosna i Hercegovina", "Crna Gora", "Severna Makedonija",
    "Slovenija", "Slovacka", "Ceska", "Austrija", "Nemacka", "Francuska", "Spanija",
    "Italija", "Grcka", "Turska", "SAD", "Kanada", "Meksiko", "Brazil", "Argentina",
    "Kina", "Japan", "Indija", "Australija", "Juzna Koreja", "Rusija", "Egipat",
    "Juzna Afrika", "Nigerija", "Maroko", "Alzir", "Niger", "Kenija", "Gana", "Etiopija",
    "Saudijska Arabija", "Ujedinjeni Arapski Emirati", "Iran", "Irak", "Jordan",
    "Pakistan", "Banglades", "Indonezija", "Filipini", "Kambodza", "Vietnam",
    "Kanada", "Norveska", "Svedska", "Danska", "Holandija", "Belgija", "Poljska",
    "Madjarska", "Rumunija", "Bugarska", "Portugal", "Svajcarska", "Skotska", "Velika Britanija"
    };
        List<Kategorija> kategorije = new List<Kategorija>();
        public FrmMarkica()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
            drzave.Sort();
            cmbDrzava.DataSource = drzave;
            cmbDrzava.SelectedIndex = -1;

            #region kategorija
            cmbKategorija.DataSource = KontrolerKomunikacije.Instance.GetKategorije();
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaID";
            cmbKategorija.SelectedIndex = -1;

            btnUkloniKategoriju.Enabled = false;
            btnDodajKategoriju.Enabled = false;
            btnOtpremi.Enabled = false;
            btnIzmeni.Enabled = false;
            #endregion
        }
        Markica markicaIzmena = new Markica();
        public FrmMarkica(Markica markica, List<string> kategorijeString)
        {
            markicaIzmena = markica;

            foreach (String nazivKategorije in kategorijeString)
            {
                kategorije.Add(identifikujKategoriju(nazivKategorije));
            }

            InitializeComponent();
            errorProvider1 = new ErrorProvider();
            drzave.Sort();
            cmbDrzava.DataSource = drzave;
            #region kategorija
            cmbKategorija.DataSource = KontrolerKomunikacije.Instance.GetKategorije();
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaID";

            btnUkloniKategoriju.Enabled = true;
            btnDodajKategoriju.Enabled = false;
            btnOtpremi.Enabled = false;
            btnIzmeni.Enabled = true;
            btnKreiraj.Enabled = false;
            #endregion

            #region markica
            txtNaziv.Text = markicaIzmena.Naziv;
            txtGodina.Text = markicaIzmena.Godina.ToString();
            cmbDrzava.SelectedItem = markicaIzmena.Drzava;
            rtbOpis.Text = markicaIzmena.Opis;
            txtVrednost.Text = markicaIzmena.Vrednost.ToString();
            txtDizajner.Text = markicaIzmena.Dizajner.ToString();

            cmbKategorija.SelectedIndex = -1;
            listaKategorija.DataSource = null;
            listaKategorija.DataSource = kategorije;
            listaKategorija.DisplayMember = "Naziv";

            #endregion
        }
        private Kategorija identifikujKategoriju(string nazivKategorije)
        {
            foreach (Kategorija k in KontrolerKomunikacije.Instance.GetKategorije())
            {
                if (k.Naziv == nazivKategorije) return k;
            }
            return new Kategorija();
        }

        string dizajner;
        string drzava;
        string naziv;
        string opis;
        private bool Validacija()
        {
            bool validnost = true;
            List<Kategorija> kategorije = new List<Kategorija>();
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, "Naziv je neophodan za identifikaciju makrice.");
                validnost = false;
            }
            else
            {
                errorProvider1.SetError(txtNaziv, "");
                naziv = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNaziv.Text.ToLower()); ;
            }
            opis = rtbOpis.Text;
            if (string.IsNullOrEmpty(rtbOpis.Text))
            {
                opis = "Nema opisa.";
            }
            if (cmbDrzava.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDrzava, "Drzava nastanka je neophodna za kreiranje markice.");
                validnost = false;
            }
            else
            {
                errorProvider1.SetError(cmbDrzava, "");
                drzava = cmbDrzava.SelectedItem.ToString();
            }
            #region kategorija
            //if (cmbKategorija.SelectedIndex == -1)
            //{
            //    errorProvider1.SetError(cmbKategorija, "Molimo ubacite kategoriju ili vise njih u koje potpada markica.");
            //    validnost = false;
            //}
            //else
            //{
            //    errorProvider1.SetError(cmbKategorija, "");
            //}
            #endregion

            if (string.IsNullOrEmpty(txtDizajner.Text))
            {
                dizajner = "Nepoznati dizajner.";
            }
            else
            {
                dizajner = txtDizajner.Text;
            }
            return validnost;
        }

        float vrednost = -1;
        bool validnostVred;
        private void txtVrednost_Leave(object sender, EventArgs e)
        {
            validnostVred = true;
            if (string.IsNullOrEmpty(txtVrednost.Text))
            {
                errorProvider1.SetError(txtVrednost, "Neophodno je znati vrednost same markice.");
                validnostVred = false;
            }
            else
            {
                errorProvider1.SetError(txtVrednost, "");
                if (float.TryParse(txtVrednost.Text, out vrednost))
                {
                    if (vrednost >= 0 && vrednost <= 15000000)
                    {
                        errorProvider1.SetError(txtVrednost, "");

                    }
                    else
                    {
                        errorProvider1.SetError(txtVrednost, "Vrednost mora biti pozitivna vrednost do realne maksimalne vrednosti koju je najvrednija markica dostigla (15000000 $)");
                        validnostVred = false;
                    }

                }
                else
                {
                    errorProvider1.SetError(txtVrednost, "Molimo unesite cifre sa tacnom vrednoscu markice");
                    validnostVred = false;
                }
            }
        }

        int godina = 0;
        bool validnostGod;
        private void txtGodina_Leave(object sender, EventArgs e)
        {
            validnostGod = true;
            if (string.IsNullOrEmpty(txtGodina.Text))
            {
                errorProvider1.SetError(txtGodina, "Neophodno je uneti godinu izdanja markice.");
                validnostGod = false;
            }
            else
            {
                errorProvider1.SetError(txtGodina, "");
                if (Int32.TryParse(txtGodina.Text, out godina))
                {
                    if (godina >= 1840 && godina <= DateTime.Now.Year)
                    {
                        errorProvider1.SetError(txtGodina, "");
                    }
                    else
                    {
                        errorProvider1.SetError(txtGodina, $"Godina mora biti u ovirima od 1840. do trenutne ({DateTime.Now.Year}te) godine");
                        validnostGod = false;
                    }
                }
                else
                {
                    errorProvider1.SetError(txtGodina, "Molimo unesite cifre sa tacnom godinom nastanka markice");
                    validnostGod = false;
                }
            }
        }

        bool validnostKat;
        private void listaKategorija_Leave(object sender, EventArgs e)
        {
            validnostKat = true;
            if (listaKategorija.Items.Count == 0)
            {
                errorProvider1.SetError(listaKategorija, $"Markica mora imati jednu ili vise kategorija.");
                validnostKat = false;
            }
        }

        Kategorija odabranaKategorija;
        private void cmbKategorija_SelectedValueChanged(object sender, EventArgs e)
        {
            odabranaKategorija = null;
            if (cmbKategorija.SelectedItem != null)
            {
                odabranaKategorija = (Kategorija)cmbKategorija.SelectedItem;
                btnDodajKategoriju.Enabled = true;
            }
        }
        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            if (!kategorije.Contains(odabranaKategorija))
            {
                kategorije.Add(odabranaKategorija);
            }
            listaKategorija.DataSource = null;
            listaKategorija.DataSource = kategorije;
            listaKategorija.DisplayMember = "Naziv";
            btnUkloniKategoriju.Enabled = true;
        }
        private void btnUkloniKategoriju_Click(object sender, EventArgs e)
        {
            odabranaKategorija = (Kategorija)listaKategorija.SelectedItem;
            if (odabranaKategorija != null)
            {
                kategorije.Remove(odabranaKategorija);
            }
            listaKategorija.DataSource = null;
            listaKategorija.DataSource = kategorije;
            listaKategorija.DisplayMember = "Naziv";
            if (kategorije.Count == 0) btnUkloniKategoriju.Enabled = false;

        }
        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            txtGodina_Leave(sender, e);
            txtVrednost_Leave(sender, e);
            listaKategorija_Leave(sender, e);
            if (Validacija() && validnostGod && validnostVred && validnostKat)
            {
                Markica markica = new Markica
                {
                    Naziv = naziv,
                    Opis = opis,
                    Dizajner = dizajner,
                    Drzava = drzava,
                    Godina = godina,
                    Vrednost = vrednost,
                    Slika = "slika.jpg",
                    Kategorije = kategorije

                };
                if (KontrolerKomunikacije.Instance.KreirajMarkicu(markica))
                {
                    KontrolerKomunikacije.Instance.JaviZaIzmenu(markica);
                    MessageBox.Show("Markica je uspesno kreirana!");
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Neuspesno kreiranje markice, takva vec postoji u bazi");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Neuspesno kreiranje markice");
            }

        }
      

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            txtGodina_Leave(sender, e);
            txtVrednost_Leave(sender, e);
            listaKategorija_Leave(sender, e);
            if (Validacija() && validnostGod && validnostVred && validnostKat)
            {

                markicaIzmena.Naziv = naziv;
                markicaIzmena.Opis = opis;
                markicaIzmena.Dizajner = dizajner;
                markicaIzmena.Drzava = drzava;
                markicaIzmena.Godina = godina;
                markicaIzmena.Vrednost = vrednost;
                markicaIzmena.Slika = "slika.jpg";
                markicaIzmena.Kategorije = kategorije;

                if (KontrolerKomunikacije.Instance.IzmeniMarkicu(markicaIzmena))
                {
                    KontrolerKomunikacije.Instance.JaviZaIzmenu(markicaIzmena);
                    MessageBox.Show("Markica je uspesno izmenjena!");
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Neuspesna izmena markice");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Neuspesna izmena markice");
                return;
            }
        }
    }
}



