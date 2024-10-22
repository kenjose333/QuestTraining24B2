using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Details
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string PhNo { get; set; }
        public string Email { get; set; }

        public PersonalDetails(string name, string phno, string email)
        {
            Name = name;
            PhNo = phno;
            Email = email;
        }
    }

    internal class Program
    {
        const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91859\Documents\QuestProblem.mdf;Integrated Security=True;Connect Timeout=30";
        static void InsertDetails(List<PersonalDetails> people)
        {
            
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                foreach (var person in people)
                {
                    var insertQuery = @"INSERT INTO PEOPLE (name, phno, email) VALUES (@name, @phno, @email)";
                    using (var command = new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@name", person.Name);
                        command.Parameters.AddWithValue("@phno", person.PhNo);
                        command.Parameters.AddWithValue("@email", person.Email);

                        command.ExecuteNonQuery();
                    }
                }

                conn.Close();
                Console.WriteLine("Personal Details inserted successfully.");
            }
        }
       

        static void Main(string[] args)
        {
            var createTableQuery = @"CREATE TABLE PEOPLE
                                        (name varchar(50),
                                        phno varchar(10),
                                        email varchar(50)
                                        )";
            var conn = new SqlConnection(connStr);
            conn.Open();

            var command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();

            conn.Close();

            var person = new List<PersonalDetails>()
            {
                new PersonalDetails("Alpha", "6567869873", "alpha@mail.com"),
                new PersonalDetails("Beta", "8987869873", "beta@mail.com"),
                new PersonalDetails("Gamma", "9797869873", "alpha@mail.com"),
                new PersonalDetails("Delta", "2327869873", "delta@mail.com"),
                new PersonalDetails("Epsilon", "1217869873", "epsilon@mail.com")
            };

            InsertDetails(person);
        }

    }
}