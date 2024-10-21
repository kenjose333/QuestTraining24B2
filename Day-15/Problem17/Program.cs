using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18
{
    internal class Program
    {
        class Products
        {
            public string Product { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            var products = new List<Products>
            {
                new Products{Product = "Bourbon", Price = 20},
                new Products{Product = "Hide and Seek", Price = 30},
                new Products{Product = "Nice", Price = 110},
                new Products{Product = "Dark Fantasy", Price = 160},
                new Products{Product = "Milano", Price = 165}
            };

            var g100 = products.Where(x => x.Price > 100).OrderBy(x => x.Price);
            foreach (var g in g100)
            {
                System.Console.WriteLine($"Product : {g.Product}    Price : {g.Price}");
            }

        }
    }
}
