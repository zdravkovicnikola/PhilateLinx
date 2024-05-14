using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOGetMarkica : SOMarkica
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            Markica markica = new Markica();
            List<Markica> markice = new List<Markica>();
            foreach (Markica m in repozitorijum.Get())
            {
                markica.MarkicaID = m.MarkicaID;
                List<MarkicaKategorija> mk = new List<MarkicaKategorija>();
                mk = repozitorijum.GetComplex(markica);
                m.Kategorije = new List<Kategorija>();
                foreach (MarkicaKategorija km in mk)
                {
                    m.Kategorije.Add(km.Kategorija);
                }
                markice.Add(m);
            }
            return markice.ConvertAll(x => (ADomen)x);
        }
    }
}
