using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStructure
{
    struct Car
    {
      public string brand;
      public string model;
       public double price;
        public void carInformation()
        {
            Console.WriteLine(brand);
            Console.WriteLine(model);
            Console.WriteLine(price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c1;
            c1.brand = "AUDI";
            c1.model = "A9";
            c1.price = 45000;
            c1.carInformation();
        }
    }
}
