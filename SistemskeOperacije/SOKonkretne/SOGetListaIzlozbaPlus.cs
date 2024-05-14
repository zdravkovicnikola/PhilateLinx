using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOGetListaIzlozbaPlus : SOIzlozba
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            Izlozba izlozba = new Izlozba();
            List<Izlozba> izlozbe = new List<Izlozba>();
            if (repozitorijum.Get().Count != 0)
            {
                foreach (Izlozba i in repozitorijum.Get())
                {
                    izlozba.IzlozbaID = i.IzlozbaID;
                    i.Rezervacije = repozitorijum.GetComplex(izlozba);
                    izlozbe.Add(i);
                }
                return izlozbe.ConvertAll(x => (ADomen)x); ;
            }
            return null;
        }
    }
}
