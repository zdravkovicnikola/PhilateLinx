using Domen;
using Repozitorijum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOModel
{
    public abstract class SOKategorija : ASO <KategorijaRepozitorijum>
    {
        protected override void postaviRepozitorijum()
        {
            this.repozitorijum = new KategorijaRepozitorijum();
        }
    }
}
