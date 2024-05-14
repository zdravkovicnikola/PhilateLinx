using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KorisnickiDeo.UCLogin
{
    public partial class UCRegister : UserControl
    {
        private FrmLogin frmLogin;

        public UCRegister()
        {
            InitializeComponent();
        }

        public UCRegister(FrmLogin frmLogin)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string username = txtUsername.Text;
            string imePrezime = txtNameSurname.Text.Trim();

            bool flag = true;

            #region Validacija
            if (string.IsNullOrEmpty(imePrezime))
            {
                MessageBox.Show("Unesite ime i prezime.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameSurname.BackColor = Color.Salmon;
                flag = false;
            }
            
            string[] delovi = imePrezime.Split(' ');

            if (delovi.Length != 2)
            {
                MessageBox.Show("Molimo da polje za unos imena i prezimena popunite u formatu Ime Prezime.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }
            else
            {
                txtNameSurname.BackColor = Color.FromArgb(255, 255, 192);
            }
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Unesite korisnicko ime.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.BackColor = Color.Salmon;
                flag = false;
            }
            else
            {
                txtUsername.BackColor = Color.FromArgb(255, 255, 192);
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Unesite email.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.BackColor = Color.Salmon;
                flag = false;
            }
            else
            {
                txtEmail.BackColor = Color.FromArgb(255, 255, 192);
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Unesite sifru.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.BackColor = Color.Salmon;
                flag = false;
            }
            else
            {
                txtPassword.BackColor = Color.FromArgb(255, 255, 192);
            }
            if (flag == false) { MessageBox.Show("Podaci nisu validni za registraciju.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;}
            #endregion

            Korisnik user = new Korisnik()
            {
                Imejl = email,
                Lozinka = password,
                ImePrezime = imePrezime,
                KorisnickoIme = username
            };

            KontrolerKomunikacije.Instance.Connect();
            MessageBox.Show("Podaci su validni za registraciju!");
            KontrolerKomunikacije.Instance.Register(user);

            if (KontrolerKomunikacije.Instance.prijavljeniKorisnik != null)
            {
                MessageBox.Show("Registracija uspesno izvrsena!");
                MessageBox.Show($"Dobrodosli {KontrolerKomunikacije.Instance.prijavljeniKorisnik.ImePrezime}!");
                this.Visible = false;
                KontrolerKomunikacije.Instance.PrikaziFrmKorisnik();
                frmLogin.Visible = false;
            }
            else
            {
                MessageBox.Show("Korisnik sa pomenutim podacima vec postoji, molimo ulogujte se.");
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
