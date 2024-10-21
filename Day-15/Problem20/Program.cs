using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Alpha", "Beta", "Gamma", "Delta" };
            var marks = new List<int> { 66, 75, 88, 90 };
            var zip = names.Zip(marks);
            foreach (var i in zip)
            {
                System.Console.WriteLine(i);

            }

        }
    }
}
