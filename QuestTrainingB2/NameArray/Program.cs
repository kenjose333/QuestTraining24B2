using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to be checked:");
            string sentence = Console.ReadLine().Replace(" ", "");
            string rev = string.Concat(sentence.Reverse());
            if(sentence == rev)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
            
        }
        }
 }
