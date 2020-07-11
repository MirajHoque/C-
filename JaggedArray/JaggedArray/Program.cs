using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            
             jaggedArray[0] =new int[] {1,3,5,7,9};
            jaggedArray[1] = new int[] { 2, 4, 6, 8 };
            jaggedArray[2] = new int[] { 2, 1, 0 };



            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Elements ({0}):",i+1);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}
