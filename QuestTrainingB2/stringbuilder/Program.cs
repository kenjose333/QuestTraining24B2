using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number of rows:");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //for(int j = 0; j<i; j++)
            //{
            //Console.Write("*");
            //}
            //Console.WriteLine();
            // }
            /*Console.WriteLine("Enter the number of rows:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    count = count + 1;
                    Console.Write($"{count} ");
                }
                Console.WriteLine();
            }
            */
            /*Console.WriteLine("Enter the number of rows:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    count = count + 1;
                    Console.Write($"{count} ");
                }
                count = 0;
                Console.WriteLine();
            }*/
            Console.WriteLine("Enter the string:");
            string sentence = Console.ReadLine();
            foreach (var letter in sentence)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' letter == 'o' || letter == 'u';){
                    Console.WriteLine(letter);
                }
            }
        }
    }
}
