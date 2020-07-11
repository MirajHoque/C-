using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        public static void printArray(string[] array)
        {
            foreach (string elements in array)
            {
                Console.Write(elements);
            }
            Console.WriteLine();
        }
        public static void changeArray(string[] array)
        {

           array = (array.Reverse()).ToArray();
            foreach(string elements in array)
            {
                Console.Write(elements);
            }
                //
            
           Console.WriteLine();
        }
        public static void changeArrayElements(string [] array)
        {
            foreach(string elements in array)
            {
                Console.Write(elements);
            }
            Console.WriteLine();
        }
        public static void addElementsArray( string [] array)
        {
            

            foreach (string elements in array)
            {
                Console.Write(elements);
            }
            Console.WriteLine();

        }
        static void Main(string[] args)

        {
            string[] arr = new string[]
            {
                "a","b","c"
            };
            /* // Program.printArray(arr);
             // Program.changeArray(arr);
             // Program.addElementsArray(arr);


              //Console.WriteLine();
              string[] family = new string[] { "father","MOTHER","children"};
              foreach(string elemnts in family)
              {
                  Console.WriteLine(elemnts);
              }
             */
            //array using for each
            /* int[] add = new int[] { 1, 2, 3, 4, 5 };
             foreach(int elements in add)
             {
                 Console.WriteLine(elements + elements);
             }
             //array using for loop
             int[] something = new int[] { 5, 6, 7, 8 };
             for(int i=0;i<something.Length;i++)
             {
                 Console.WriteLine(something[i]);
             }
             */
            //nested for loops
            /*int i,j;
            
            for( i=0;i<5;i++)
            {
                for(j=0; j<=i;j++)
                {
                    Console.Write("a");
                }
                Console.WriteLine();
            }
            */
            //Multidimensional Array00

            int[,] mulArray = new int[,] { 
                {1,2,3 },{ 4,5,6}
            };
            for (int i = 0; i <= mulArray.GetUpperBound(0); i++)
                for (int j = 0; j<=mulArray.GetUpperBound(1); j++)
                {
                    Console.Write(mulArray[i,j]+"\t");
                }
            Console.WriteLine();
        }
    }
}
