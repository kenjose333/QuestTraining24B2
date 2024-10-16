using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProblem
{
    internal class Student
    {
        public string StudentName;
        public string RegistrationNumber;
        public string Standerd;
        public override string ToString()
        {
            return $"StudentName:{StudentName},RegistrationNumber:{RegistrationNumber},Standerd:{Standerd}";
        }
    }
}
