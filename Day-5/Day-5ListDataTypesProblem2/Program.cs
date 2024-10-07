using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5ListDataTypesProblem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of students:");
            int num = int.Parse(Console.ReadLine());
            var data = new List<List<int>>();
            for (int i = 0; i < num; i++)
            {
                var lst = new List<int>();
                for (int j = 0; j < 3; j++)
                {
                    lst.Add(int.Parse(Console.ReadLine()));
                }
                data.Add(lst);
                Console.WriteLine();
            }
            foreach (var item in data)
            {
                Console.WriteLine(string.Join(",",item));
            }
            
        }
    }
}
