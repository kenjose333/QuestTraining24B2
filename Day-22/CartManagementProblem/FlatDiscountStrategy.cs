using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementProblem
{
    internal class FlatDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - 200;
    }
}
