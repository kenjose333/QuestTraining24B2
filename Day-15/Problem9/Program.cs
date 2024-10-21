using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            //Find Maximum Value
            //From a list of integers, return the maximum value.
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            var res = list.Max(x => x);
            Console.WriteLine(res);

        }
    }
}
