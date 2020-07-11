using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversion
            int x = 5;
            string y="5";
            //int result=x+y;
            int result = x + Convert.ToInt32(y);
            Console.WriteLine(result);
            
            
            //CASTING EXPLICIT data is lost

            double a = 200.25;
            int b = 10;
            int result1 = (Int32)a + b;
            Console.WriteLine(result1);

            //CASTING IMPLICIT  no data lost
            int i = 100;
            int k = 400;
            double result2 = i + k;
            Console.WriteLine(result2);
        }
    }
}
