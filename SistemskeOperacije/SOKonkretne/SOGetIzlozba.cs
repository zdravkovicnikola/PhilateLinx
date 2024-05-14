using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOGetIzlozba : SOIzlozba
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            var izlozbe = repozitorijum.Get();
            if (izlozbe.Count == 0) return null;
            foreach (Izlozba i in izlozbe)
            {
                if (i.DatumOdrzavanja < DateTime.Now)
                {
                    repozitorijum.Obrisi(i);
                }
            }
            return izlozbe;
        }
    }
}
