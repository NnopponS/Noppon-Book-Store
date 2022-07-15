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

namespace Noppon_Book_Store
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Menu menu = new Menu();

        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }

        private void txtusername_GotFocus(object sender, RoutedEventArgs e)
        {
            txtusername.Text = "";
        }

        private void passwordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = "";
        }

        private void btnSignIn_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtusername.Text == "admin")
            {
                if (passwordBox.Password == "123")
                {
                    menu.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Password incorrect");
                }
            }
            else
            {
                MessageBox.Show("User not found in the system");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
            Close();
        }
    }
}
