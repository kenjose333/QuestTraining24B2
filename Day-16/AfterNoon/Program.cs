using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterNoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91859\Documents\QuestDb.mdf;Integrated Security=True;Connect Timeout=30";
            /*var createTableQuery = @"CREATE TABLE BOOKS
                                    (
                                        id  INT PRIMARY KEY IDENTITY,
                                        name VARCHAR(50),
                                        author VARCHAR(50),
                                        price int default 0
                                        )";
            var conn = new SqlConnection(connStr);
            conn.Open();
            var command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();
            conn.Close();*/
            Console.WriteLine("Name");
            var name = Console.ReadLine();
            Console.WriteLine("author");
            var author = Console.ReadLine();
            Console.WriteLine("price");
            var price = Console.ReadLine();
            var insertquery = $"INSERT INTO BOOKS(name,author,price) VALUES(@name,@author,@price)";
            var conn = new SqlConnection(connStr);
            conn.Open();
            var command = new SqlCommand(insertquery, conn);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@author",author);
            command.Parameters.AddWithValue("@price", price);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
