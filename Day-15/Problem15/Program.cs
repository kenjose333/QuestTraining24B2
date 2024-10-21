using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Remove Duplicates
            // From a list of integers with duplicates, return only the distinct numbers.
            List<int> list = new List<int>() { 1, 2,2,1,7,1, 3, 4, 5, 6, 7, 8, 9, 51 };
            var ans = list.Distinct().ToList();
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }

        }
    }
}
