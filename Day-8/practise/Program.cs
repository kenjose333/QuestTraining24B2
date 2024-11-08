using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{   class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Display()
        {
            Console.WriteLine($"Name = {Name}, Age = {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.Age = 10;
            obj.Name = "Test";
            obj.Display();

        }
    }
}
