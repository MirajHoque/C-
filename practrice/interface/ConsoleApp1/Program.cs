using System;

namespace ConsoleApp1
{
    class Program:Interface2
    {
         public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.add(10, 10);
            ob.sub(10, 10);

            //Console.WriteLine("Hello World!");
        }
    }
}
