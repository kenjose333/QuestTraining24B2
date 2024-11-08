using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvFileHandling
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Person>
            {
                new Person{Name = "John", Age = 21},
                new Person{Name = "James" , Age = 30},
            };
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            var filePath = Path.Combine(desktop, "person.csv");

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(data);
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var datas = csv.GetRecords<Person>();
                foreach (var item in datas)
                {
                    Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
                }
            }
        }
    }
}
