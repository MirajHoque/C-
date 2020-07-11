using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationPublic
{
    class AirthmeticOperation
    {
        public int sum;
        //public int a=5,b=5;
        public int add(int a, int b)
        {
            sum = a + b;
            return sum;
           
        }
        public void print()
        {
            Console.WriteLine(sum);
        }

    }
}
