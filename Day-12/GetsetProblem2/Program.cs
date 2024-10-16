using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetsetProblem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.name = "ken";
            p.email = "kenjose333@gmail.com";
            p.Addresses.Add(new Address { AddressType = "home", AddressLine1 = "changanassery", AddressLine2 = "kottayam", Pincode = "101" });
        }
    }
}
