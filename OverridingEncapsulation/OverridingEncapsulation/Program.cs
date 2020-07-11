using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEncapsulation
{
    //sealed  class A //sealed none can inherit it
     class A
    {
        public  A()
        {
            Console.WriteLine("Default constructor for A");
        }
        public virtual void printSomething()
        {
            Console.WriteLine("you are not old");
        }

        class Program
        {
            static void Main(string[] args)
            {
                A[] ob = new A[3];
               ob[0] =new B();
                ob[1] = new C();
                ob[2] = new A();
                foreach(A elements in ob)
                {
                    elements.printSomething();
                } 
            }
        }
    }
}
