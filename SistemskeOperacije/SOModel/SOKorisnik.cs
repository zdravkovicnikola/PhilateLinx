using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Repozitorijum;

namespace SistemskeOperacije.SOModel
{
    public abstract class SOKorisnik:ASO <KorisnikRepozitorijum>
    {
        protected static List<Korisnik> prijavljeniKorisnici = new List<Korisnik>();
        protected int Validacija(Korisnik korisnik)
        {
            for (int i = 0; i < prijavljeniKorisnici.Count; i++)
            {
                if (korisnik.Imejl == prijavljeniKorisnici[i].Imejl && korisnik.Lozinka == prijavljeniKorisnici[i].Lozinka)
                {
                    return i;
                }
            }
            return -1;
        }
        protected override void postaviRepozitorijum()
        {
            this.repozitorijum = new KorisnikRepozitorijum();
        }
    }
}
