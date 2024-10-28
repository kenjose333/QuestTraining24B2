using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            for (int i = 0;i < 2; i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    Console.WriteLine($"Enter the value for row{i} and column{j}");
                    arr[i,j] =int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
