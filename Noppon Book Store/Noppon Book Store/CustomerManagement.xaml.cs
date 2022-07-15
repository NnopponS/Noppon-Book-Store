using Microsoft.Data.Sqlite;
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
    /// Interaction logic for CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : Window
    {
        public CustomerManagement()
        {
            InitializeComponent();
            List<CusGroup> listCusData = new List<CusGroup>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Customers", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listCusData.Add(new CusGroup { Id = query.GetString(0), Name = query.GetString(1), Address = query.GetString(2), Email = query.GetString(3) });
                }

                dataGrid.ItemsSource = listCusData;
                db.Close();
            }
        }
        class CusGroup
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Insert_Data.AddDatacus(txtCusid.Text, txtCusName.Text, txtAddress.Text, txtEmail.Text);
            MessageBox.Show("Data added successfully."+"\n"+ "\n" + "\n" + "Please press the refresh button.");
        }

        private void Back_to_menu_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            List<CusGroup> listCusData = new List<CusGroup>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Customers", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listCusData.Add(new CusGroup { Id = query.GetString(0), Name = query.GetString(1), Address = query.GetString(2), Email = query.GetString(3) });
                }

                dataGrid.ItemsSource = listCusData;
                db.Close();
            }
        }


        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Remove_Data.RemoveDataCustomer(txtCusid.Text);
            MessageBox.Show("Data removed successfully." + "\n" + "\n" + "\n" + "Please press the refresh button.");
        }


        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditData.EditdataCustomers(txtCusid.Text, txtCusName.Text, txtAddress.Text, txtEmail.Text);
        }
        


        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string dataSearch = txtSearch.Text;
            List<CusGroup> listCusData = new List<CusGroup>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Customers where Customer_Id like " + "'%" + dataSearch + "%'" +
                    " or Customer_Name like" + "'%" + dataSearch + "%'"
                    + " or Email like" + "'%" + dataSearch + "%'", db);


                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listCusData.Add(new CusGroup { Id = query.GetString(0), Name = query.GetString(1), Address = query.GetString(2), Email = query.GetString(3) });
                }

                dataGrid.ItemsSource = listCusData;
                db.Close();
            }
        }
    }
}
