using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> list = new List<float>() { 1.1f, 2.2f, 3.3f, 4.5f, 5.6f, 6.7f, 7.6f, 8.4f, 9.2f, 51.2f };
            var ans = list.Sum(x => x);
            Console.WriteLine(ans);
        }
    }
}
