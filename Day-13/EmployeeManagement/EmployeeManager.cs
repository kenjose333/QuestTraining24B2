﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Entities;
using EmployeeManagement.Entities.Types;
using EmployeeManagement.Services;

namespace EmployeeManagement
{
    internal class EmployeeManager
    {
        private readonly IStorageService _storageService;
        public EmployeeManager(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public void Add()
        {
            var employee = new Employee();
            Console.Write("First Name: ");
            employee.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Email: ");
            employee.Email = Console.ReadLine();

            Console.Write("Employment Type: 1. Permanent 2. Contract: ");
            var employmentType = Console.ReadLine();
            employee.EmploymentType = employmentType == "1" ? EmploymentType.FullTime : EmploymentType.Contract;

            _storageService.Save(employee);
        }

        public void Remove()
        {

        }

        public void Update()
        {

        }

        public void Search()
        {

        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Search Employee");
                Console.WriteLine("3. Delete Employee");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Search();
                        break;
                    case "3":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
