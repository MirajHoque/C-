using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAsArgument
{
    class ArrayAsArgument
    {
     public static void PrintArray(string [] array ) //static method which print an array
        {
            foreach( string elements in array)
            {
                Console.Write(elements);
            }
            Console.WriteLine();

        }
      public  static void ChangeArray(string [] array) //reverse an elements
            {
            array= (array.Reverse()).ToArray();
            // Console.Write(array[0]+""+ array[1]+""+ array[2]+""+ array[3]);
            Console.Write(array[0] + "\n");
            
            //Console.Write(array[0]);
            Console.WriteLine();
        }
       public static void reverseArray(string[] array)
        {
            Array.Reverse(array);
            foreach (string elements in array)
            {
                Console.Write(elements);
            }
            
           Console.WriteLine();
        }
        
      public static void ChangeArrayElements(string[] array) //changing particular elements
        {
            array[0] = "e";
            array[1] = "f";
            Console.Write("elements added at index 0 & 1 are " + array[0]+" &"+array[1]);
            
            
            Console.WriteLine();
        }
        public static void presentArrayElements(string[] array)
        {
            Console.Write("elements in array's are: ");
            foreach(string elements in array)
            {
                Console.Write(elements);
            }
            Console.WriteLine();
        }
       public static void addElementsInArray(string [] array) //add some value
        {
            
            foreach(string elements in array)
                for (int i = 0; i < array.Length; i++)
                {
                   // array[i] = array[i];
                    Console.Write(array[i]);
                }
            /*  {

                  Console.WriteLine(elements + elements );
              }*/
        }
        
        static void Main(string[] args)
        {
            string[] arr = new string[]
            {
              "a","b","c","d"
            };
            
           ArrayAsArgument.PrintArray(arr);
           ArrayAsArgument.ChangeArray(arr);
           ArrayAsArgument.reverseArray(arr);
           ArrayAsArgument.ChangeArrayElements(arr);
            ArrayAsArgument.presentArrayElements(arr);
         
            ArrayAsArgument.addElementsInArray(arr);

           ArrayAsArgument.reverseArray(arr);



        }
    }
}
