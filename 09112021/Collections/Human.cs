using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Human
    {
        public string Name;
        public string Surname;

        public override string ToString()
        {
            return this.Name + " " + this.Surname;
        }
    }
}
