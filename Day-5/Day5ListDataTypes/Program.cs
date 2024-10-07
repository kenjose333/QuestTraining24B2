using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ListDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<int>();
            Console.WriteLine("Enter the number of elements:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                lst.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < lst.Count; i++)
            {
               if (lst[i] % 2 == 0)
                  {
                    lst.Remove(lst[i]);
                  }
            foreach(var item in lst)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
