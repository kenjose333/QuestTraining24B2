using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{   
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the numbers");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());
                Console.WriteLine(i/j);
            }
            catch
            {
                Console.WriteLine("An error occured");
            }

           
        }
    }
}
