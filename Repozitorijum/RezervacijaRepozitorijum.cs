using AsistentBrokerDB;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class RezervacijaRepozitorijum : ApsRepozitorijum
    {
        public override List<ADomen> Get()
        {
            throw new NotImplementedException();
        }

        public List<Rezervacija> GetComplex(ADomen izlozba)
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
            List<Rezervacija> rezervacije = asistentDB.Get(new Rezervacija()).ConvertAll(x => (Rezervacija)x);


            return rezervacije.ConvertAll(x => (ADomen)x);
        }
    }
}
