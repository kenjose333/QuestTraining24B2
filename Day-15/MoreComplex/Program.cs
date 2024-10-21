using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreComplex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 2, 3, 4, 5 ,-2,-3};
            var res = data.Where(i => i < 0);
            Console.WriteLine(res);
        }
    }
}
