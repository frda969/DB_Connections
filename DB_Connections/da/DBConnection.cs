using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_Connections.da
{
    class DBConnection
    {
        SqlConnection db_conn;
        SqlConnectionStringBuilder connStr = new SqlConnectionStringBuilder
        {
            Authentication = SqlAuthenticationMethod.ActiveDirectoryIntegrated,
            DataSource = "localhost",
            InitialCatalog = "TestDB"
        };

        public DBConnection ()
        {
            db_conn = new SqlConnection(connStr.ToString());
            db_query = new SqlCommand("", db_conn);
        }

        public bool Open()
        {
            db_conn.Open();
            return true;
        }
    }
}
            
