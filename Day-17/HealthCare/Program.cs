using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HealthCare;

namespace LearnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new HealthCareManager().ListUpcomingAppontmentsInNextSevenDays();
        }
    }
}
