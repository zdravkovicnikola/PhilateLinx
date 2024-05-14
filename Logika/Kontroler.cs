using Domen;
using Repozitorijum;
using SistemskeOperacije;
using SistemskeOperacije.SOKonkretne;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Logika
{
    public class Kontroler
    {
        #region Singlton
        private static Kontroler instance;
        public static Kontroler Instance
        {
            get { if (instance == null) instance = new Kontroler(); return instance; }
        }
        private Kontroler()
        {
        }
        #endregion
        private ASO<ApsRepozitorijum> izvrsiteljSO;
        public Korisnik PrijaviKorisnika(Korisnik korisnik)
        {
            ASO<KorisnikRepozitorijum> izvrsiteljSO = new SOPrijaviKorisnika();
            return (Korisnik)izvrsiteljSO.Izvrsi(korisnik).SingleOrDefault();

        } // odradjeno
        public Institucija PrijaviInstituciju(Institucija institut)
        {
            ASO<InstitucijaRepozitorijum> izvrsiteljSO = new SOPrijaviInstituciju();
            return (Institucija)izvrsiteljSO.Izvrsi(institut).SingleOrDefault();
        } // odradjeno
        public Korisnik RegistrujKorisnika(Korisnik korisnik)
        {
            ASO<KorisnikRepozitorijum> izvrsiteljSO = new SOKreirajKorisnika();
            return (Korisnik)izvrsiteljSO.Izvrsi(korisnik).SingleOrDefault();
        }  // odradjeno
        public Izlozba KreirajIzlozbu(Izlozba izlozba)
        {
            ASO<IzlozbaRepozitorijum> izvrsiteljSO = new SOKreirajIzlozbu();
            return (Izlozba)izvrsiteljSO.Izvrsi(izlozba).SingleOrDefault();
        } //odradjeno
        public List<Izlozba> GetIzlozba()
        {
            ASO<IzlozbaRepozitorijum> izvrsiteljSO = new SOGetIzlozba();
            List<Izlozba> izlozbe = izvrsiteljSO.Izvrsi().ConvertAll(x => (Izlozba)x);
            return izlozbe;
        } //odradjeno
        public Rezervacija KreirajRezervaciju(Rezervacija rezervacija)
        {
            ASO<RezervacijaRepozitorijum> izvrsiteljSO = new SOKreirajRezervaciju();
            return (Rezervacija)izvrsiteljSO.Izvrsi(rezervacija).SingleOrDefault();

        } //odradjeno
        public List<Kategorija> GetKategorija()
        {
            ASO<KategorijaRepozitorijum> izvrsiteljSO = new SOGetKategorije();
            List<Kategorija> kategorije = izvrsiteljSO.Izvrsi().ConvertAll(x => (Kategorija)x);
            return kategorije;
        } // odradjeno
        public List<Rezervacija> GetRezervacija(Korisnik korisnik)
        {
            ASO<RezervacijaRepozitorijum> izvrsiteljSO = new SOGetRezervacija(korisnik);
            List<Rezervacija> rezervacije = izvrsiteljSO.Izvrsi().ConvertAll(x => (Rezervacija)x);
            return rezervacije;
        } //odradjeno
        public object ObrisiRezervaciju(Rezervacija rezervacija)
        {
            ASO<RezervacijaRepozitorijum> izvrsiteljSO = new SOObrisiRezervaciju();
            izvrsiteljSO.Izvrsi(rezervacija);
            return rezervacija;
        } //odradjeno
        public void OdjaviKorisnika(Korisnik korisnik)
        {
            ASO<KorisnikRepozitorijum> izvrsiteljSO = new SOOdjaviKorisnika();
            izvrsiteljSO.Izvrsi(korisnik);
        } //odradjeno
        public void OdjaviInstituciju(Institucija institucija)
        {
            ASO<InstitucijaRepozitorijum> izvrsiteljSO = new SOOdjaviInstituciju();
            izvrsiteljSO.Izvrsi(institucija);
        } //odradjeno
        public void OdjaviSveKorisnike()
        {
            ASO<KorisnikRepozitorijum> izvrsiteljSO = new SOOdjaviSveKorisnike();
            izvrsiteljSO.Izvrsi(new Korisnik());
        } // mora se proveriti 
        public List<Markica> GetMarkica()
        {
            ASO<MarkicaRepozitorijum> izvrsiteljSO = new SOGetMarkica();
            List<Markica> markice = izvrsiteljSO.Izvrsi().ConvertAll(x => (Markica)x);
            return markice;
        } //odradjeno
        public Markica KreirajMarkicu(Markica markica)
        {
            ASO<MarkicaRepozitorijum> izvrsiteljSO = new SOKreirajMarkicu();
            return (Markica)izvrsiteljSO.Izvrsi(markica).SingleOrDefault();
        } //odradjeno
        public Markica IzmeniMarkicu(Markica markica)
        {
            ASO<MarkicaRepozitorijum> izvrsiteljSO = new SOIzmeniMarkicu();
            izvrsiteljSO.Izvrsi(markica);

            return markica;
        } //odradjeno
        public List<Izlozba> GetIzlozbaPlus()
        {
            ASO<IzlozbaRepozitorijum> izvrsiteljSO = new SOGetListaIzlozbaPlus();
            List<Izlozba> izlozbe = izvrsiteljSO.Izvrsi().ConvertAll(x => (Izlozba)x);
            return izlozbe;


        } //odradjeno
        public List<Markica> NadjiMarkice(string uslov)
        {
            ASO<MarkicaRepozitorijum> izvrsiteljSO = new SOPretraziMarkice(uslov);
            List<Markica> markice = izvrsiteljSO.Izvrsi().ConvertAll(x => (Markica)x);
            return markice;
        }
        public List<Izlozba> NadjiIzlozbe(string uslov)
        {
            ASO<IzlozbaRepozitorijum> izvrsiteljSO = new SOPretraziIzlozbe(uslov);
            List<Izlozba> izlozbe = izvrsiteljSO.Izvrsi().ConvertAll(x => (Izlozba)x);
            return izlozbe;
        }
        public List<Kolekcija> GetKolekcija(Korisnik korisnik)
        {
            ASO<KolekcijaRepozitorijum> izvrsiteljSO = new SOUcitajKolekciju(korisnik);
            List<Kolekcija> markice = izvrsiteljSO.Izvrsi().ConvertAll(x => (Kolekcija)x);
            return markice;
        }
        public Kolekcija UbaciUKolekciju(Kolekcija markica)
        {
            ASO<KolekcijaRepozitorijum> izvrsiteljSO = new SOUbaciUKolekciju();
            return (Kolekcija)izvrsiteljSO.Izvrsi(markica).SingleOrDefault();
        }
        public Kolekcija IzbaciIzKolekcije(Kolekcija markica)
        {
            ASO<KolekcijaRepozitorijum> izvrsiteljSO = new SOObrisiMarkicuIzKolekcije();
            izvrsiteljSO.Izvrsi(markica);
            return markica; 
        }
    }
}
