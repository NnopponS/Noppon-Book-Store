using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppon_Book_Store
{
    internal class Remove_Data
    {
        public static void RemoveDataCustomer(string customerID)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                insertCommand.CommandText = "DELETE FROM Customers WHERE Customer_Id = @id";
                insertCommand.Parameters.AddWithValue("@id", customerID);

                insertCommand.ExecuteNonQuery();

                db.Close();
            }
        }


        public static void RemoveDataBooks(string ISBN)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                insertCommand.CommandText = "DELETE FROM Books WHERE ISBN = @isbn";
                insertCommand.Parameters.AddWithValue("@isbn", ISBN);

                insertCommand.ExecuteNonQuery();

                db.Close();
            }
        }


        public static void RemoveDataTransactions(string ISBN)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                insertCommand.CommandText = "DELETE FROM Transactions WHERE ISBN = @isbn";
                insertCommand.Parameters.AddWithValue("@isbn", ISBN);

                insertCommand.ExecuteNonQuery();

                db.Close();
            }
        }
    }
}
