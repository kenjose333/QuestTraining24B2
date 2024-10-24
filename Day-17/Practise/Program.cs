using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{  
    internal class Program
    {
         
        static void Main(string[] args)
        {
            var obj1 = new Student()
            {
                Name = "ken",
                Age = 10,
                Number = 23
            };
            Console.WriteLine(obj1);
            var obj2 = new Student()
            {
                Name = "kenn",
                Age = 1000,
                Number = 2333
            };
            Console.WriteLine(obj2);
        }
    }
}
