using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession
{
    class Student
    {
        public string Name;
        public void DisplayName()
        {
            Console.WriteLine(Name.ToUpper());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "john";

            
        }
    }
}
