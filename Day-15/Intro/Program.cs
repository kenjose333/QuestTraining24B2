using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
            var sum = data.Skip(3).Take(5).Where(x => x % 2 == 0).Sum();
            var firstItem = data.First();
            var firstOrDefault = data.FirstOrDefault();
            var lst = data.Last();
            var lastOrDefault = data.LastOrDefault();
            var SortedAscending = data.OrderBy(x => x);
            var sorteddecending = data.OrderByDescending(x=> x);
            var min = data.Min(x=>x);
            var max = data.Max(x=>x);
            var count = data.Count();
            var mingreaterThanFive = data.Min(x => x > 5);
            var countOfNumbersLessThanFive = data.Count(x => x < 5);

        }
    }
}
