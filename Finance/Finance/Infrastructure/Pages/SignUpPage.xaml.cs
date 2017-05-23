using Finance.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Finance.Pages
{
    /// <summary>
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        LoginPage loginPage = new LoginPage();


        public SignUpPage()
        {
            InitializeComponent();

        }

        private void Create(object sender, RoutedEventArgs e)
        {
            DatabaseService dbS = new DatabaseService();
            var user = new User(int.Parse(IdBox.Text), NameBox.Text, LastNameBox.Text);

            dbS.InsertUser(user);
            loginPage.UsersList.Items.Refresh();
            NavigationService.Navigate(loginPage);
            
                      
        }
    }
}
