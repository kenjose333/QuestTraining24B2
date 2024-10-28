using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiseee
{
    internal class Program
    {
        //static bool Myfun(int a) => a % 2 == 0;
        static int MyFunction(int x, int y) => x + y;
        static void Main(string[] args)
        {
            Func<int, int, int> g = MyFunction;
            
            //Predicate<int> g = Myfun;
            Console.WriteLine(g(3));

        }
    }
}
