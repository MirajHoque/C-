using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] array = new int[5];
             array[0] = 5;
             array[1] = 100;
             array[2] = 200;
             array[3] = 45;
             array[4] = 60;
             */
            string [] array = new string[] { "Mark", "Bill", "Steve", "Adward", "Julian" };

            foreach(string elements in array)
            {
                Console.WriteLine(elements + " ");
            }






        }
    }
}
