using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lis = new List<int>() { 1,2,3,4,5,6,7,8,9};
            var data = lis.Where(i => i % 2 == 0).ToList();
            foreach (int i in data)
            {
                Console.WriteLine(i);
            }

        }
    }
}
