using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOGetKategorije : SOKategorija
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            return repozitorijum.Get();
        }
    }
}
