using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qui2p
{
    class Program
    {
        public void airthmeticOperations(int a,int b,ref int c,ref int d)
        {
            c = a * b;
            d= a + b;

        }
        public int airthmeticOperationsV2( ref int x,ref int y)
        {
            return x;
            return y;
        }
        public void airthmeticOperationsV3(int a, int b, out int c, out int  d)
        {
            c = a * b;
            d = a + b;
        }
        static void Main(string[] args)
        {
            int c= 0;
            int d= 0;
            int x, y;
            int i = 0, k = 0;
            Program p = new Program();
            Program p0 = new Program();
            Program p1 = new Program();
            p.airthmeticOperations(5, 5,ref c, ref d);
            Console.WriteLine(c + " " + d);
            ;
            p.airthmeticOperationsV2(ref c, ref d);
            Console.WriteLine(i+""+k);
            p.airthmeticOperationsV3(5, 5,out x,out y);
            Console.WriteLine(c + " " + d);
        }
    }
}
