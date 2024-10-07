using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date of birth in dd-mm-yyyy");
            string dob = Console.ReadLine();
            string year = dob.Substring(6,4);
            Console.WriteLine(year);
            DateTime dt = DateTime.Now;
            /*Console.WriteLine(dt);
            Console.WriteLine($"Day :{dt.Day}");
            Console.WriteLine($"month :{dt.Month}");
            Console.WriteLine($"Year :{dt.Year}");
            Console.WriteLine($"minute :{dt.Minute}");
            Console.WriteLine($"Second :{dt.Second}");*/
            //var current = dt.AddDays(10);
            //Console.WriteLine(tenDaysFromNow);
            object obj = new object();

        }
    }
}
