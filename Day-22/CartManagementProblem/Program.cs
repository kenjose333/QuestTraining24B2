using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
                var cart = new Cart();
                cart.Add(new CartItem { Name = "Item 1", Price = 100, Quantity = 2 });
                cart.Add(new CartItem { Name = "Item 2", Price = 200, Quantity = 3 });
                cart.Add(new CartItem { Name = "Item 3", Price = 300, Quantity = 4 });

                var discountStrategy = new PercentageDiscountStrategy();
                var billingService = new BillingService(discountStrategy);
                var totalAmount = billingService.CalculateTotalAmount(cart.GetAll());
                Console.WriteLine($"Total amount: {totalAmount}");
          
        }
    }
}
