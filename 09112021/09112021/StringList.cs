using System;
using System.Collections.Generic;
using System.Text;

namespace _09112021
{
    class StringList
    {
        string[] _arr = new string[0];

        public void Add(string item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }

        public string FindByIndex(int index)
        {
            return _arr[index];
        }

        public int Count { get => _arr.Length; }

    }
}
