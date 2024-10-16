using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new StudentRegister();

            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var details = GetStudentData();
                        student.Add(details);
                        break;
                    case "2":
                        Console.Write("Enter the registration number to search: ");
                        var RegistrationNumber = Console.ReadLine();
                        student.Search(RegistrationNumber);
                        break;
                    case "3":
                        var studentToUpdate = GetStudentData();
                        student.Update(studentToUpdate.StudentName,
                            studentToUpdate.RegistrationNumber,
                            studentToUpdate.Standerd);
                        break;
                    case "4":
                        Console.Write("Enter the registration number to delete: ");
                        var registerNumberToDelete = Console.ReadLine();
                        student.Delete(registerNumberToDelete);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
        private static Student GetStudentData()
        {
            Student details = new Student();

            Console.Write("Enter the student name: ");
            details.StudentName = Console.ReadLine();

            Console.Write("Enter the registration number: ");
            details.RegistrationNumber = (Console.ReadLine());

            Console.Write("Enter the standerd : ");
            details.Standerd = Console.ReadLine();
            return details;
        }
    }
}

