using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistentBrokerDB
{
    public class AsistentIzmeni : Asistent
    {
        public override string VratiCommandText(ADomen paket)
        {
            return $"update {paket.VratiJoin()} set {paket.VrednostiZaIzmenu()} where {paket.UslovZaZajednicke()}";
        }

       
    }
}
