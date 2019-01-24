using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Connections.bl
{
    class User
    {
        private int id;
        private string firstName;
        private string lastName;

        public User(int id, string fName, string lName)
        {
            this.id = id;
            this.firstName = fName;
            this.lastName = lName;
        }

        public int Id => id;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
