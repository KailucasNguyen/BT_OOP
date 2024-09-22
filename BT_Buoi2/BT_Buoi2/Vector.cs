using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi2
{
    abstract class Vector
    {
        public abstract string ShowInfo();
        public abstract Vector Sum(Vector v);
        public abstract bool Orth(Vector v);
    }
}
