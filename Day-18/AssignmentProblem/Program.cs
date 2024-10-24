using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProblem
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalCondition { get; set; }
    }
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int PatientId { get; set; }
    }
    public class PatientRepository
    {
        public string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\91859\\Documents\\Exam.mdf;Integrated Security=True;Connect Timeout=30";
        public PatientRepository()
        {
            CreatePatientsTable();
        }
        public void CreatePatientsTable()
        {
            var createTableQuery = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Patients' AND xtype='U')
                             CREATE TABLE Patients(
                             Id INT PRIMARY KEY IDENTITY,
                             Name VARCHAR(50) NOT NULL,
                             Age INT NOT NULL,
                             Gender VARCHAR(50) NOT NULL,
                             MedicalCondition VARCHAR(50) NOT NULL
                             )";

            using (var conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(createTableQuery, conn);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
            }
        }
        public void AddPatient(Patient patient)
        {
            string query = "INSERT INTO Patients(Name, Age,Gender,MedicalCondition) VALUES (@Name,@Age,@Gender,@MedicalCondition)";
            using (var conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("@Gender", patient.Gender);
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
            }
        }

        public Patient SearchByName(string input)
        {
            var query = "SELECT * FROM Patients WHERE Name =@Input";
            using (var conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Input", input);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Patient
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Age = reader.GetInt32(2),
                            Gender = reader.GetString(3),
                            MedicalCondition = reader.GetString(4)
                        };
                    }
                }
            }
            return null;
        }

        public void UpdatePatient(Patient patient)
        {
            string query = "UPDATE Patients SET Name = @Name,Age = @Age, Gender = @Gender,MedicalCondition =@MedicalCondition";
            using (var conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("Gender", patient.Gender);
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
            }
        }
        public void DeletePatient(int Id)
        {
            string query = "DELETE FROM Patients WHERE Id = @Id";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id", Id);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
            }
        }
    }
    public class DoctorRepository
    {
        public string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\91859\\Documents\\Exam.mdf;Integrated Security=True;Connect Timeout=30";
        public DoctorRepository()
        {
            CreateDoctorsTable();
        }
        //Dr
        public void CreateDoctorsTable()
        {
            var createTableQuery = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Doctors' AND xtype='U')
                             CREATE TABLE Doctors(
                             Id INT PRIMARY KEY IDENTITY,
                             Name VARCHAR(50) NOT NULL,
                             Specialization VARCHAR(50) NOT NULL,
                             PatientId  INT NOT NULL
                             )";

            using (var conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(createTableQuery, conn);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
            }
        }
        public void AddDoctor(Doctor doctor)
        {
            string query = "INSERT INTO Doctors(Name, Specialization,PatientId) VALUES (@Name,@Specialization,@PatientId)";
            using (var conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", doctor.Name);
                command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                command.Parameters.AddWithValue("@PatientId", doctor.PatientId);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
            }
        }

        public Doctor SearchBydrName(string input)
        {
            var query = "SELECT * FROM Doctors WHERE Name =@Input";
            using (var conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Input", input);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Doctor
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Specialization = reader.GetString(2),
                            PatientId = reader.GetInt32(3)
                        };
                    }
                }
            }
            return null;
        }
        public void UpdateDoctor(Doctor doctor)
        {
            string query = "UPDATE doctors SET Name = @Name,Specialization = @Specialization, PatientId = @PatientId";
            using (var conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", doctor.Name);
                command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                command.Parameters.AddWithValue("@PatientId", doctor.PatientId);

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
            }
        }

        public void DeleteDoctor(int Id)
        {
            string query = "DELETE FROM Doctors WHERE Id = @Id";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id", Id);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
            }
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PatientRepository repository = new PatientRepository();
            repository.AddPatient(new Patient { Name = "ken", Age = 22, Gender = "M", MedicalCondition = "fever" });
            var patient = repository.SearchByName("ken");
            if (patient != null)
            {
                Console.WriteLine($"Name : {patient.Name}, Age : {patient.Age}, Gender : {patient.Gender}, MedicalCondition : {patient.MedicalCondition}");
                patient.Name = "jose";
                repository.UpdatePatient(patient);
                Console.WriteLine("patient updated");
                repository.DeletePatient(patient.Id);
                Console.WriteLine("Patient deleted");
            }
            else
            {
                Console.WriteLine("patient not found");
            }
            DoctorRepository repositoryy = new DoctorRepository();
            repositoryy.AddDoctor(new Doctor { Name = "mathew", Specialization = "cardiology", PatientId = 2 });
            var doctor = repositoryy.SearchBydrName("mathew");
            if (doctor != null)
            {
                Console.WriteLine($"Name : {doctor.Name},Specialization : {doctor.Specialization},PatientId : {doctor.PatientId}");
                doctor.Name = "joel";
                repositoryy.UpdateDoctor(doctor);
                Console.WriteLine("doctor updated");
                repositoryy.DeleteDoctor(doctor.Id);
                Console.WriteLine("doctor deleted");
            }
            else
            {
                Console.WriteLine("doctor not found");

            }
        }
    }
}
