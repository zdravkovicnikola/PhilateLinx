using Domen;
using Repozitorijum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class ASO <T> where T : ApsRepozitorijum
    {
        public T repozitorijum;

        public List<ADomen> Izvrsi(ADomen objekat = null)
        {
            postaviRepozitorijum();

            return IzvrsiKonretno(objekat);
        }

        protected abstract List<ADomen> IzvrsiKonretno(ADomen objekat);
        protected abstract void postaviRepozitorijum();
    }
}
