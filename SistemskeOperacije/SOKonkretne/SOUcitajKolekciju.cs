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
    public class SOUcitajKolekciju : SOKolekcija
    {
        private ADomen korisnik;
        public SOUcitajKolekciju(ADomen korisnik)
        {
            this.korisnik = korisnik;
        }
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
           

            Markica markica = new Markica();
            List<Kolekcija> markice = new List<Kolekcija>();
            MarkicaRepozitorijum  markicaRepozitorijum = new MarkicaRepozitorijum();
            foreach (Kolekcija m in repozitorijum.GetComplex(korisnik))
            {
                markica.MarkicaID = m.Markica.MarkicaID;
                List<MarkicaKategorija> mk = new List<MarkicaKategorija>();
                mk = markicaRepozitorijum.GetComplex(markica);
                m.Markica.Kategorije = new List<Kategorija>();
                foreach (MarkicaKategorija km in mk)
                {
                    m.Markica.Kategorije.Add(km.Kategorija);
                }
                markice.Add(m);
            }
            return markice.ConvertAll(x => (ADomen)x);






        }
    }
}
