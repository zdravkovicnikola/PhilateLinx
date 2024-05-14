using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistentBrokerDB
{

    public class AsistentPretrazi : Asistent
    {
        private object uslov;

        public AsistentPretrazi(object uslov)
        {
            this.uslov = uslov;
        }
        public override string VratiCommandText(ADomen paket)
        {
            return $"select {paket.VratiSelect()} from {paket.VratiJoin()} where {paket.UslovZaPretragu()} '{uslov}%'";
        }
    }
}
