using System;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Rezervacija : ADomen
    {
        public int RezervacijaID { get; set; }
        public int KorisnickiID { get; set; }
        public Izlozba Izlozba { get; set; }

        public override string NazivTabele()
        {
            return "Rezervacija";
        }

        public override void ProcitajReader(SqlDataReader reader, out ADomen objekat)
        {
            Rezervacija nova = new Rezervacija
            {
                RezervacijaID = (int)reader["RezervacijaID"],
                KorisnickiID = (int)reader["KorisnickiID"],
                Izlozba = new Izlozba
                {
                    IzlozbaID = (int)reader["IzlozbaID"],
                    Naziv = (string)reader["Naziv"],
                    DatumOdrzavanja = (DateTime)reader["DatumOdrzavanja"],
                    MestoOdrzavanja = (string)reader["MestoOdrzavanja"],
                    DodatniDetalji = (string)reader["DodatniDetalji"]
                }
            };
            objekat = nova;
        }

        public override string UslovZaZajednicke()
        {
            return $"KorisnickiID = ";
        }

        public override string VratiJoin()
        {
            return "Rezervacija r join Izlozba on (r.IzlozbaID = Izlozba.IzlozbaID) join Korisnik k on (k.KorisnickiID = r.KorisnickiID)";
        }

        public override string VratiSelect()
        {
            return $"*";
        }

        public override string Vrednosti()
        {
            return $"{KorisnickiID}, {Izlozba.IzlozbaID}";

        }
        public override string VrednostiZaIzmenu()
        {
            return $"{KorisnickiID}, {Izlozba.IzlozbaID}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Rezervacija other = (Rezervacija)obj;

            return KorisnickiID == other.KorisnickiID
                   && Izlozba.Equals(other.Izlozba);
        }

        public override int GetHashCode()
        {
            return RezervacijaID.GetHashCode() ^ KorisnickiID.GetHashCode() ^ Izlozba.GetHashCode();
        }

        public override string UslovZaBrisanje()
        {
            return $"RezervacijaID = {RezervacijaID}";
        }

        public override string UslovZaPretragu()
        {
            return $"KorisnickiID like ";
        }
    }



}
