using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOPrijaviInstituciju : SOInstitucija
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            List<ADomen> list = new List<ADomen>();
            Institucija institut = (Institucija)objekat;
            foreach (Institucija i in repozitorijum.Get())
            {
                if (Validacija(institut) == -1 && i.Imejl == institut.Imejl && i.Lozinka == institut.Lozinka)
                {
                    institut = i;
                    prijavleneInstitucije.Add(i);
                    list.Add(i);
                    return list;
                }
            }
            return null;
        }
    }
}
