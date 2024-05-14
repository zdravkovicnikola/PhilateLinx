using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOKreirajMarkicu : SOMarkica
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            List<ADomen> list = new List<ADomen>();
            Markica markica = (Markica)objekat;
            foreach (Markica m in repozitorijum.Get())
            {
                if (markica.Naziv == m.Naziv &&
                markica.Godina == m.Godina &&
                markica.Dizajner == m.Dizajner &&
                markica.Drzava == m.Drzava)
                {
                    return null;
                }

            }
            list.Add(markica);
            repozitorijum.Dodaj(markica);
            int mId = repozitorijum.Get().OfType<Markica>().Max(m => m.MarkicaID);

            foreach (Kategorija k in markica.Kategorije)
            {
                MarkicaKategorija mk = new MarkicaKategorija
                {
                    Kategorija = k,
                    MarkicaID = mId
                };
                repozitorijum.Dodaj(mk);
            }
            return list;
        }
    }
}
