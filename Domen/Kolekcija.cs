using System;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Kolekcija : ADomen
    {
        public int KolekcijaID { get; set; }
        public Markica Markica { get; set; }
        public Korisnik Korisnik { get; set; }

        public override string NazivTabele()
        {
            return "Kolekcija";
        }

        public override void ProcitajReader(SqlDataReader reader, out ADomen objekat)
        {
            Kolekcija nova = new Kolekcija
            {
                KolekcijaID = (int)reader["KolekcijaID"],
                Korisnik = new Korisnik
                {
                    KorisnickiID = (int)reader["KorisnickiID"],
                   
                },
                Markica = new Markica
                {
                    MarkicaID = (int)reader["MarkicaID"],
                    Naziv = (string)reader["Naziv"],
                    Godina = (int)reader["Godina"],
                    Opis = (string)reader["Opis"],
                    Vrednost = (float)reader["Vrednost"],
                    Drzava = (string)reader["DrzavaIzdanja"],
                    Dizajner = (string)reader["Dizajner"],
                }
            };
            objekat = nova;
        }

        public override string UslovZaBrisanje()
        {
            return $"KolekcijaID = {KolekcijaID}";
        }

        public override string UslovZaPretragu()
        {
            return $"Kolekcija.MarkicaID like";
        }

        public override string UslovZaZajednicke()
        {
            return $"k.KorisnickiID = {Korisnik.KorisnickiID}";
        }

        public override string VratiJoin()
        {
            return "Kolekcija k JOIN Markica m ON (m.MarkicaID = k.MarkicaID)";
        }

        public override string VratiSelect()
        {
            return "*";
        }

        public override string Vrednosti()
        {
            return $"{Markica.MarkicaID},{Korisnik.KorisnickiID}";
        }

        public override string VrednostiZaIzmenu()
        {
            return $"{Markica.MarkicaID},{Korisnik.KorisnickiID}";
        }
    }



}
