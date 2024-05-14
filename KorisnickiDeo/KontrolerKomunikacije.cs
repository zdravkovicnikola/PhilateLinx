using Common;
using Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiDeo
{
    public class KontrolerKomunikacije
    {
        public event EventHandler MarkicaIzmenjena;

        private Communication komunikacija = new Communication();

        public Korisnik prijavljeniKorisnik;
        public Institucija prijavljenaInstitucija;

        public static string identifikator;

        public List<Izlozba> izlozbe = new List<Izlozba>();
        public List<Markica> markice = new List<Markica>();
        public List<Kategorija> kategorije = new List<Kategorija>();
        public List<Rezervacija> rezervacije = new List<Rezervacija>();
        public List<Kolekcija> kolekcija = new List<Kolekcija>();
        
        #region singlton
        private static KontrolerKomunikacije instance;
        public static KontrolerKomunikacije Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KontrolerKomunikacije();
                }

                return instance;
            }
        }
        private KontrolerKomunikacije()
        {
        }
        #endregion


        public void Connect()
        {
            komunikacija.Connect();
        }
        public void Login(Korisnik user)
        {
            try
            {
                if ((user = (Korisnik)komunikacija.Login(user)) != null)
                {
                    prijavljeniKorisnik = user;
                }
                else
                {
                    prijavljeniKorisnik = null;
                }
            }

            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        } //odradjeno
        public Institucija LoginAdmin(Institucija user)
        {
            try
            {
                if ((user = komunikacija.LoginAdmin(user)) != null)
                {
                    prijavljenaInstitucija = user;
                }
                else
                {
                    prijavljeniKorisnik = null;
                }
                return prijavljenaInstitucija;
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }

        } //odradjeno
        internal void Register(Korisnik user)
        {
            try
            {
                if ((user = komunikacija.Register(user)) != null)
                {
                    prijavljeniKorisnik = user;
                }
                else
                {
                    prijavljeniKorisnik = null;
                }
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        } //odradjeno
        internal void PrikaziFrmAdmin()
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
        }  //odradjeno
        internal void PrikaziFrmKorisnik()
        {
            FrmKorisnik frmKorisnik = new FrmKorisnik();
            frmKorisnik.Show();
        } //odradjeno
        internal void PrikaziFrmMarkica()
        {
            FrmMarkica frmMarkica = new FrmMarkica();
            frmMarkica.Show();
        }
        internal void PrikaziFrmLogin()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
        public bool KreirajIzlozbu(Izlozba izlozba)
        {
            try
            {
                if (komunikacija.KreirajIzlozbu(izlozba) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                };
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }

        }
        public List<Izlozba> GetIzlozbe()
        {
            try
            {
                if ((izlozbe = komunikacija.GetIzlozbe()) != null)
                {
                    return izlozbe;
                }
                else
                {
                    return new List<Izlozba>();
                }
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        public List<Markica> GetMarkice()
        {
            try
            {
                if ((markice = komunikacija.GetMakrice()) != null)
                {
                    return markice;
                }
                else
                {
                    return new List<Markica>();
                }
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        public List<Kategorija> GetKategorije()
        {
            try
            {
                if ((kategorije = komunikacija.GetKategorija()) != null)
                {
                    return kategorije;
                }
                else
                {
                    return new List<Kategorija>();
                }
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }

        }
        internal bool KreirajMarkicu(Markica markica)
        {
            try
            {
                if (komunikacija.KreirajMarkicu(markica) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                };
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        internal bool IzmeniMarkicu(Markica markica)
        {
            try
            {
                if (komunikacija.IzmeniMarkicu(markica) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                };
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        public bool KreirajRezervaciju(Izlozba izlozba)
        {
            Rezervacija rezervacija = new Rezervacija
            {
                KorisnickiID = prijavljeniKorisnik.KorisnickiID,
                Izlozba = izlozba
            };
            try
            {
                if (komunikacija.KreirajRezervaciju(rezervacija) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                };
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        public List<Rezervacija> GetRezervacije()
        {
            try
            {
                if ((rezervacije = komunikacija.GetRezervacije(prijavljeniKorisnik)) != null)
                {
                    return rezervacije;
                }
                else
                {
                    return new List<Rezervacija>();
                }
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        public bool ObrisiRezervaciju(Rezervacija trazena)
        {
            try
            {
                if (komunikacija.ObrisiRezervaciju(trazena) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                };
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        public List<Izlozba> GetIzlozbePlus()
        {
            try
            {
                if ((izlozbe = komunikacija.GetIzlozbePlus()) != null)
                {
                    return izlozbe;
                }
                else
                {
                    return new List<Izlozba>();
                }
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        internal void Odjavi()
        {
            komunikacija?.Close(prijavljeniKorisnik);
        }
        internal void OdjaviAdmina()
        {
            komunikacija?.Close(prijavljenaInstitucija);
        }
        internal void JaviZaIzmenu(Markica izmenjenaMarkica)
        {
            MarkicaIzmenjena?.Invoke(this, new MarkicaEventArgs(izmenjenaMarkica));
        }
        internal List<Markica> PretraziMarkice(string pretraga)
        {
            try
            {
                if ((markice = komunikacija.PretraziMarkice(pretraga)) != null)
                {
                    return markice;
                }
                else
                {
                    return new List<Markica>();
                }
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        internal List<Izlozba> PretraziIzlozbe(string pretraga)
        {
            try
            {
                if ((izlozbe = komunikacija.PretraziIzlozbe(pretraga)) != null)
                {
                    return izlozbe;
                }
                else
                {
                    return new List<Izlozba>();
                }
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        internal List<Kolekcija> GetKolekcija()
        {
            try
            {
                if ((kolekcija = komunikacija.GetKolekcija(prijavljeniKorisnik)) != null)
                {
                    return kolekcija;
                }
                else
                {
                    return new List<Kolekcija>();
                }
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        internal bool UbaciUKolekciju(Markica trazena)
        {
            Kolekcija kolekcija = new Kolekcija
            {
                Korisnik = prijavljeniKorisnik,
                Markica = trazena
            };
            try
            {
                if (komunikacija.UbaciUKolekciju(kolekcija) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                };
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }

        internal bool IzbaciIzKolekcije(Kolekcija markica)
        {
            try
            {
                if (komunikacija.IzbaciIzKolekcije(markica) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                };
            }
            catch (SocketException ex)
            {
                komunikacija = null;
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
    }
}
