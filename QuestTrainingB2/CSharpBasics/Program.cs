using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Program
    {
        static int AddWithReturn(int num1,int num2)=> num1+num2;
        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation to be performed from + , - , * , /  ");
            char op = Console.ReadLine()[0];
            switch (op)
            {
                case '+' :
                    Console.WriteLine(AddWithReturn(num1, num2));
                    break;
                case '-' :
                    Console.WriteLine(Sub(num1, num2));
                    break;
                case '*':
                    Console.WriteLine(Mul(num1,num2));
                    break;
                case '/':
                    Console.WriteLine(Div(num1 ,num2));
                    break;
                default :
                    Console.WriteLine("Enter a valid expression");
                    break;
                    

            }
        }
    }
}
