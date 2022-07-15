using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppon_Book_Store
{
    internal class Insert_Data
    {


        public static void AddDatacus(string customerID, string cusname, string address, string email)
        {


            using (SqliteConnection db =
            new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand("SELECT Customer_Id, Customer_Name, Address, Email from Customers", db);
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT OR REPLACE INTO Customers VALUES (@customerID,@cusName, @Address, @Email);";
                insertCommand.Parameters.AddWithValue("@customerID", customerID);
                insertCommand.Parameters.AddWithValue("@cusName", cusname);
                insertCommand.Parameters.AddWithValue("@Address", address);
                insertCommand.Parameters.AddWithValue("@Email", email);
                insertCommand.ExecuteReader();

                db.Close();
            }
        }




        public static void AddDataBooks(string ISBN, string Title, string Description, string Price)
        {


            using (SqliteConnection db =
            new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand("SELECT * from Books", db);
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT OR REPLACE INTO Books VALUES (@ISBN, @Title, @Description, @Price);";
                insertCommand.Parameters.AddWithValue("@ISBN", ISBN );
                insertCommand.Parameters.AddWithValue("@Title", Title);
                insertCommand.Parameters.AddWithValue("@Description", Description);
                insertCommand.Parameters.AddWithValue("@Price", Price);
                insertCommand.ExecuteReader();

                db.Close();
            }
        }


        public static void AddDataTransitions(string ISBN, string Customer_Id, string Customer_Name, string Quatity, string Price, string Total_Price)
        {


            using (SqliteConnection db =
            new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand("SELECT * from Transitions", db);
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT OR REPLACE INTO Transactions VALUES (@ISBN, @Customer_Id, @Customer_Name, @Quatity, @Price, @Total_Price);";
                insertCommand.Parameters.AddWithValue("@ISBN", ISBN);
                insertCommand.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                insertCommand.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                insertCommand.Parameters.AddWithValue("@Quatity", Quatity);
                insertCommand.Parameters.AddWithValue("@Price", Price);
                insertCommand.Parameters.AddWithValue("@Total_Price", Total_Price);
                insertCommand.ExecuteReader();

                db.Close();
            }
        }
    }
}
