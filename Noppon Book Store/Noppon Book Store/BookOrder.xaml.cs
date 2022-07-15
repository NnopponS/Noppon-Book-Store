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
    /// Interaction logic for BookOrder.xaml
    /// </summary>
    public partial class BookOrder : Window
    {
        public BookOrder()
        {
            InitializeComponent();
            List<TransactionsGroup> listOrderData = new List<TransactionsGroup>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand1 = new SqliteCommand
                     ("SELECT * FROM Transactions ", db);

                SqliteDataReader query = selectCommand1.ExecuteReader();

                while (query.Read())
                {
                    listOrderData.Add(new TransactionsGroup
                    {
                        ISBN = query.GetString(0),
                        CUS_ID = query.GetString(1),
                        CUS_Name = query.GetString(2),
                        Quatity = query.GetString(3),
                        Price = query.GetString(4),
                        TotalPrice = query.GetString(5)

                    });
                }

                dataGrid.ItemsSource = listOrderData;

                //CommboBox ID Book
                SqliteCommand selectCommand2 = new SqliteCommand
                    ("SELECT ISBN FROM Books ", db);

                SqliteDataReader query2 = selectCommand2.ExecuteReader();

                while (query2.Read())
                {
                    cbdISN.Items.Add(query2.GetString(0));
                }



                SqliteCommand selectCommand3 = new SqliteCommand
                    ("SELECT Customer_Id FROM Customers ", db);

                SqliteDataReader query3 = selectCommand3.ExecuteReader();

                while (query3.Read())
                {
                    cbdCustomers.Items.Add(query3.GetString(0));
                }

                db.Close();
            }


        }

        class TransactionsGroup
        {
            public string ISBN { get; set; }
            public string CUS_ID { get; set; }
            public string CUS_Name { get; set; }
            public string Quatity { get; set; }
            public string Price { get; set; }
            public string TotalPrice { get; set; }

        }

        private void Back_to_menu_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void cbdISN_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ISBNbooks = (string)cbdISN.SelectedItem;

            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();
                SqliteCommand selectCommand4 = new SqliteCommand
                 ("SELECT * FROM Books WHERE ISBN = "+ISBNbooks , db);

                SqliteDataReader query4 = selectCommand4.ExecuteReader();

                while (query4.Read())
                {
                    txtNameBooks.Text = query4.GetString(1);
                    txtDescription.Text = query4.GetString(2);
                    txtPrice.Text = query4.GetString(3);
                }

                db.Close();
            }
        }

        private void cbdCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string cusID = (string)cbdCustomers.SelectedItem;

            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();
                SqliteCommand selectCommand5 = new SqliteCommand
                 ("SELECT * FROM Customers WHERE Customer_Id = " + cusID, db);

                SqliteDataReader query5 = selectCommand5.ExecuteReader();

                while (query5.Read())
                {
                    txtCusName.Text = query5.GetString(1);
                    txt_Email.Text = query5.GetString(3);
                }

                db.Close();
            }
        }

        private void txtCart_Click(object sender, RoutedEventArgs e)
        {
            if (txtTotalPrice.Text==""&&txtPrice.Text==""&&txtQuatity.Text=="")
            {
                MessageBox.Show("Please select a book and a customer id." + "\n"+"Before add to cart.");
            }

            else
            {
                double price = double.Parse(txtPrice.Text);
                double Quatity = double.Parse(txtQuatity.Text);
                double totalPrice = price * Quatity;
                txtTotalPrice.Text = totalPrice.ToString();
            }
        }

        private void txtBuy_Click(object sender, RoutedEventArgs e)
        {
            if (txtTotalPrice.Text == "")
            {
                MessageBox.Show("Please fill Quatity and push the 'Add to Cart' Button"+"\n"+"Before buying");
            }

            else
            {
                string ISBNbooks = (string)cbdISN.SelectedItem;

                MessageBoxResult result = MessageBox.Show("ISBN : " + ISBNbooks +
                    "\n" + "Title : " + txtNameBooks.Text + "\n" +
                    "Customer ID : " + cbdCustomers.Text + "\n" +
                    "Quatity : " + txtQuatity.Text + "\n" +
                    "Total Price : " + txtTotalPrice.Text, "Order details", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    Insert_Data.AddDataTransitions(ISBNbooks, cbdCustomers.Text, txtCusName.Text, txtQuatity.Text, txtPrice.Text, txtTotalPrice.Text);


                    List<TransactionsGroup> listOrderData = new List<TransactionsGroup>();
                    using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
                    {
                        db.Open();

                        SqliteCommand selectCommand1 = new SqliteCommand
                             ("SELECT * from Transactions ", db);

                        SqliteDataReader query = selectCommand1.ExecuteReader();

                        while (query.Read())
                        {
                            listOrderData.Add(new TransactionsGroup
                            {
                                ISBN = query.GetString(0),
                                CUS_ID = query.GetString(1),
                                CUS_Name = query.GetString(2),
                                Quatity = query.GetString(3),
                                Price = query.GetString(4),
                                TotalPrice = query.GetString(5)

                            });
                        }

                        dataGrid.ItemsSource = listOrderData;
                        db.Close();
                        MessageBox.Show("Order Completed");
                        txtQuatity.Text = "";
                        txtTotalPrice.Text = "";
                    }
                }
            }
        }
    }
}
