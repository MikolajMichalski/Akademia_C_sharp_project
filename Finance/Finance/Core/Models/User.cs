using Finance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
     public class User
    {
        public int UserId { get; protected set; }
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public float Money { get; protected set; }
        public float MoneyAvailable { get; set; }
        public IEnumerable<Expenses> ExpensesList { get; set; }
        public string FullName { get { return Name + " " + LastName; }  }


        public User(int userId, string Name, string LastName)
        {
            this.UserId = userId;
            this.Name = Name;
            this.LastName = LastName;

        }

    }
}
