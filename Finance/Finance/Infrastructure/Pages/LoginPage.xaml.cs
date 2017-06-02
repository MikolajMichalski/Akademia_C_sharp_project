using Finance.Infrastructure.Pages;
using Finance.Infrastructure.Services;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        WorkSpaceFrame WSP = new WorkSpaceFrame();
        public static DatabaseService dbS = new DatabaseService();
        public LoginPage()
        {           
            InitializeComponent();
         
            UsersList.Items.Refresh();
            UsersList.ItemsSource = dbS.usersList;
        }

        private void SignUp(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUpPage());          
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            if (UsersList.SelectedValue != null)
            {
                NavigationService.Navigate(WSP);
                WSP.DataContext = dbS.usersList.ElementAt(UsersList.SelectedIndex);
                dbS.LoggedUser = dbS.usersList.ElementAt(UsersList.SelectedIndex);
            }
            else MessageBox.Show("Please sign up or select an user");
            

        }
    }
}
