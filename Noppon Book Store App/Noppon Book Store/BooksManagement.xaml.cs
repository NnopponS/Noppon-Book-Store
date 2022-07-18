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
    /// Interaction logic for BooksManagement.xaml
    /// </summary>
    public partial class BooksManagement : Window
    {
        public BooksManagement()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            List<BooksGroup> listBooksData = new List<BooksGroup>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Books", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listBooksData.Add(new BooksGroup { ISBN = query.GetString(0), Title = query.GetString(1), Description = query.GetString(2), Price = query.GetString(3) });
                }

                dataGrid.ItemsSource = listBooksData;
                db.Close();
            }
        }
        class BooksGroup
        {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Insert_Data.AddDataBooks(txtISBN.Text, txtTitle.Text, txtDescription.Text, txtPrice.Text);
            MessageBox.Show("Data added successfully." + "\n" + "\n" + "\n" + "Please press the refresh button.");
        }

        private void Back_to_menu_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            List<BooksGroup> listBooksData = new List<BooksGroup>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Books", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listBooksData.Add(new BooksGroup { ISBN = query.GetString(0), Title = query.GetString(1), Description = query.GetString(2), Price = query.GetString(3) });
                }

                dataGrid.ItemsSource = listBooksData;
                db.Close();
            }
        }


        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Remove_Data.RemoveDataBooks(txtISBN.Text);
            MessageBox.Show("Data removed successfully." + "\n" + "\n" + "\n" + "Please press the refresh button.");
        }


        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditData.EditdataBooks(txtISBN.Text, txtTitle.Text, txtDescription.Text, txtPrice.Text);
            MessageBox.Show("Data edited successfully." + "\n" + "\n" + "\n" + "Please press the refresh button.");
        }



        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string dataSearch = txtSearch.Text;
            List<BooksGroup> listBooksData = new List<BooksGroup>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Books where ISBN like " + "'%" + dataSearch + "%'" +
                    " or Title like" + "'%" + dataSearch + "%'"
                    + " or Price like" + "'%" + dataSearch + "%'", db);


                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listBooksData.Add(new BooksGroup { ISBN = query.GetString(0), Title = query.GetString(1), Description = query.GetString(2), Price = query.GetString(3) });
                }

                dataGrid.ItemsSource = listBooksData;
                db.Close();
            }
        }


    }
}
