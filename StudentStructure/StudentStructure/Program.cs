using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStructure
{
    struct DOB
    {
        public string day; //struct variable
        public string month;  //struct variable
        public string year;  //struct variable
    }

    class Student
    {
        public string name; //class variable
        public double salary;  //struct variable
        public DOB dob;
        public Student()
        { }
        public string Name { set; get; }
        public double Salary { set; get; }
        public DOB Dob { set; get; }
        public void ShowDate()
        {
            Console.WriteLine(dob.day + " " + dob.month + " " + dob.year);
        }
        public void StudentInfo()
        {

            Console.WriteLine(this.Name);
            Console.WriteLine(this.Salary);
            ShowDate();
          // Console.WriteLine(ShowDate());
        }
        static void Main(string[] args)
        {
            DOB d1;
            d1.day = "20";
            d1.month = "april";
            d1.year = "1996";
            Student s1=new Student();
            //s1.Name = "miraj";
            //s1.Salary = 100000;
            //s1.Dob = "10 april 1996";
            //s1.StudentInfo();
            s1.ShowDate();

        }
    }
}
