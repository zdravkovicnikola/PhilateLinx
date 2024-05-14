using AsistentBrokerDB;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class MarkicaKategorijaRepozitorijum : ApsRepozitorijum
    {
        public override List<ADomen> Get()
        {
            asistentDB = new AsistentGet();
            return asistentDB.Get(new MarkicaKategorija());
        }

        public override List<ADomen> Pretrazi(object uslov)
        {
            if (uslov == null)
            {
                return new List<ADomen>();
            }

            asistentDB = new AsistentPretrazi(uslov);
            List<MarkicaKategorija> makriceIKategorije = asistentDB.Get(new MarkicaKategorija()).ConvertAll(x => (MarkicaKategorija)x);


            List < Kategorija > kategorije = makriceIKategorije
            .Select(mk => mk.Kategorija)
            .ToList();



            return kategorije.ConvertAll(x => (ADomen)x);
        }
    }
}
