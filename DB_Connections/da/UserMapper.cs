using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Connections.bl;

namespace DB_Connections.da
{
    class UserMapper
    {
        DBConnection conn = new DBConnection();
        public UserMapper() { }

        public List<User> getUsers()
        {
            conn.Open();
        }
        
    }
}
