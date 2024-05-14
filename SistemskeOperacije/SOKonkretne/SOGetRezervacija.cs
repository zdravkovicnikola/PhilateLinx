using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOGetRezervacija : SORezervacija
    {
        private ADomen korisnik;
        public SOGetRezervacija(ADomen korisnik)
        {
            this.korisnik = korisnik;
        }
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            return repozitorijum.GetComplex(korisnik).ConvertAll(x=>(ADomen)x);
        }
    }
}
