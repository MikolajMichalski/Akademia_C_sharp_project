using Finance.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Infrastructure.Services
{
   public class UserService : IUserService
    {
       public DatabaseService dbS = new DatabaseService();
        public void SetMoneyLimit(float moneyLimit)
        {
            dbS.LoggedUser.Money = moneyLimit;
            dbS.usersList.Single(x => x.UserId == dbS.LoggedUser.UserId).Money = moneyLimit;
        }
    }
}
