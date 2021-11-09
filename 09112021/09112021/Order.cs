using System;
using System.Collections.Generic;
using System.Text;

namespace _09112021
{
    class Order
    {
        static int _totalCount;
        public Order()
        {
            _totalCount++;
            No = 1000 + _totalCount;
        }
        public int No;
        public double Price;


    }
}
