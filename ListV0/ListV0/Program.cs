using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListV0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            mylist.Add(0);
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(5);
            mylist.Insert(4, 4);
            mylist.Add(5);
            mylist.Add(5);
            mylist.Add(5);
            //mylist.Remove(5);
            mylist.RemoveAt(0);
            mylist.RemoveAll(item => item ==5);

        foreach(int elements in mylist)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine();
            Console.WriteLine("After Reverse");
            mylist.Reverse();
            foreach(int elements in mylist)
            {
                Console.WriteLine(elements);
            }

        }
    }
}
