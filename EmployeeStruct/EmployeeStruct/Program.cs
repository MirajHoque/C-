using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeStruct
{
    struct OurDate //structure
    {
        public string day; //struct variable
        public string month;  //struct variable
        public string year;  //struct variable
    }
    class Employee //class name
    {

        public string name; //class variable
        public double salary;  //struct variable
        public OurDate dob;
        public Employee()
        {
            //default constructor
        }
        public Employee(string n, double sal, OurDate dob)  //parameterized Constructor
        {
            this.name = n;
            this.salary = sal;
            this.dob = dob;
        }
        public void setName(string n)  //setter method for name
        {
            this.name = n;
        }
        public void setSalary(double sal)  //setter method for salary
        {
            this.salary = sal;
        }
        public void setDateOfBirth(OurDate dob)
        {
            this.dob = dob;
        }
        public string getName()  //getter method for name
        {
            return this.name;
        }
        public double getSalary()  //getter method for  salary
        {
            return this.salary;
        }
        public void showDateOfBirth() //show method
        {
            Console.WriteLine(dob.day + " " + dob.month + " " + dob.year);
        }

        public void EmployeeInformation()  //dislapying employee information
        {
            Console.WriteLine("Employee name:" + this.name);
            Console.WriteLine("Employee salary:" + this.salary);
            showDateOfBirth();
            //Console.WriteLine("Employee date of birth:"+ OurDate);
        }

        static void Main(string[] args)
        {
            OurDate d1, d2; //STRUCTURE OBJECT
            d1.day = "10";
            d1.month = "January";
            d1.year = "1990";
            d2.day = "20";
            d2.month = "February";
            d2.year = "1996";
            Employee e1 = new Employee("Mark", 1000000, d1);
            e1.EmployeeInformation();
            Console.WriteLine("\n");
            Employee e2 = new Employee();
            e2.setName("Bill");
            e2.setSalary(100000000);
            e2.getName();
            e2.getSalary();
            e2.setDateOfBirth(d2);
            e2.EmployeeInformation();
           


        }
    }
}

