﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementProblem
{
    internal interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }
}
