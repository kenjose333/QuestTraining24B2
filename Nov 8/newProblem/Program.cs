using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProblem
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point()
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y,
            };
        }
    }
    class User
    {
        public string UserName { get; set; } = "hello";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var p1 = new Point() { X = 5, Y = 2 };
            var p2 = new Point() { X = 2, Y = 1 };
            var p3 = p1 - p2;
            Console.WriteLine($"p3: X = {p3.X}, Y = {p3.Y}");
        }
    }
}
