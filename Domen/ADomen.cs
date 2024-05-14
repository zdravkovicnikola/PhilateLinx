using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public abstract class ADomen
    {
        public abstract string UslovZaPretragu();
        public abstract string Vrednosti();
        public abstract string NazivTabele();
        public abstract void ProcitajReader(SqlDataReader reader, out ADomen objekat);
        public abstract string UslovZaZajednicke();
        public abstract string VratiSelect();
        public abstract string VratiJoin();
        public abstract string UslovZaBrisanje();
        public abstract string VrednostiZaIzmenu();
    }
}
