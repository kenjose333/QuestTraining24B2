using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementProblem
{
    internal class BillingService
    {
        private readonly IDiscountStrategy _discountStrategy;

        public BillingService(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotalAmount(List<CartItem> cartItems)
        {
            var totalAmount = cartItems.Sum(i => i.TotalPrice);
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }
}
