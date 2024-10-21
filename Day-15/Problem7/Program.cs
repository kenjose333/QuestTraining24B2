using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "ken", "jose", "hello" };
            var groups = list.GroupBy(g => g.Length);
            foreach (var group in groups)
            {
                System.Console.WriteLine($"Word Length {group.Key} : {group.Count()}");
                foreach (var item in group)
                {
                    System.Console.WriteLine($"\t{item}");
                }
            }
        }
    }
}
