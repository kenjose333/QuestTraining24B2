using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace propblemmm
{    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public override string ToString()
        {
            return $"name : {Name} ,id : {Id}";
        }
        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new Student("jose",1);
            Console.WriteLine(obj);

        }
    }
}
