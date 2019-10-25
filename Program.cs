using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{/*
    public enum days:byte
    { SATURDAY = 2, SUNDAT = 4, MONDAY = 6, TUESDAY = 8, WEDNESDAY = 10, THURSDAY = 12, FRIDAY = 14 };*/
    public enum days{SATURDAY=2,SUNDAY=4,MONDAY=6,TUESDAY=8,WEDNESDAY=10,THURSDAY=12,FRIDAY=14 };
    class Program
    {
        static void Main(string[] args)
        {
          /* foreach( int elements in Enum.GetValues(typeof(days)))
            {
                Console.WriteLine(elements+" :"+(days)elements);
                
            }
          */
            foreach (string elements in Enum.GetNames(typeof(days)))
            {
                Console.WriteLine(elements);

            } 
            
           days d = 0;
             Console.WriteLine(d);
             days d1 = (days)2;
             Console.WriteLine(d1);
             days d2 = days.MONDAY;
             Console.WriteLine(d2);
             Console.WriteLine((Int16)d2);
             Console.WriteLine(Convert.ToInt32(d2));
             

        }
    }
}
