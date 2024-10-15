using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Operation
    {
        private int Num1;
        private int Num2;
        public void Addition()
        {
            Console.WriteLine($"The sum of two numbers are {Num1+Num2}");
        }
        public void Subtraction()
        {
            Console.WriteLine($"The diff of two numbers are {Num1 - Num2}");
        }
        public void Multiplication()
        {
            Console.WriteLine($"The product of two numbers are {Num1 * Num2}");
        }
        public void Division()
        {
            Console.WriteLine($"The quotient of two numbers are {Num1 / Num2}");
        }
        public void run()
        {
            Console.WriteLine("enter the first number:");
            Num1 = int.Parse( Console.ReadLine() );
            Console.WriteLine("Enter the second number:");
            Num2 = int.Parse( Console.ReadLine() );
            Addition();
            Subtraction();
            Multiplication();
            Division();

        }
    }
}
