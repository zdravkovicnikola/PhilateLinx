using Domen;
using SistemskeOperacije.SOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKonkretne
{
    public class SOKreirajIzlozbu : SOIzlozba
    {
        protected override List<ADomen> IzvrsiKonretno(ADomen objekat)
        {
            Izlozba izlozba = (Izlozba)objekat;
            List<ADomen> list = new List<ADomen> ();
            if (repozitorijum.Get().Count != 0)
            {
                foreach (Izlozba i in repozitorijum.Get())
                {
                    if (i.Naziv == izlozba.Naziv && i.DatumOdrzavanja == izlozba.DatumOdrzavanja && i.MestoOdrzavanja == izlozba.MestoOdrzavanja)
                    {
                        return null;
                    }
                }
            }

            repozitorijum.Dodaj((Izlozba)objekat);
            list.Add(izlozba);
            return list;
        }
    }
}
