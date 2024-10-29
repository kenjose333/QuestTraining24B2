using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            try
            {
                Console.Write("enter num1");
                int i = int.Parse(Console.ReadLine());
                Console.Write("enter num2");
                int j = int.Parse(Console.ReadLine());
                int sum = i + j;
                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                log.Error(e.StackTrace);
            }
        }
    }
}