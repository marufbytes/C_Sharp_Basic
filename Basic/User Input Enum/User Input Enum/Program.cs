using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_Enum
{
    internal class Program
    {
        enum days
        {
            sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day name : ");
            int day = ToLower(day.ReadLine());
        }
    }
}
