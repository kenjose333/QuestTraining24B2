using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lis = new List<int>() { 1,2,3,4,5,6,7,8,9};
            var ans = lis.Skip(5).Take(3);
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
