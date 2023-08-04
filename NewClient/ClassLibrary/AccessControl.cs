using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dapper;

namespace NewClient.ClassLibrary
{
    public class AccessControl
    {
        public SqlConnection appConnection;
        public SqlCommand appCommand;

        public void DbConnection()
        {
            
            //string connectionString = @;
            appConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RecordsDB;Integrated Security=True");
        }

        public void ConnectDB()
        {
            appConnection.Open();
        }
        public void DisconnectDB()
        {
            appConnection.Close();
        }

        public SqlDataReader GetData(string query)
        {
            appCommand = new SqlCommand(query, appConnection);
            //SqlDataReader sdr = myCommand.ExecuteReader();
            //return sdr;
            return appCommand.ExecuteReader();
        }
        public int ExecuteSQL(string query)
        {
            appCommand = new SqlCommand(query, appConnection);
            //int x= myCommand.ExecuteNonQuery();
            //return x;
            return appCommand.ExecuteNonQuery();
        }

        /*
        public List<Client> GetClients(string Name)
        {
            using (IDbConnection Connection = new System.Data.SqlClient.SqlConnection(DBConnection.CnnVal("ClientContactDB")))
            {
                var Output = Connection.Query<Client>($"Select * from CentralRecordTable where Client_Name = '{Name}'").ToList();
                return Output;
            }
        }*/
        

    }
}
