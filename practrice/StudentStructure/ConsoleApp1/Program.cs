using System;

namespace ConsoleApp1
{
    struct DOB
    {
       public string month;
       public string date;
       public string year;
    }
    class student
    {
        public DOB dob;
        public void showDate()
        {
            Console.WriteLine(dob.date + " " + dob.month + " " + dob.year);
        }
        static void Main(string[] args)
        {
            DOB d1;
            d1.month = "april";
            d1.date = "20";
            d1.year = "1996";
            student s = new student();
            s.showDate();
            

           // Console.WriteLine("Hello World!");
        }
    }
}
