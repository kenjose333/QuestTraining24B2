using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,51};
            var ans = list.Where(x => x > 50);
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
