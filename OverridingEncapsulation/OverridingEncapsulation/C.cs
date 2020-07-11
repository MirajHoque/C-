using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEncapsulation
{
    class C:A
    {
        public C()
        {
            Console.WriteLine("Default constructor for C");
        }
        public new void printSomething()
        {
            Console.WriteLine("you are old enough! get ready for die");
        }
    }
}
