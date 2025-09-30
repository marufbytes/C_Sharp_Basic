using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Advance
{
    class vehicle
    {
        public string name;
        public int wheel;
        public int speed;

        public vehicle(string name, int wheel, int speed)
        {
            Console.WriteLine("Vehicle constructor called!");
            this.name = name;
            this.wheel = wheel;
            this.speed = speed;
        }

        public virtual void display()
        {
            Console.WriteLine("Vehicle name : " + name);
            Console.WriteLine("Wheel count : " + wheel);
            Console.WriteLine("Speed : " + speed + " km/h");
        }

        public virtual void go()
        {
            Console.WriteLine("This vehicle is moving !");
        }
    }
}
