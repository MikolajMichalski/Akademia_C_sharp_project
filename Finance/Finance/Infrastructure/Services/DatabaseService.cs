using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Finance.Infrastructure.Services
{
   public class DatabaseService : IDatabaseService
    {

     
        private SqlConnection connection = null;
        public ISet<User> usersList = new HashSet<User>();
        public User LoggedUser;
      
        public void InsertUser(User user)
        {
            string ConnectionString = "Data Source = MIKOŁAJ\\MIKOŁAJMICHALSKI; Initial Catalog = Finance ; Integrated Security=true;";

            connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MessageBox.Show("connection openned succefully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("connection failed");
            }
            SqlCommand command = new SqlCommand(@"INSERT INTO UsersTable (UserID, UserName, UserLastName) VALUES (@userID, @UserName, @UserLastName)", connection);

            command.Parameters.AddWithValue("@userID", user.UserId);
            command.Parameters.AddWithValue("@UserName", user.Name);
            command.Parameters.AddWithValue("@UserLastName", user.LastName);

            command.ExecuteNonQuery();
            usersList.Add(user);
            connection.Close();
            
        }

        public void StartupUsersLoading()
        {
            string ConnectionString = "Data Source = MIKOŁAJ\\MIKOŁAJMICHALSKI; Initial Catalog = Finance ; Integrated Security=true;";

            connection = new SqlConnection(ConnectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Connection openned succefully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed");
            }

            var command = new SqlCommand("SELECT * FROM UsersTable", connection);
            SqlDataReader dataReader = command.ExecuteReader();
           
            while (dataReader.Read())
            {
                usersList.Add(new User(dataReader.GetFieldValue<int>(0), dataReader.GetString(1), dataReader.GetString(2)));
            }

            connection.Close();
          
        }

        
    }
}
