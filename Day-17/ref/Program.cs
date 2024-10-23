﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefProblem
{
    internal class Program
    {
        static bool TrimToFiveChars(ref string data)
        {
            if (data.Length > 5)
            {
                data = data.Substring(0,5);
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string text = "Old data";
            if(TrimToFiveChars(ref text))
            {
                Console.WriteLine(text + "....");
            }
            else
            {
                Console.WriteLine(text);  
            }
        }
    }
}
