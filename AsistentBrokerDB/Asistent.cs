using BrokerDB;
using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistentBrokerDB
{
    public abstract class Asistent
    {
        public void IzvrsiSO(ADomen paket)
        {
            try
            {
                Broker.Instance.ConnectionOpen();
                Broker.Instance.BeginTransaction();

                SqlCommand comm = Broker.Instance.CreateCommand();
                comm.CommandText = VratiCommandText(paket);

                comm.ExecuteNonQuery();

                Broker.Instance.Commit();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                Broker.Instance.Rollback();
                throw;
            }
            finally
            {
                Broker.Instance.ConnectionClose();
            }
        }
        public List<ADomen> Get(ADomen objekat)
        {
            List<ADomen> lista = new List<ADomen>();
            try
            {
                Broker.Instance.ConnectionOpen();

                SqlCommand command = Broker.Instance.CreateCommand();
                command.CommandText = VratiCommandText(objekat);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    objekat.ProcitajReader(reader, out objekat);

                    lista.Add(objekat);
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                Broker.Instance.ConnectionClose();
            }
            return lista;
        }
        public abstract string VratiCommandText(ADomen paket);

    }
}
