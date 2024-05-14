using System;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Institucija : KorisnickiEntitetKlasa
    {
        public int KorisnickiID { get; set; }
        public string Naziv { get; set; }
        public string Kontakt { get; set; }

        public override string NazivTabele()
        {
            return "Institucija";
        }

        public override void ProcitajReader(SqlDataReader reader, out ADomen objekat)
        {
            Institucija nova = new Institucija {

                KorisnickiID = (int)reader["KorisnickiID"],
                Kontakt = (string)reader["Kontakt"],
                Naziv = (string)reader["Naziv"],
                Imejl = (string)reader["Imejl"],
                Lozinka = (string)reader["Lozinka"]
            };
            objekat = nova;
        }

        public override string UslovZaZajednicke()
        {
            return $"Institucija.KorisnickiId = {KorisnickiID}";
        }

        public override string VratiJoin()
        {
            return "Institucija i join KorisnickiEntitet ke on (i.KorisnickiID  = ke.KorisnickiID)";
        }

        public override string VratiSelect()
        {
            return "*";
        }

        public override string Vrednosti()
        {
            return $"{Naziv}, {Kontakt}";
        }

        public override string VrednostiZaIzmenu()
        {
            return $"{Naziv}, {Kontakt}";
        }
    }



}
