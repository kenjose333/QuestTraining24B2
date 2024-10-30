using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoProgramingServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serverBuilder = new ServerBuilder();
            serverBuilder.Run(res =>
            {
                Console.WriteLine(res);
            });
            serverBuilder.ShutDown();
        }
    }
}
