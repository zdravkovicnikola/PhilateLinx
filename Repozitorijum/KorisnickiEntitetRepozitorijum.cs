using AsistentBrokerDB;
using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class KorisnickiEntitetRepozitorijum : ApsRepozitorijum
    {
        public override List<ADomen> Get()
        {
            asistentDB = new AsistentGet();
            return asistentDB.Get(new KorisnickiEntitetKlasa());
        }
        public override List<ADomen> Pretrazi(object uslov)
        {
            throw new NotImplementedException();
        }
    }
}
