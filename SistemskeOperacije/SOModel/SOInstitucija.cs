using Domen;
using Repozitorijum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOModel
{
    public abstract class SOInstitucija : ASO<InstitucijaRepozitorijum>
    {
        protected int Validacija(Institucija institucija)
        {
            for (int i = 0; i < prijavleneInstitucije.Count; i++)
            {
                if (institucija.Imejl == prijavleneInstitucije[i].Imejl && institucija.Lozinka == prijavleneInstitucije[i].Lozinka)
                {
                    return i;
                }
            }
            return -1;
        }

        protected static List<Institucija> prijavleneInstitucije = new List<Institucija>();

        protected override void postaviRepozitorijum()
        {
            this.repozitorijum = new InstitucijaRepozitorijum();
        }
    }
}
