using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Patients = new List<Patient>()
            {
               new Patient { Id = "P001", Name = "John Doe", Age = 45, Gender = "Male", MedicalCondition = "Diabetes" },
               new Patient { Id = "P002", Name = "Jane Smith", Age = 30, Gender = "Female", MedicalCondition = "Hypertension" },
               new Patient { Id = "P003", Name = "Michael Brown", Age = 65, Gender = "Male", MedicalCondition = "Arthritis" },
               new Patient { Id = "P004", Name = "Emily Davis", Age = 50, Gender = "Female", MedicalCondition = "Asthma" },
               new Patient { Id = "P005", Name = "William Wilson", Age = 55, Gender = "Male", MedicalCondition = "Chronic Kidney Disease" },
               new Patient { Id = "P006", Name = "Olivia Martinez", Age = 25, Gender = "Female", MedicalCondition = "Migraine" },
               new Patient { Id = "P007", Name = "David Johnson", Age = 40, Gender = "Male", MedicalCondition = "Depression" },
               new Patient { Id = "P008", Name = "Sophia Garcia", Age = 35, Gender = "Female", MedicalCondition = "Thyroid Disorder" },
               new Patient { Id = "P009", Name = "James Anderson", Age = 60, Gender = "Male", MedicalCondition = "Heart Disease" },
               new Patient { Id = "P010", Name = "Charlotte Harris", Age = 28, Gender = "Female", MedicalCondition = "Allergy" }
            };
            var Appointments = new List<Appointment>()
            {
                new Appointment { Id = "A001", PatientId = "P001", DoctorName = "Dr. Alan Walker", AppointmentDate = new DateTime(2024, 10, 22, 10, 0, 0), AppointmentType = "Follow-up" },
                new Appointment { Id = "A002", PatientId = "P002", DoctorName = "Dr. Sarah Lee", AppointmentDate = new DateTime(2024, 10, 23, 14, 30, 0), AppointmentType = "Consultation" },
                new Appointment { Id = "A003", PatientId = "P003", DoctorName = "Dr. Mark Evans", AppointmentDate = new DateTime(2024, 10, 24, 11, 0, 0), AppointmentType = "Check-up" },
                new Appointment { Id = "A004", PatientId = "P004", DoctorName = "Dr. Laura Hill", AppointmentDate = new DateTime(2024, 10, 25, 9, 30, 0), AppointmentType = "Consultation" },
                new Appointment { Id = "A005", PatientId = "P005", DoctorName = "Dr. Robert Smith", AppointmentDate = new DateTime(2024, 10, 26, 13, 0, 0), AppointmentType = "Dialysis" },
                new Appointment { Id = "A006", PatientId = "P006", DoctorName = "Dr. Emily Rogers", AppointmentDate = new DateTime(2024, 10, 27, 15, 0, 0), AppointmentType = "Check-up" },
                new Appointment { Id = "A007", PatientId = "P007", DoctorName = "Dr. Michael Adams", AppointmentDate = new DateTime(2024, 10, 28, 16, 0, 0), AppointmentType = "Counseling" },
                new Appointment { Id = "A008", PatientId = "P008", DoctorName = "Dr. Anna Patel", AppointmentDate = new DateTime(2024, 10, 29, 10, 30, 0), AppointmentType = "Check-up" },
                new Appointment { Id = "A009", PatientId = "P009", DoctorName = "Dr. John Wright", AppointmentDate = new DateTime(2024, 10, 30, 11, 0, 0), AppointmentType = "Cardiology" },
                new Appointment { Id = "A010", PatientId = "P010", DoctorName = "Dr. Olivia Parker", AppointmentDate = new DateTime(2024, 10, 31, 12, 0, 0), AppointmentType = "Allergy Testing" }
            };


            //Question 1


            var details = Appointments
                .Where(a => a.AppointmentDate <= DateTime.Now.AddDays(7))
                .Join(
                    Patients,
                    a => a.PatientId,
                    p => p.Id,
                    (a, p) => new
                    {
                        Name = p.Name,
                        age = p.Age,
                        medicalcondition = p.MedicalCondition
                    }
                );
            foreach (var item in details)
            {
                Console.WriteLine($"Name:{item.Name},age:{item.age},medicalcondition:{item.medicalcondition}");
            }


            //Question2


            var groups = Patients.GroupBy(p => p.MedicalCondition);
            foreach (var Group in groups)
            {
                Console.WriteLine($"{Group.Key} - {Group.Count()}");
            }

            //Question4

            var output = Patients.Where(p => p.Age > 60)
                .Join(
                    Appointments,
                    p => p.Id,
                    a => a.PatientId,
                    (p, a) => new
                    {
                        Name = p.Name,
                        DoctorsName = a.DoctorName,
                        Date = a.AppointmentDate,
                        type = a.AppointmentType,
                    }
                );
            foreach (var item in output)
            {
                Console.WriteLine($"PatientName:{item.Name},DoctorsName:{item.DoctorsName},Date:{item.Date},Type:{item.type}");
            }
        }
    }
}
