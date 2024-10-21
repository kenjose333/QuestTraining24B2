using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal class Program
    {
        //Find First String Starting with 'B'
        //From a list of strings, return the first string that starts with the letter 'B'. If none exists, return null.
        static void Main(string[] args)
        {
            List<string> lis = new List<string>() { "ken", "Ben", "zen" };
            var data = lis.Where(x => x.StartsWith("B")).FirstOrDefault();
        }
    }
}
