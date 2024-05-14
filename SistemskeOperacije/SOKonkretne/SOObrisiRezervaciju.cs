using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOObrisiRezervaciju : SORezervacija
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            repozitorijum.Obrisi(objekat);
            return null;
        }
    }
}
