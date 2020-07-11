using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        string name;
        double cgpa;
        public string Name { get; set; }//AUTO IMPLEMENTED
        public double CGPA
        {
            get
            {
                if (cgpa > 0)
                    Console.WriteLine(this.cgpa);
                else
                    Console.WriteLine("not valid");

            }
            set
            {
                this.cgpa = value;
            }
        }
        static void Main(string[] args)
        {
            Student [] s1 = new Student[];
            s1[0].Name = "sTEVE";
            Console.WriteLine(s1.Name);
            s1[0].CGPA = 4.63;
           Console.WriteLine(s1.CGPA);
            s2[0].Name = "mark";
            Console.WriteLine(s2.Name);
            s2[0].CGPA = 0.0;
            Console.WriteLine(s2.CGPA);
        }
    }
}
