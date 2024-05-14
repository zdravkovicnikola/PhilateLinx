using AsistentBrokerDB;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class MarkicaRepozitorijum : ApsRepozitorijum
    {
        public override List<ADomen> Get()
        {
            asistentDB = new AsistentGet();
            return asistentDB.Get(new Markica());
        }

        public List<MarkicaKategorija> GetComplex(Markica markica)
        {
            asistentDB = new AsistentGetComplex(markica);
            return asistentDB.Get(new MarkicaKategorija()).ConvertAll(x => (MarkicaKategorija)x);

        }

        public override List<ADomen> Pretrazi(object uslov)
        {
            asistentDB = new AsistentPretrazi(uslov);
            List<Markica> makrice = asistentDB.Get(new Markica()).ConvertAll(x => (Markica)x);
            return makrice.ConvertAll(x => (ADomen)x);
        }
    }
}
