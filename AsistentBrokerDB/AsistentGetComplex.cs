using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistentBrokerDB
{
    public class AsistentGetComplex : Asistent
    {
        private ADomen uslov;

        public AsistentGetComplex(ADomen uslov)
        {
            this.uslov = uslov;
        }
        public override string VratiCommandText(ADomen paket)
        {
            return $"select * from {paket.VratiJoin()} where {uslov.UslovZaZajednicke()}";

        }
    }
}
