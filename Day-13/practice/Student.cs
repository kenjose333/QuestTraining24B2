using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Student
    {
        public string Name;
        public void DisplayName() => Console.WriteLine($"hi {Name}");
        public int GetSum(int a,int b) => a + b;
        public List<Student> lis { get; set; } = new List<Student>();
    }
}
