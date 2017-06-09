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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class MoneyLimitChanger : Page
    {   
        public MoneyLimitChanger()
        {
            InitializeComponent();
             
        }


        private void SubmitMoneyLimit(object sender, RoutedEventArgs e)
        {

            try
            {
                LoginPage.userService.SetMoneyLimit(float.Parse(LimitText.Text));
                
                WorkSpaceFrame.profilePage.MoneyLimit.DataContext = LoginPage.userService.dbS.LoggedUser.Money;
                LoginPage.userService.dbS.UpdateUser(LoginPage.userService.dbS.LoggedUser);
                NavigationService.Navigate(WorkSpaceFrame.profilePage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input numbers");
                
            }
          
        }
    }
}
