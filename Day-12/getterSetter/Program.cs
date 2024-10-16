using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getterSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Student
            {
                Name = "Alpha",
                Age = 200
            };
            System.Console.WriteLine(s.Name);
            System.Console.WriteLine(s.Age);
        }



    }
}
