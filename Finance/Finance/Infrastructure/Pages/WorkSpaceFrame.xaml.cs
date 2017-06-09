using Finance.Infrastructure.Services;
using Finance.Pages;
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

namespace Finance.Infrastructure.Pages
{
    /// <summary>
    /// Interaction logic for WorkSpaceFrame.xaml
    /// </summary>
    public partial class WorkSpaceFrame : Page
    {

        // DatabaseService dbS = new DatabaseService();
        public static ProfilePage profilePage = new ProfilePage();
        public WorkSpaceFrame()
        {   
            InitializeComponent();
        }

        private void ViewProfile(object sender, RoutedEventArgs e)
        {
           
            WorkSpace.Navigate(profilePage);
            
            profilePage.User_ID.DataContext = LoginPage.userService.dbS.LoggedUser.UserId;
            profilePage.Name_Surname.DataContext = LoginPage.userService.dbS.LoggedUser.FullName;
            profilePage.MoneyLimit.DataContext = LoginPage.userService.dbS.LoggedUser.Money;
            profilePage.MoneyAvailable.DataContext = LoginPage.userService.dbS.LoggedUser.MoneyAvailable;
            profilePage.Date.DataContext = DateTime.UtcNow.Date;
            profilePage.DaysLeft.DataContext = DateTime.DaysInMonth(DateTime.UtcNow.Year, (int)DateTime.UtcNow.Month) - DateTime.UtcNow.Day;


        }

        private void YourExpenses(object sender, RoutedEventArgs e)
        {

        }

        private void AddExpense(object sender, RoutedEventArgs e)
        {

        }

        private void AdditionalExpenses(object sender, RoutedEventArgs e)
        {

        }

        private void SwitchProfiles(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }
    }
}
