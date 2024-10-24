using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise2
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new SmartPhone();
            obj1.Display();

            var obj2 = new SmartPhone()
            {
                Name = "S4",
                Manufacturer = "samsung",
                MyProperty = new List<int> { 3, 4, 5, 6, 7 },
               

            };
            obj2.Display();

        }
    }
}
