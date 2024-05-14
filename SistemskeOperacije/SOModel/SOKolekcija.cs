using Repozitorijum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOModel
{
    public abstract class SOKolekcija : ASO<KolekcijaRepozitorijum>
    {
        protected override void postaviRepozitorijum()
        {
            this.repozitorijum = new KolekcijaRepozitorijum();
        }
    }
}
