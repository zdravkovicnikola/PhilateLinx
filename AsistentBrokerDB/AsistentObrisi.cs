using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistentBrokerDB
{
    public class AsistentObrisi : Asistent
    {
        public override string VratiCommandText(ADomen paket)
        {
            return $"delete from {paket.NazivTabele()} where {(paket.UslovZaBrisanje())}";
        }
        
    }
}
