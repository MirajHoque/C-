using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsV0
{
    class GenericsTest<s,t>
    {
        public bool compare(s a, s b)
        {
            if (a.Equals(b))
                return true;
            else
            return false;
        }
    }
}
