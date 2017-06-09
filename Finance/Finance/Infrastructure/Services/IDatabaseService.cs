using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Finance.Infrastructure.Services
{
    interface IDatabaseService
    {

        void StartupUsersLoading();
        void InsertUser(User user);

        void UpdateUser(User user);
    
    }
}
