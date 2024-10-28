using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise3
{   class A
    {
        public string Name { get; set; }
        public int age { get; set; }
    }

    class B : A
    {
        public string SchoolName { get; set; }
        public int id { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.Name = "Test";
            Console.WriteLine(obj.Name);
        }
    }
}
