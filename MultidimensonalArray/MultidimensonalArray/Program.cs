using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensonalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2d = new int[,]
            {
                {4,6 },{7,8},{9,10}
            };
            int count = 0;
            for (int row = 0; row < array2d.GetLength(0); row++)
               // Console.WriteLine();
            {
               Console.WriteLine();
                for (int column=0; column<array2d.GetLength(1); column++)
                {
                    Console.Write(array2d[row, column] +"\t");
                   
                    count++;
                   
                }
                }
            Console.WriteLine("\n");
           Console.WriteLine("total elements in the array :"+" " + count);
            Console.ReadKey();
            
           
        }
    }
}
