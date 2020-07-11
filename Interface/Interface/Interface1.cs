using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Interface1
    {
        double Balance { get; set; }
        double deposit(double Balance);
        double withDraw(double Balance);
       // int transfer(double Balance);
    }
}
