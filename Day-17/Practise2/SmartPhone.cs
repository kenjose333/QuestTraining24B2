using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise2
{
    internal class SmartPhone
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public List<int> MyProperty { get; set; }
        public SmartPhone()
        {
            Name = "ken";
            Manufacturer = "Microsoft";
        }
        public SmartPhone(string name,int age)
        {
            Name=name;
            Manufacturer = "Microsoft";
        }
        public void Display()
        {
            Console.WriteLine("name:" + Name);
            Console.WriteLine("manufacturer:" + Manufacturer);
            Console.WriteLine("MyProperty:" + string.Join(",",MyProperty));
        }
    }
}
