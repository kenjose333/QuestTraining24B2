using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Number { get; set; }
        public override string ToString()
        {
            return $"name:{Name} , age ={Age} , Number: {Number}";
        }
    }
}
