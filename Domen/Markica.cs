using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Markica : ADomen
    {
        public int MarkicaID { get; set; }
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public string Opis { get; set; }
        public string Slika { get; set; }
        public float Vrednost { get; set; }
        public string Drzava { get; set; }
        public string Dizajner { get; set; }
        public List<Kategorija> Kategorije { get; set; }

        public override string NazivTabele()
        {
            return "Markica";
        }

        public override void ProcitajReader(SqlDataReader reader, out ADomen objekat)
        {
            Markica nova = new Markica
            {
                MarkicaID = (int)reader["MarkicaID"],
                Naziv = (string)reader["Naziv"],
                Godina = (int)reader["Godina"],
                Opis = (string)reader["Opis"],
                Slika = (string)reader["Slika"],
                Vrednost = (float)reader["Vrednost"],
                Drzava = (string)reader["DrzavaIzdanja"],
                Dizajner = (string)reader["Dizajner"]
            };
            objekat = nova;
        }

        public override string UslovZaBrisanje()
        {
            return $"MarkicaID = {MarkicaID}";
        }

        public override string UslovZaPretragu()
        {
            return "Naziv like ";
        }

        public override string UslovZaZajednicke()
        {
            return $"MarkicaID = {MarkicaID}";
        }

        public override string VratiJoin()
        {
            return "Markica";
        }
        public override string VratiSelect()
        {
            return "*";
        }

        public override string Vrednosti()
        {
            return $"'{Naziv}', {Godina}, '{Opis}', '{Slika}', {Vrednost}, '{Drzava}', '{Dizajner}'";
        }

        public override string VrednostiZaIzmenu()
        {
            return $"Naziv = '{Naziv}', " +
           $"Godina = {Godina}, " +
           $"Opis = '{Opis}', " +
           $"Slika = '{Slika}', " +
           $"Vrednost = {Vrednost}, " +
           $"DrzavaIzdanja = '{Drzava}', " +
           $"Dizajner = '{Dizajner}'";
        }
    }



}
