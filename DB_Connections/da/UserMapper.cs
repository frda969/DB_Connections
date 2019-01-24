using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DB_Connections.bl;

namespace DB_Connections.da
{
    class UserMapper
    {
        DBConnection conn = new DBConnection();
        public UserMapper() { }

        public List<User> getUsers()
        {
            SqlDataReader dataReader = conn.runSelectQuery("SELECT * FROM USERS ");
            if (dataReader.HasRows)
            {
                List<User> users;
                while (dataReader.Read)
                {
                    User user = new User();
                    user.Id = Int32.Parse(dataReader["Id"].ToString());
                    user.FirstName = dataReader["FirstName"].ToString();
                    user.LastName = dataReader["LastName"].ToString();
                    this.users.Add(user);
                }
                return users;
            }
            else { return null; }


        }

    }
}
