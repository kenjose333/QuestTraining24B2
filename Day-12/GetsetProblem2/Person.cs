using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetsetProblem2
{
    internal class Person
    {
        public string name { get; set; }
        public string email { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
