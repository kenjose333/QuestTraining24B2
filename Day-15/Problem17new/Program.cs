﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17new
{
    class Employee
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
                new Department{Id = 1,Name = "Dpt 1"},
                new Department{Id = 2,Name = "Dpt 2" }
            };
            var employees = new List<Employee>()
            {
                new Employee { Name = "john", DepartmentId = 1 },
                new Employee { Name = "Mary", DepartmentId = 1 },
                new Employee { Name = "jane", DepartmentId = 2 }
            };
            var empwithDepts = employees.Join(
               departments,
               e => e.DepartmentId,
               d => d.Id,
               (e, d) => new
               {
                   EmployeeName = e.Name,
                   DepartmentName = d.Name
               }
               );
            foreach(var item in empwithDepts)
            {
                Console.WriteLine(item.EmployeeName+"-"+item.DepartmentName);
            }

        }

    }
}
