using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        string name;
        //int  id;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int ID
        { set; get; }
        public void showInformation()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.ID);
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Name = "EDWARD";
            p1.ID = 1234;
            p2.Name = "SNOWDEN";
            p2.ID = 4321;
            p1.showInformation();
            p2.showInformation();
            Student s1 = new Student();
            s1.Name = "Miraj";
            s1.ID = 32444;
            s1.CGPA = 3.61;
            s1.StudentInformation();
            Employee e1 = new Employee();
            e1.Name = "MARK";
            e1.ID = 45687;
            e1.Salary = 100000000;
            e1.EmployeeInformation();
        }
    }
}
