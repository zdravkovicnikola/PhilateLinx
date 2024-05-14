using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOPretraziIzlozbe : SOIzlozba
    {
        private string Naziv;

        public SOPretraziIzlozbe(string Naziv)
        {
            this.Naziv = Naziv;
        }
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            if (Naziv == null) { return null; }
            var izlozbe = repozitorijum.Pretrazi(Naziv);
            foreach (Izlozba i in izlozbe)
            {
                i.Rezervacije = repozitorijum.GetComplex(i);
                
            }
            return izlozbe.ConvertAll(x => (ADomen)x);
        }
    }
}
