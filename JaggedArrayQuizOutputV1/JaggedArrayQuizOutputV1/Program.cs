using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayQuizOutputV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int[][] myja = new int[4][];
            myja[0] = new int[6] { 1, 2, 3, 4, 5, 6 };
            myja[3] = new int[1];
            myja[1] = new int[2] { 2, 3 };
            myja[2] = new int[6] { 6, 4, 2, 1, 3, 5 };
            for(int i=0;i<myja[0].Length;i++)
            {
                myja[3][c] += myja[0][i];
            }
            Console.WriteLine(myja[3][c]);
            for (int i = 0; i < myja[2].Length; i++)
            {
                myja[3][c] += myja[0][i] + myja[2][i];
            }
            Console.WriteLine(myja[3].Length);
            Console.WriteLine(myja[3][c]);
            Console.WriteLine(myja[3][c]+myja[1][1]);
        }
    }
}
