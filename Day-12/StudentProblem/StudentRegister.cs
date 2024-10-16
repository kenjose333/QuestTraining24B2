using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProblem
{
    internal class StudentRegister
    {
        private List<Student> StudentList = new List<Student>();

        public void Add(Student data)
        {
            if (GetStudentByRegistraionNumber(data.RegistrationNumber) != null)
            {
                Console.WriteLine("student already exists");
                return;
            }

            StudentList.Add(data);
            Console.WriteLine("Added successfully");
        }

        public void Search(string registrationNumber)
        {
            var data = GetStudentByRegistraionNumber(registrationNumber);
            Console.WriteLine(data);
        }

        public void Update(string StudentName, string RegistrationNumber, string Standerd)
        {
            var data = GetStudentByRegistraionNumber(RegistrationNumber);
            if (data == null)
            {
                Console.WriteLine("student not found");
                return;
            }

            data.Standerd = Standerd;
            data.StudentName = StudentName;
            data.RegistrationNumber = RegistrationNumber;
            Console.WriteLine("Updated successfully");
        }

        public void Delete(string registrationNumber)
        {
            var data = GetStudentByRegistraionNumber(registrationNumber);
            if (data == null)
            {
                Console.WriteLine("student not found");
                return;
            }

            StudentList.Remove(data);
            Console.WriteLine("Deleted successfully");
        }

        private Student GetStudentByRegistraionNumber(string registrationNumber)
        {
            // Check if the same card exists.
            foreach (var data in StudentList)
            {
                if (data.RegistrationNumber == registrationNumber)
                {
                    return data;
                }
            }
            return null;
        }
    }
}
