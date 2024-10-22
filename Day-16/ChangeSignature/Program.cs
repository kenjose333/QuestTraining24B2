using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeSignature
{
    internal class Program
    {   
        static int clac(int a, int b, bool doAddition)
        {
            return doAddition ? a + b : a - b;
        }
        static void Main(string[] args)
        {
            var result = clac(2, 3, true);
            Console.WriteLine(result);
        }
    }
}
