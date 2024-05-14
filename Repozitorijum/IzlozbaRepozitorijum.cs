using AsistentBrokerDB;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class IzlozbaRepozitorijum : ApsRepozitorijum
    {
        public override List<ADomen> Get()
        {
            asistentDB = new AsistentGet();
            return asistentDB.Get(new Izlozba());
        }

        public List<Rezervacija> GetComplex(Izlozba izlozba)
        {
            asistentDB = new AsistentGetComplex(izlozba);
            return asistentDB.Get(new Rezervacija()).ConvertAll(x => (Rezervacija)x);

        }

        public override List<ADomen> Pretrazi(object uslov)
        {
            if (uslov == null)
            {
                return new List<ADomen>();
            }

            asistentDB = new AsistentPretrazi(uslov);
            List<Izlozba> rezervacije = asistentDB.Get(new Izlozba()).ConvertAll(x => (Izlozba)x);


            return rezervacije.ConvertAll(x => (ADomen)x); ;
        }
    }
}
