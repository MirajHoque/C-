using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {

        static void Main(string[] args)
        {
            int age = 20;
            switch (age)
            {
                case 20:
                    // Console.ReadLine(age);
                    Console.WriteLine(" you are not old");
                    break;
                case 40:
                    Console.WriteLine("you are not that much old");
                    break;
                case 60:
                    Console.WriteLine("you are that much old");
                    break;
                default:
                    Console.WriteLine("not valid");
                    break;
            }
            // return 0;
        }
    }
}
