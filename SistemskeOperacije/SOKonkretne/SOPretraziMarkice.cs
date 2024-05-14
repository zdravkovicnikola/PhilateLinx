using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOPretraziMarkice : SOMarkica
    {
        private string Naziv;

        public SOPretraziMarkice(string Naziv)
        {
            this.Naziv = Naziv;
        }
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            if (Naziv == null) { return null; }
            var markice = repozitorijum.Pretrazi(Naziv);
            foreach (Markica m in markice)
            {
                List<MarkicaKategorija> mk = new List<MarkicaKategorija>();
                mk = repozitorijum.GetComplex(m);
                m.Kategorije = new List<Kategorija>();
                foreach (MarkicaKategorija km in mk)
                {
                    m.Kategorije.Add(km.Kategorija);
                }
            }
            return markice.ConvertAll(x => (ADomen)x);
        }
    }
}
