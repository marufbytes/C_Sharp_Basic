using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        struct student
        {
            public int id;
            public string name;
            public string address;
        }

        enum weekDays
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
            
        }
        static void Main(string[] args)
        {
            student s;
            s.id = 1;
            s.name = "Maruf";
            s.address = "Dhaka, Bangladesh";

            Console.WriteLine("ID : " + s.id);
            Console.WriteLine("Name : " + s.name);
            Console.WriteLine("Address : " + s.address);

            Console.WriteLine(weekDays.sunday);
            Console.WriteLine(weekDays.monday);

            Console.WriteLine((int)(weekDays.thursday));
        }
    }
}
