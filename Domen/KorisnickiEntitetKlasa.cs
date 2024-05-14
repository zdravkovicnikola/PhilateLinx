using System;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class KorisnickiEntitetKlasa : ADomen
    {
        public int KorisnickiID { get; set; }
        public string Imejl { get; set; }
        public string Lozinka { get; set; }


        public override string NazivTabele()
        {
            return "KorisnickiEntitet";
        }

        public override void ProcitajReader(SqlDataReader reader, out ADomen objekat)
        {
            KorisnickiEntitetKlasa nova = new KorisnickiEntitetKlasa
            {
                KorisnickiID = (int)reader["KorisnickiID"],
                Imejl = (string)reader["Imejl"],
                Lozinka = (string)reader["Lozinka"]
            };
            objekat = nova;
        }

        public override string UslovZaBrisanje()
        {
            return $"KorisnickiID = {KorisnickiID}";
        }

        public override string UslovZaPretragu()
        {
            return "Imejl like ";
        }

        public override string UslovZaZajednicke()
        {
            return $"KorisnickiID = {KorisnickiID}";
        }

        public override string VratiJoin()
        {
            return "KorisnickiEntitet";
        }

        public override string VratiSelect()
        {
            return "*";
        }

        public override string Vrednosti()
        {
            return $"'{Imejl}', '{Lozinka}'";
        }

        public override string VrednostiZaIzmenu()
        {
            return $"'{Imejl}', '{Lozinka}'";
        }
    }



}
