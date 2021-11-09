using System;
using System.Collections.Generic;
using System.Text;

namespace _09112021
{
    class MyList<T> where T: new()
    {
        T[] _arr = new T[0];

        public void Add(T item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }

        public T FindByIndex(int index)
        {
            return _arr[index];
        }

        public int Count { get => _arr.Length; }
    }
}
