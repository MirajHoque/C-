using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student:Person
    {
        double cgpa;
        public double CGPA { get; set; }
        public void StudentInformation()
        {
            showInformation();
            Console.WriteLine(this.CGPA);
        }
    }
    

    }

