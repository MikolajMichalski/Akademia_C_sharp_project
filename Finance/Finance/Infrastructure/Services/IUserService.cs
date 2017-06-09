using Finance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Infrastructure.Services
{
    interface IUserService
    {
        void SetMoneyLimit(float Limit);

       /// void AddExpense(Expenses expense);
    }
}
