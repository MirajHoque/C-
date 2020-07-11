using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static double sinc(double x)
        {
         return    x!=0.0 ? Math.Sin(x) / x : 1.00;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sinc(0.0));
        }
    }
}
