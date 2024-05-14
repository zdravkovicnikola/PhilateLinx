using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOOdjaviKorisnika : SOKorisnik
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            int index = Validacija((Korisnik)objekat);
            prijavljeniKorisnici.Remove(prijavljeniKorisnici[index]);
            return null;
        }
    }
}
