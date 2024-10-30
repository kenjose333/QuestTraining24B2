using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementProblem
{
    internal class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _discountPercentage = 2;

        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - (totalAmount * _discountPercentage / 100);
    }
}
