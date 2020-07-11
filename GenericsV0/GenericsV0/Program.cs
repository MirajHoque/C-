using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsV0
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericsTest<int, double> gt = new GenericsTest<int, double>();
            bool result = gt.compare(10, 10);
            Console.WriteLine(result);
            /* GenericsTest<int,double> gt = new GenericsTest<int,double>();
             bool result = gt.compare(10, 10.0);
             Console.WriteLine(result); 
             /*   GenericsTest<int> gt = new GenericsTest<int>();
               bool result= gt.compare(10, 10);
                Console.WriteLine(result);
                GenericsTest<double> dgt = new GenericsTest<double>();
                bool result1 = dgt.compare(10.20, 10.30);
                Console.WriteLine(result1);*/

        }
    }
}
