using System;

namespace ArraysOfObjects
{
    class Program
    {
        int amount;
        public int salary(int amount)
        {
            this.amount = amount;
            return amount;
        }
        public void show()
        {
            salary();

        }
        static void Main(string[] args)
        {
            Program[] p = new Program[5];
            p[0].salary(20000);
            p[1].salary(25000);
            p[2].salary(30000);
            p[3].salary(40000);
            p[4].salary(50000);
            
            foreach(Program elemnts in p)
            {
                Console.WriteLine(salary(elemnts));
            }

        }
    }
}
