using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        struct Student
        {
            public int id;
            public string name;
            public int age;
            public string address;   
        }

        enum weekDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Student s;
            s.id = 1;
            s.name = "Maruf";
            s.age = 21;
            Console.WriteLine("Student ID : " + s.id);
            Console.WriteLine("Student Name : " + s.name);
            Console.WriteLine("Student Age : " + s.age);

            Console.WriteLine(weekDays.Sunday);
            Console.WriteLine(weekDays.Monday);
            Console.WriteLine(weekDays.Tuesday);
            Console.WriteLine(weekDays.Wednesday);
            Console.WriteLine(weekDays.Thursday);

            Console.ReadKey();
        }
    }
}
