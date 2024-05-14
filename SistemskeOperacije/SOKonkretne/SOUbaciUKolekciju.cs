using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOUbaciUKolekciju : SOKolekcija
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            Kolekcija kolekcija = (Kolekcija)objekat;
            List<ADomen> list = new List<ADomen>();
            Korisnik korisnik = new Korisnik()
            { KorisnickiID = kolekcija.Korisnik.KorisnickiID };
            if (repozitorijum.GetComplex(korisnik).Count != 0)
            {
                foreach (Kolekcija k in repozitorijum.GetComplex(korisnik))
                {
                    if (k.Korisnik.KorisnickiID ==kolekcija.Korisnik.KorisnickiID && k.Markica.MarkicaID == kolekcija.Markica.MarkicaID)
                    {
                        return null;
                    }
                }

            }
            repozitorijum.Dodaj(kolekcija);
            list.Add(kolekcija);
            return list;
        }
    }
}
