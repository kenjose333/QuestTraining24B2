﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise2
{
    internal interface Istudent
    {
        string Name { get; }
        void Display();
    }
    class SchoolStudent : Istudent
    {
        public string Name { get; set; }
        public void Display()
        {
            Console.WriteLine("hello");
        }
    }
}