using Domen;
using Repozitorijum;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOKreirajKorisnika : SOKorisnik
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            List<ADomen> list = new List<ADomen>();
            Korisnik korisnik = (Korisnik)objekat;
            foreach (Korisnik k in repozitorijum.Get())
            {
                if (k.Imejl == korisnik.Imejl)
                {
                    return null;
                }
            }
            KorisnickiEntitetKlasa entitetKlasa = new KorisnickiEntitetKlasa
            {
                Imejl = korisnik.Imejl,
                Lozinka = korisnik.Lozinka
            };
            repozitorijum.Dodaj(entitetKlasa);
            korisnik.KorisnickiID = repozitorijum.GetID().OfType<KorisnickiEntitetKlasa>().Max(m => m.KorisnickiID);
            repozitorijum.Dodaj(korisnik);
            prijavljeniKorisnici.Add(korisnik);
            list.Add(korisnik);
            return list;
        }
    }
}
