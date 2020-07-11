using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm f = new Farm();

            f[0] = "hi";
            f[1] = "Hello";
            f[2] = "OLA";
            Console.WriteLine(f[0]);
            Console.WriteLine(f[1]);
            Console.WriteLine(f[2]);

             
        }
    }
}
