using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOPrijaviKorisnika : SOKorisnik
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            List<ADomen> list = new List<ADomen>();
            Korisnik korisnik = (Korisnik)objekat;
            foreach (Korisnik k in repozitorijum.Get())
            {
                if (Validacija(korisnik) == -1 && k.Imejl == korisnik.Imejl && k.Lozinka == korisnik.Lozinka)
                {
                    korisnik = k;
                    prijavljeniKorisnici.Add(k);
                    list.Add(k);
                    return list;
                }
            }
            return null;
        }
    }
}
