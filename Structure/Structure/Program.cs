using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct Car
    {
        public string brand;
        public string model;
        public int year;
        public double price;
        public Car(string bName, string mName, int y,double cPrice)
        {
            this.brand = bName;
            this.model = mName;
            this.year = y;
            this.price = cPrice;
            
        }
        public void carInformation()
        {
            Console.WriteLine("Brand Name : " + this.brand);
            Console.WriteLine("Model Name : " + this.model);
            Console.WriteLine("Year Model : " + this.year);
            Console.WriteLine("Car Price : " + this.price);
            
        }

    }
    struct Ship
    {
        string shipType;
        string ShipDestination;
        double shipSpeed;
        int shipLength;

        public Ship(string sType, string sDestination,double sSpeed,int sLength)
        {
            this.shipType = sType;
            this.ShipDestination = sDestination;
            
            this.shipSpeed = sSpeed;
            this.shipLength = sLength;
        }

        public void shipDetails()
        {
            Console.WriteLine("Ship Type : " + shipType);
            Console.WriteLine("Ship Destination : " + ShipDestination);
            Console.WriteLine("Ship Length : " + shipLength + " m");
            Console.WriteLine("Ship Speed : " + shipSpeed);

        }
    }

    struct Address
    {
        int houseNumber, roadNumber, postalCode;
        string District;

        public Address(int hNumber, int rNumber, int pCode, string Dis)
        {
            this.houseNumber = hNumber;
            this.roadNumber = rNumber;
            this.postalCode = pCode;
            this.District = Dis;
        }

        public void addressDetails()
        {

            Console.WriteLine("House Number : " + this.houseNumber);
            Console.WriteLine("Road Number : " + this.roadNumber);
            Console.WriteLine("Postal Code : " + this.postalCode);
            Console.WriteLine("District : " + this.District);
        }
    }

    struct Classroom
    {

        int buildingNumber;
        int roomNumber;
        int numberOfStudents;
        int numberOfBenches;

        public Classroom(int bNum, int rNum, int sNum, int benNum)
        { 
            this.buildingNumber = bNum;
            this.roomNumber = rNum;
            this.numberOfStudents = sNum;
            this.numberOfBenches = benNum;
        }

        public void classroomDetails()
        {

            Console.WriteLine("Building Number : " + this.buildingNumber);
            Console.WriteLine("Room Number : " + this.roomNumber);
            Console.WriteLine("Number Of Students : " + this.numberOfStudents);
            Console.WriteLine("Number of Benches : " + this.numberOfBenches);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car car1=new Car("BMW", "i8", 2018,10000000.00);
            car1.carInformation();
            Console.WriteLine();
            Ship ship = new Ship("Cargo ship", "Luxembourg", 144.52,100);
            ship.shipDetails();

            Console.WriteLine();

            Address address = new Address(10, 25, 1200, "Dhaka");
            address.addressDetails();

            Console.WriteLine();

            Classroom classroom = new Classroom( 02, 5010, 40, 40);
            classroom.classroomDetails();
        }
    }
}
