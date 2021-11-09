using System;
using System.Collections.Generic;
using System.Text;

namespace _09112021
{
    class DoubleList
    {
        double[] _arr = new double[0];

        public void Add(double item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }

        public double FindByIndex(int index)
        {
            return _arr[index];
        }

        public int Count { get => _arr.Length; }
    }
}
