using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        

        public User(int UserId, string Name, string LastName)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.LastName = LastName;

        }

    }
}
