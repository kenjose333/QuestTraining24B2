using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementProblem
{
    internal class Cart
    {
        private readonly List<CartItem> _items = new List<CartItem>();

        public void Add(CartItem item)
        {
            var existingItem = _items.FirstOrDefault(i => i.Name == item.Name);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                _items.Add(item);
            }
        }

        public void Remove(string productName)
        {
            _items.RemoveAll(i => i.Name == productName);
        }

        public List<CartItem> GetAll() => _items;
    }
}

