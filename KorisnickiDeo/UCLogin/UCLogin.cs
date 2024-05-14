using Common;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace KorisnickiDeo.UCLogin
{
    public partial class UCLogin : UserControl
    {
        private FrmLogin frmLogin;

        public UCLogin()
        {
            InitializeComponent();
            this.Text = "Login";
            cmbKoJe.DataSource = Enum.GetValues(typeof(TipKorisnika));
        }

        public UCLogin(FrmLogin frmLogin)
        {
            InitializeComponent();
            this.Text = "Login";
            cmbKoJe.DataSource = Enum.GetValues(typeof(TipKorisnika));
            this.frmLogin = frmLogin;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(email))
            {
                txtEmail.BackColor = Color.Salmon;
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                txtPassword.BackColor = Color.Salmon;
                return;
            }

            try
            {
                if (cmbKoJe.SelectedIndex == 0)
                {
                    Korisnik user = new Korisnik()
                    {
                        Imejl = email,
                        Lozinka = password
                    };

                    KontrolerKomunikacije.Instance.Connect();
                    KontrolerKomunikacije.Instance.Login(user);
                    if (KontrolerKomunikacije.Instance.prijavljeniKorisnik != null)
                    {
                        MessageBox.Show("Uspesno prijavljivanje!");
                        MessageBox.Show($"Dobrodosli {KontrolerKomunikacije.Instance.prijavljeniKorisnik.ImePrezime}!");
                        this.Visible = false;
                        KontrolerKomunikacije.Instance.PrikaziFrmKorisnik();
                        frmLogin.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Neuspesno prijavljivanje, korisnik ne postoji!");
                        txtEmail.Text = "";
                        txtPassword.Text = "";
                    }
                }
                else
                {
                    Institucija user = new Institucija()
                    {
                        Imejl = email,
                        Lozinka = password
                    };

                    KontrolerKomunikacije.Instance.Connect();
                    user = KontrolerKomunikacije.Instance.LoginAdmin(user);

                    if (user != null)
                    {
                        MessageBox.Show("Uspesno prijavljivanje!");
                        MessageBox.Show($"Dobrodosli {user.Naziv}!");
                        this.Visible = false;
                        KontrolerKomunikacije.Instance.PrikaziFrmAdmin();
                        frmLogin.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Neuspesno prijavljivanje, institucija ne postoji!");
                        txtEmail.Text = "";
                        txtPassword.Text = "";
                    }
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greska pri radu sa serverom!" + ex.Message);
            }
        }
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
