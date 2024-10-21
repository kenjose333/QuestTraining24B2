using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 2, 3, 4, 5, 5, 6, 7 };
            var answer = data.OrderByDescending(x => x).ToList();
            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
        }
    }
}
