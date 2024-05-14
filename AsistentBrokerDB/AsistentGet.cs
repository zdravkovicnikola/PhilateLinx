using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistentBrokerDB
{
    public class AsistentGet:Asistent
    {
        public override string VratiCommandText(ADomen paket)
        {
            return $"select * from {paket.VratiJoin()}";
        }
    }
}
