using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class MarkicaKategorija : ADomen
    {
        public int MarkicaID { get; set; }
        public Kategorija Kategorija { get; set; }

        public override string NazivTabele()
        {
            return "MarkicaKategorija";
        }

        public override void ProcitajReader(SqlDataReader reader, out ADomen objekat)
        {
            MarkicaKategorija nova = new MarkicaKategorija
            {
                MarkicaID = (int)reader["MarkicaID"]
                ,
                Kategorija = new Kategorija
                {
                    KategorijaID = (int)reader["KategorijaID"],
                    Naziv = (string)reader["Naziv"],
                    Opis = (string)reader["Opis"]
                }
            };
            objekat = nova;
        }

        public override string UslovZaBrisanje()
        {
            return $"MarkicaID = {MarkicaID}";
        }

        public override string UslovZaPretragu()
        {
            return $"MarkicaID like ";
        }

        public override string UslovZaZajednicke()
        {
            return $"MarkicaID = ";
        }

        public override string VratiJoin()
        {
            return "MarkicaKategorija join Kategorija on (MarkicaKategorija.KategorijaID = Kategorija.KategorijaID)";
        }

        public override string VratiSelect()
        {
            return "*";
        }

        public override string Vrednosti()
        {
            return $"{MarkicaID}, {Kategorija.KategorijaID}";
        }

        public override string VrednostiZaIzmenu()
        {
            return $"{MarkicaID}, {Kategorija.KategorijaID}";
        }
    }
}
