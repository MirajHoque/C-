using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    { //int a=2, b=3, c=4;
        public int Addition(int a, int b)
        {
            int result;
            return result = a + b;
        }
        public int Addition(int a, int b, int c)
        {
            int result;
            return result = a + b + c;
        }
        public float Addition(float a, float b)
        {
            float result;
            return result = a + b;
        }
        public float Addition(float a, float b, float c)
        {
            float result;
            return result = a + b + c;
        }

        static void Main(string[] args)
        {
            Program P1 = new Program();
            Console.WriteLine( P1.Addition(2,3));
            Console.WriteLine( P1.Addition(2, 3, 4));
            Console.WriteLine( P1.Addition(2.5f, 2.5f));
            Console.WriteLine( P1.Addition(2.5f, 2.5f, 2.5f));
            // Console.WriteLine(P1.Addition);
        }
    }
}

