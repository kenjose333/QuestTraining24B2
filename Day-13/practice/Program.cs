﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Student s = new Student();
            s.Name = "ken";
            s.DisplayName();
            Console.WriteLine(s.GetSum(10,20));


        }
    }
}