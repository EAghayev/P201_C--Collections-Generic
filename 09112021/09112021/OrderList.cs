using System;
using System.Collections.Generic;
using System.Text;

namespace _09112021
{
    class OrderList
    {
        Order[] _orders = new Order[0];

        public void Add(Order order)
        {
            Array.Resize(ref _orders, _orders.Length + 1);
            _orders[_orders.Length - 1] = order;
        }

        public Order FindByIndex(int index)
        {
            return _orders[index];
        }

        public int Count { get => _orders.Length; }
        
    }
}
