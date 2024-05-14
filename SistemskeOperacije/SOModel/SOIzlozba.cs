using Repozitorijum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOModel
{
    public abstract class SOIzlozba : ASO <IzlozbaRepozitorijum>
    {
        protected override void postaviRepozitorijum()
        {
            this.repozitorijum = new IzlozbaRepozitorijum();
        }
    }
}
