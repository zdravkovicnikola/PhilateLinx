using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOOdjaviInstituciju : SOInstitucija
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            int index = Validacija((Institucija)objekat);
            prijavleneInstitucije.Remove(prijavleneInstitucije[index]);
            return null;
        }
    }
}
