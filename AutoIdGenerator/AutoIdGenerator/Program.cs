using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoIdGenerator
{
    class Program
    {
        public static int id = 0;
        public string name;
        public Program(string name)
        {
            this.name = name;
            id++;
        }
        static void Main(string[] args)
        {
            Program p1 = new Program("miraj");
            Program p2 = new Program("rakib");
            Console.WriteLine(p1.name + "" +id);
            Console.WriteLine(p2.name + "" + id);
        }
    }
}
