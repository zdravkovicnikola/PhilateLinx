using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerDB
{
    public class Broker
    {
        SqlConnection connection;
        SqlTransaction transaction;
        private static Broker instance;

        public static Broker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Broker();
                }
                return instance;
            }
        }
        private Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bazaMarkica;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }
        public void ConnectionOpen()
        {
            connection.Open();
        }
        public void ConnectionClose()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed) { }
            connection.Close();
        }
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }
        public void Commit()
        {
            transaction.Commit();
        }
        public void Rollback()
        {
            transaction.Rollback();
        }
        public SqlCommand CreateCommand()
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            return command;
        }
    }
}
