using System;

namespace EncapsulationPublic
{
    class Program
    {
        static void Main(string[] args)
        {
            AirthmeticOperation ob = new AirthmeticOperation();
            ob.add(5, 5);
            ob.print();
           // Console.WriteLine("Hello World!");
        }
    }
}
