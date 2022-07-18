using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppon_Book_Store
{
    internal class DataAccess
    {
        public async static void InitializeDatabase()
        {
            using (SqliteConnection db =
                 new SqliteConnection($"Filename=SQLBOOK.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Books (ISBN INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "Title VARCHAR(100) NULL, " +
                    "Description VARCHAR(300) NULL," +
                    "Price DOUBLE NULL)";
                String tableCommand2 = "CREATE TABLE IF NOT " +
                    "EXISTS Customers (Customer_Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "Customer_Name VARCHAR(60) NULL, " +
                    "Address VARCHAR(300) NULL," +
                    "Email VARCHAR(100) NULL)";
                String tableCommand3 = "CREATE TABLE IF NOT " +
                    "EXISTS Transactions (ISBN VARCHAR(60) NULL, " +
                    "Customer_Id VARCHAR(60) NULL, " +
                    "Customer_Name VARCHAR(60) NULL, " +
                    "Quatity VARCHAR(60) NULL," +
                    "Price VARCHAR(60) NULL," +
                    "Total_Price VARCHAR(60) NULL)";

                SqliteCommand createTablebook = new SqliteCommand(tableCommand, db);
                SqliteCommand createTablecustomers = new SqliteCommand(tableCommand2, db);
                SqliteCommand createTableTransaction = new SqliteCommand(tableCommand3, db);


                createTablebook.ExecuteReader();
                createTablecustomers.ExecuteReader();
                createTableTransaction.ExecuteReader();

            }
        }
    }
}
