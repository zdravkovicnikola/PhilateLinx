using AsistentBrokerDB;
using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public abstract class ApsRepozitorijum // MORA IMATI SVE 4 CRUD operacije
    {
        internal Asistent asistentDB;

        public void Dodaj(ADomen objekat)
        {
            try
            {
                asistentDB = new AsistentDodaj();
                asistentDB.IzvrsiSO(objekat);
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            };
        }

        public void Obrisi(ADomen objekat)
        {
            try
            {
                asistentDB = new AsistentObrisi();
                asistentDB.IzvrsiSO(objekat);
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        public void Izmeni(ADomen objekat)
        {
            try
            {
                asistentDB = new AsistentIzmeni();
                asistentDB.IzvrsiSO(objekat);
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
        }
        public abstract List<ADomen> Get();

        public abstract List<ADomen> Pretrazi(object uslov);
    }
}
