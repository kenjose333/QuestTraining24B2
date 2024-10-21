using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lis = new List<string>() {"Abel","ken","Allen","Aaron"};
            var data = lis.Where(x => x.StartsWith("A"));
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
