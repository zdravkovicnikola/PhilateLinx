using System;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Kategorija : ADomen
    {
        public int KategorijaID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public Kategorija Self { get { return this; } }
        public override string NazivTabele()
        {
            return "Kategorija";
        }

        public override void ProcitajReader(SqlDataReader reader, out ADomen objekat)
        {
            Kategorija nova = new Kategorija
            {
                KategorijaID = (int)reader["KategorijaID"],
                Naziv = (string)reader["Naziv"],
                Opis = (string)reader["Opis"]
            };
            objekat = nova;
        }

        public override string UslovZaZajednicke()
        {
            return $"Kategorija.KategorijaID = {KategorijaID}";
        }

        public override string VratiJoin()
        {
            return "Kategorija";
        }

        public override string VratiSelect()
        {
            return "*";
        }
        public override bool Equals(object obj)
        {
            return obj is Kategorija kat && kat.KategorijaID == KategorijaID;
        }
        public override string Vrednosti()
        {
            return $"{Naziv},{Opis}";
        }

        public override string VrednostiZaIzmenu()
        {
            return $"'{Naziv}',''{Opis}'";
        }
        public override string UslovZaBrisanje()
        {
            return $"Kategorija.KategorijaID = {KategorijaID}";
        }

        public override string UslovZaPretragu()
        {
            return "Kategorija.Naziv like";
        }
    }



}
