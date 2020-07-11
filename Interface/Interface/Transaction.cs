using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Transaction: Interface1

    {
        public double Balance { get; set; }


        public double deposit(double Balance)
        {
            if (Balance >= 500)
            {
                 Console.Write("current balance");
                 Balance += Balance;
                Console.WriteLine(Balance);
            }
            else
                
                Console.WriteLine("Insufficient amount to deposit");
            
        }
       public double withDraw(double Balance)
        {
            if (Balance >= 0)

            {
              //  Console.Write("current balance");

                Balance = Balance - Balance;
                Console.Write(Balance);

            }
            else
                Console.WriteLine("withdraw is invalid");
        }
        //  int transfer(double Bonus);
    }
}
