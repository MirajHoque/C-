using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmPractrise
{
    class Program
    {

        static void Main(string[] args)
        {
            /* int[][] jaggedArray = new int[3][];
             jaggedArray[0]=new int[]{1,2,3,4,5};
             jaggedArray[1] =new int[] {1,5,2};
             jaggedArray[2 ]=new int[]{4,5,6,8};
             */
            int[] array = new int[3];
                array[0]={ 1,2,3};
           /* int[,] array2d = new int[,]
                {
                     {4,6 },{7,8},{9,10}
                };
            int count;
            count = 0;
            for (int row = 0; row < array2d.GetLength(0); row++)
            {
                Console.WriteLine();
                for (int column = 0; column < array2d.GetLength(1); column++)
                {
                    // Console.WriteLine();
                    Console.Write(array2d[row, column] + "\t");
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(count);
            // System.Console.WriteLine("hello");

            /* Int32 d;
             d = 5;
             float a;
             a = 5.5f;
             //float a=10.25f;
             //float x;
             //x=5.25f;
             //int c = 10;
             */
        }
    }
}
