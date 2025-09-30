using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            bicycle b = new bicycle();
            boat bo = new boat();

            Console.WriteLine(c.speed);
            Console.WriteLine(c.wheel);
            c.go();

            Console.ReadKey();
        }
            
    }

    class vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("The vehicle is moving !");

        }
    }

    class car : vehicle
    {
        public int wheel = 4;
    }

    class bicycle : vehicle
    {
        public int wheel = 2;
    }

    class boat : vehicle
    {
        public int wheel = 0;
    }
}
