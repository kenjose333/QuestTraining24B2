using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student__problem
{   class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;
        public void TotalMarks()
        {
            Console.WriteLine($"Total marks is {Mark1 + Mark2 + Mark3}");
        }
        public void AvgMarks()
        {
            Console.WriteLine($"The avg marks are {(Mark1 + Mark2 + Mark3) / 3}");
        }
    }
    internal class FileName
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "ken";
            s.Mark1 = 10;
            s.Mark2 = 20;
            s.Mark3 = 30;
            s.TotalMarks();
            s.AvgMarks();
        }
        
    }
}
