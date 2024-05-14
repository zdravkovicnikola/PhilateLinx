using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistentBrokerDB
{
    public class AsistentDodaj: Asistent
    {
        public override string VratiCommandText(ADomen paket)
        {
            return $"insert into {paket.NazivTabele()} values ({paket.Vrednosti()})";
        }
    }
}
