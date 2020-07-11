using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    public enum days
    { saturday=2, sunday=4, monday=6};
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string elements in Enum.GetNames(typeof(days)))
        {
            Console.WriteLine(elements);
        }
        
             
            days d = 0;
            Console.WriteLine(d);
            days d1 = (days)2;
            Console.WriteLine(d1);
            days d2 = days.monday;
            Console.WriteLine((int)d2);
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("Hello World!");
        }
    }
}
