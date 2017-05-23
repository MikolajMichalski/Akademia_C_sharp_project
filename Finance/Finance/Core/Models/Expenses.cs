using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Models
{
   public class Expenses
    {
        public Guid Id { get; protected set; }
        public string ExpenseName { get; protected set; }
        public float Cost { get; protected set; }
        public Category Category { get; protected set; }

        public Expenses(Guid id, string expenseName, float cost, Category category)
        {
            Id = Guid.NewGuid();
            ExpenseName = expenseName;
            Cost = cost;
            Category = category;

        }
    }
}
