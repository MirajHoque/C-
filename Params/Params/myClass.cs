using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
          int addition(params int[] numbers)
            {
                int sum = 0;
                foreach(int elements in numbers)
                {
                    sum += elements;
                    //Console.WriteLine()
                }
                return sum;

            }
            Console.WriteLine(addition(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.WriteLine(addition(1, 2, 3));
            Console.WriteLine(addition(1, 4, 5));


        }
    }
}
