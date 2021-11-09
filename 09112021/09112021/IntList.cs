using System;
using System.Collections.Generic;
using System.Text;

namespace _09112021
{
    class IntList
    {
        int[] _arr = new int[0];

        public void Add(int item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }

        public int FindByIndex(int index)
        {
            return _arr[index];
        }

        public int Count { get => _arr.Length; }
    }
}
