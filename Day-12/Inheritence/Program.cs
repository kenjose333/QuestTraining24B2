using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Student
    {
        public string name { get; set; }
        public string email { get; set; }
    }
    class College : Student
    {
        public string CollegeName { get; set; }
        public override string ToString()
        {
            return $"name :{name} email:{email} collegename:{CollegeName}";
        }
    }
    class School : Student
    {
        public string SchoolName { get; set; }
        public override string ToString()
        {
            return $"name :{name} email:{email} schoolname:{SchoolName}";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var s1 = new School();
                s1.name = "ken";
                s1.email = "kenjose333@gmail.com";
                s1.SchoolName = "belivers";
                Console.WriteLine(s1);
            }
        }
    }
}
