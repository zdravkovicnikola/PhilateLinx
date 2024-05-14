using AsistentBrokerDB;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class InstitucijaRepozitorijum : ApsRepozitorijum
    {
       
        public override List<ADomen> Get()
        {
            asistentDB = new AsistentGet();
            return asistentDB.Get(new Institucija());
        }

        public List<Rezervacija> GetComplex(Izlozba izlozba)
        {
            throw new NotImplementedException();
        }

        public override List<ADomen> Pretrazi(object uslov)
        {
            throw new NotImplementedException();
        }

    }
}
