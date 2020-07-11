using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForStructure
{
    struct Car
    {
        public string brand;
        public string model;
        public int year;
        public double price;
        public Car(string b,string m,int y,double p)
        {
            this.brand = b;
            this.model = m;
            this.year = y;
            this.price = p;

        }
        public void CarDetails()
        {
            Console.WriteLine("Brand Name : " + this.brand);
            Console.WriteLine("Model Name : " + this.model);
            Console.WriteLine("Year Model : " + this.year);
            Console.WriteLine("Car Price : " + this.price);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("AUDI","A9",2018,455.10);
            c.CarDetails();

        }
    }
}
