using AsistentBrokerDB;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class KolekcijaRepozitorijum : ApsRepozitorijum
    {
        public override List<ADomen> Get()
        {
            asistentDB = new AsistentGet();
            return asistentDB.Get(new Kolekcija());
        }

        public List<Kolekcija> GetComplex(ADomen korisnik)
        {
            asistentDB = new AsistentGetComplex(korisnik);

            return asistentDB.Get(new Kolekcija()).ConvertAll(x => (Kolekcija)x);
        }

        public override List<ADomen> Pretrazi(object uslov)
        {
            throw new NotImplementedException();
        }
    }
}
