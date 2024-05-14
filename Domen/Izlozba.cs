using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Izlozba : ADomen
    {
        public int IzlozbaID { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public string MestoOdrzavanja { get; set; }
        public string  DodatniDetalji { get; set; }
        public List<Rezervacija> Rezervacije { get; set; }

        public override string NazivTabele()
        {
            return "Izlozba";
        }

        public override void ProcitajReader(SqlDataReader reader, out ADomen objekat)
        {
            Izlozba nova = new Izlozba
            {
                IzlozbaID = (int)reader["IzlozbaID"],
                Naziv = (string)reader["Naziv"],
                DatumOdrzavanja = (DateTime)reader["DatumOdrzavanja"],
                MestoOdrzavanja = (string)reader["MestoOdrzavanja"],
                DodatniDetalji = (string)reader["DodatniDetalji"]
            };
            objekat = nova;
        }

        public override string UslovZaZajednicke()
        {
            return $"Izlozba.IzlozbaID = {IzlozbaID}";
        }

        public override string VratiJoin()
        {
            return "Izlozba";
        }

        public override string VratiSelect()
        {
            return "*";
        }

        public override string Vrednosti()
        {
            return $"'{Naziv}','{DatumOdrzavanja.ToString("yyyy-MM-dd")}', '{MestoOdrzavanja}', '{DodatniDetalji}'";
        }

        public override bool Equals(object obj)
        {
            if (obj is Izlozba izlozba && izlozba != null)
            {
                return izlozba.Naziv == Naziv &&
                       izlozba.DatumOdrzavanja == DatumOdrzavanja &&
                       izlozba.MestoOdrzavanja == MestoOdrzavanja;
            }
            return false;
        }
        public override string VrednostiZaIzmenu()
        {
            return $"'{Naziv}','{DatumOdrzavanja.ToString("yyyy-MM-dd")}', '{MestoOdrzavanja}', '{DodatniDetalji}'";
        }
        public override string UslovZaBrisanje()
        {
            return $"Izlozba.IzlozbaID = {IzlozbaID}";
        }

        public override string UslovZaPretragu()
        {
            return "Naziv like ";
        }
    }



}
