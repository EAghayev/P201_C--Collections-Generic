using System;
using System.Collections.Generic;
using System.Text;

namespace _09112021
{
    class PhoneBook<TPhone,TName>
    {
        TPhone[] _phones = new TPhone[0];
        TName[] _names = new TName[0];

        public void Add(TPhone phone,TName name)
        {
            Array.Resize(ref _phones, _phones.Length + 1);
            _phones[_phones.Length - 1] = phone;

            Array.Resize(ref _names, _names.Length + 1);
            _names[_names.Length - 1] = name;
        }

        public TName GetName(TPhone phone)
        {
            int index = -1;
            for (int i = 0; i < _phones.Length; i++)
            {
                if(_phones[i].Equals(phone))
                {
                    index = i;
                }
            }

            if (index > -1) return _names[index];

            throw new Exception("Data not found");
        }

       
    }
}
