using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerV3
{
    class Program
    {
        string[] names = new string[6];

        public string this[int number]
        {
            get
            {
                if (number >= 0 && number < names.Length)
                    return names[number];
                return "Error";
            }
             
        set
            {
                if (number >= 0 && number<names.Length)
                 names[number]=value;
                }
}
      static void Main(string[] args)
        {
            Program p = new Program();
            p[0] = "BABY";
            p[1] = "Hoque";
            p[2] = "Mita";
            p[3] = "Miraj";
            p[4] = "Mila";
            p[5] = "Zara";
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);
            Console.WriteLine(p[2]);
            Console.WriteLine(p[3]);
            Console.WriteLine(p[4]);
            Console.WriteLine(p[5]);
        }
    }
}
