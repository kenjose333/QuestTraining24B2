using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1
{
    internal class Program
    {
        List<string> departments = new List<string> { "Cardiology", "Pediatrics", "Emergency" };
        Dictionary<string, string> doctors = new Dictionary<string, string>
            {
                {"ken","Pediatrics"},
                {"jose","Cardiology"},
                {"mathew","Emergency"}
            };
        Dictionary<string, Dictionary<string, string>> patients = new Dictionary<string, Dictionary<string, string>>
            {
                {"ken",new Dictionary<string, string>
                    {
                        {"rahul","admitted"},
                        {"rohan","notadmitted"}
                    }
                },
                {"jose",new Dictionary<string, string>
                    {
                        {"liya","admitted"},
                        {"nina","notadmitted"}
                    }

                },
                {"mathew",new Dictionary<string, string>
                    {
                        {"rojan","admitted"},
                        {"reenu","notadmitted"}
                    }
                }
            };
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("WELCOME TO HOSPITAL MANAGEMENT SYSTEM");
                Console.WriteLine("1.Add department and doctor");
                Console.WriteLine("2.Admit Patient");
                Console.WriteLine("3.Doctors in a department");
                Console.WriteLine("4.Patients assigned to a doctor");
                Console.WriteLine("5.Discharge Patient");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddDepartment();
                        break;
                    case 2:
                        AdmitPatient();
                        break;
                    case 3:
                        DoctorsinDepartment();
                        break;
                    case 4:
                        PatientsAndDoctors();
                        break;
                    case 5:
                        DischargePatient();
                        break;
                    case 6:
                        return;
                }

            }
        }
        public static void AddDepartment()
        {
            Program program = new Program();
            Console.WriteLine("Enter the name of the new department:");
            string departmentName = Console.ReadLine();
            if (program.departments.Contains(departmentName))
            {
                Console.WriteLine($"The department '{departmentName}' exists.");
            }
            else
            {
                program.departments.Add(departmentName);
                Console.WriteLine($"Department '{departmentName}' added successfully.");
            }
            Console.WriteLine("Enter the name of the doctor to assign to this department:");
            string doctorName = Console.ReadLine();
            if (program.doctors.ContainsKey(doctorName))
            {
                Console.WriteLine($"Doctor {doctorName} is already assigned to a department.");
            }
            else
            {
                program.doctors.Add(doctorName, departmentName);
                Console.WriteLine($"Doctor {doctorName} assigned to department '{departmentName}' successfully.");
            }
        }

        public static void AdmitPatient()
        {
            Program program = new Program();
            Console.WriteLine("Enter the name of the doctor within ken,jose,mathew:");
            string doctorName = Console.ReadLine();
            Console.WriteLine("Enter the name of the patient:");
            string patientName = Console.ReadLine();
            program.patients[doctorName].Add(patientName, "admitted");
            Console.WriteLine("Patient admitted succesfully");
        }
        public static void DoctorsinDepartment()
        {
            Program program = new Program();
            Console.WriteLine("Enter the name of the department:");
            string departmentName = Console.ReadLine();
            if (!program.departments.Contains(departmentName))
            {
                Console.WriteLine($"Department '{departmentName}' does not exist.");
                return;
            }
            Console.WriteLine($"Doctors in the '{departmentName}' department:");
            foreach (var doctor in program.doctors)
            {
                if (doctor.Value == departmentName)
                {
                    Console.WriteLine(doctor.Key);
                }
            }

        }
        public static void PatientsAndDoctors()
        {
            Program program = new Program();
            Console.WriteLine("Enter the name of the doctor:");
            string doctorName = Console.ReadLine();
            foreach (var patient in program.patients[doctorName])
            {
                Console.WriteLine($"Patient: {patient.Key}, Status: {patient.Value}");
            }
        }
        public static void DischargePatient()
        {
            Program program = new Program();
            Console.WriteLine("Enter the name of the doctor:");
            string doctorName = Console.ReadLine();
            Console.WriteLine("Enter the name of the patient to discharge:");
            string patientName = Console.ReadLine();


        }

    }
}
