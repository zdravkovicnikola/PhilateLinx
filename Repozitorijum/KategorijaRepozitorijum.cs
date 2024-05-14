using AsistentBrokerDB;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class KategorijaRepozitorijum : ApsRepozitorijum
    {
        public override List<ADomen> Get()
        {
            asistentDB = new AsistentGet();
            return asistentDB.Get(new Kategorija());
        }

        public override List<ADomen> Pretrazi(object uslov)
        {
            throw new NotImplementedException();
        }
    }
}
