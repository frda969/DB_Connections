using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DB_Connections.da
{
    class DBConnection
    {
        private SqlConnection db_conn;
        SqlConnectionStringBuilder connStr = new SqlConnectionStringBuilder
        {
            Authentication = SqlAuthenticationMethod.ActiveDirectoryIntegrated,
            DataSource = "localhost",
            InitialCatalog = "TestDB"
        };

        public DBConnection()
        {
            db_conn = new SqlConnection(connStr.ToString());
        }

        private SqlConnection openConnection()
        {
            if (db_conn.State == ConnectionState.Closed || db_conn.State == ConnectionState.Broken)
            {
                try
                {
                    db_conn.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return db_conn;
        }
        public SqlDataReader runSelectQuery(string query)
        {
            using (SqlCommand myCommand = new SqlCommand())
            {
                myCommand.CommandText = query;
                myCommand.Connection = openConnection();
                try
                {
                    SqlDataReader myDataReader = myCommand.ExecuteReader();
                    return myDataReader;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return null;
                }
            }
        }
    }
}

