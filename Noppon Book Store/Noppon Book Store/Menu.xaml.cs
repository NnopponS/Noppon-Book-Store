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
using System.Windows.Shapes;

namespace Noppon_Book_Store
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            CustomerManagement cusManage = new CustomerManagement();
            cusManage.Show();
            this.Close();
        }

        private void btnbooks_Click(object sender, RoutedEventArgs e)
        {
            BooksManagement booksManagement = new BooksManagement();
            booksManagement.Show();
            this.Close();
        }

        private void btnorder_Click(object sender, RoutedEventArgs e)
        {
            BookOrder booKorder = new BookOrder();
            booKorder.Show();
            this.Close();
        }

        private void btnSignOut_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("You want to Sign out?", "Sign Out", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Sign Out Completed", "Sign Out", MessageBoxButton.OK);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
    }
}
