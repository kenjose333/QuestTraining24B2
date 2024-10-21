using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    abstract class CalculatorBase
    {
        public void add(int a, int b) => Console.WriteLine(a+b);
        public void Substract(int a, int b) => Console.WriteLine(a-b);
        public void Multiply(int a, int b) => Console.WriteLine(a * b);
        public virtual void Divide(int a) => Console.WriteLine(a/b);
        public abstract void Power(int a, int b);
    }
    class Calculator : CalculatorBase
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
