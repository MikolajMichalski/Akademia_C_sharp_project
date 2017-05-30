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

        DatabaseService dbS = new DatabaseService();
        public WorkSpaceFrame()
        {   
            InitializeComponent();
        }

        private void ViewProfile(object sender, RoutedEventArgs e)
        {
            WorkSpace.Navigate(new ProfilePage());
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
    }
}
