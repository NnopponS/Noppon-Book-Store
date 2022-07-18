using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppon_Book_Store
{
    internal class EditData
    {
        public static void EditdataCustomers(string id, string name, string address, string email)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                insertCommand.CommandText = "UPDATE Customers SET Customer_Name = @name, Address = @address, Email = @email WHERE Customer_Id = @id";
                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@address", address);
                insertCommand.Parameters.AddWithValue("@email", email);

                insertCommand.ExecuteReader();

                db.Close();
            }
        }

        public static void EditdataBooks(string ISBN, string Title, string Description, string Price)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                insertCommand.CommandText = "UPDATE Books SET Title = @title, Description = @description, Price = @price WHERE ISBN = @ISBN";
                insertCommand.Parameters.AddWithValue("@ISBN", ISBN);
                insertCommand.Parameters.AddWithValue("@title", Title);
                insertCommand.Parameters.AddWithValue("@description", Description);
                insertCommand.Parameters.AddWithValue("@price", Price);

                insertCommand.ExecuteReader();

                db.Close();
            }
        }
    }

}
