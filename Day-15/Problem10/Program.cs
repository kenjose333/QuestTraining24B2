using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find Minimum Value
            //From a list of integers, return the minimum value.
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var ans = list.Min(x=>x);
            Console.WriteLine(ans);

        }
    }
}
