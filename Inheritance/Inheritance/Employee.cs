using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee:Person
    {
        double salary;
        public double Salary { get; set; }
        public void EmployeeInformation()
        {
            showInformation();
            Console.WriteLine(this.Salary);

        }
    }
}
