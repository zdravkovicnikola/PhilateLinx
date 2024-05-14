using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOIzmeniMarkicu : SOMarkica
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            Markica markica = (Markica)objekat;
            repozitorijum.Izmeni(markica);

            MarkicaKategorija mk = new MarkicaKategorija
            {
                MarkicaID = markica.MarkicaID
            };
            repozitorijum.Obrisi(mk);

            foreach (Kategorija k in markica.Kategorije)
            {
                mk.MarkicaID = markica.MarkicaID;
                mk.Kategorija = k;
                repozitorijum.Dodaj(mk);
            }

            return null;
        }
    }
}
