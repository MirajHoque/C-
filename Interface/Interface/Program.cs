using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction t = new Transaction();
            t.Balance = 500;
            t.deposit(5000);
            t.withDraw(200);
        }
    }
}
