using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfism
{
    class A
    {
        public string Description()
        {
            return "The object is of type A";
        }
    }

    class B : A
    {
        public new string Description()
        {
            return "Objectet är av typen B";
        }
    }
}
