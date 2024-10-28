using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debuggerrr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] {10,20,30,40,50};
            for (int i = 0; i <= arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
