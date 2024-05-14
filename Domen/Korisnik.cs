using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Korisnik : KorisnickiEntitetKlasa
    {
        public int KorisnickiID { get; set; }
        public string ImePrezime { get; set; }
        public string KorisnickoIme { get; set; }
        public List<Markica> Kolekcija { get; set; }


        public override string NazivTabele()
        {
            return "Korisnik";
        }

        public override void ProcitajReader(SqlDataReader reader, out ADomen objekat)
        {
            Korisnik nova = new Korisnik
            {
                KorisnickiID = (int)reader["KorisnickiID"],
                ImePrezime = (string)reader["ImePrezime"],
                KorisnickoIme = (string)reader["KorisnickoIme"],
                Imejl = (string)reader["Imejl"],
                Lozinka = (string)reader["Lozinka"]
            };
            objekat = nova;
        }

        public override string UslovZaZajednicke()
        {
            return $"k.KorisnickiId = {KorisnickiID}";
        }

        public override string VratiJoin()
        {
            return $"KorisnickiEntitet ke join Korisnik k on (ke.KorisnickiID = k.KorisnickiID)";
        }

        public override string VratiSelect()
        {
            return "*";
        }

        public override string Vrednosti()
        {
            return $"'{KorisnickiID}', '{KorisnickoIme}', '{ImePrezime}'";
        }

        public override string VrednostiZaIzmenu()
        {

            return $"KorisnickoIme = '{KorisnickoIme}' , ImePrezime = '{ImePrezime}'";

        }
    }



}
