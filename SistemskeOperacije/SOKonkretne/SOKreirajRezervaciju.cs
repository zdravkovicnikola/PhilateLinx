using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOKreirajRezervaciju : SORezervacija
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            Rezervacija rezervacija = (Rezervacija)objekat;
            List<ADomen> list = new List<ADomen>();
            Korisnik korisnik = new Korisnik()
            { KorisnickiID = rezervacija.KorisnickiID };
            if (repozitorijum.GetComplex(korisnik).Count != 0)
            {
                foreach (Rezervacija r in repozitorijum.GetComplex(korisnik))
                {
                    if (r.Equals(rezervacija))
                    {
                        return null;
                    }
                }

            }
            repozitorijum.Dodaj((Rezervacija)objekat);
            list.Add(rezervacija);
            return list;
        }
    }
}
