using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Advance
{
    internal class car:vehicle

    {
        public car(string name, int wheel, int speed) : base(name, wheel, speed)
        {
            Console.WriteLine("Car constructor called !");
        }
        public override void display()
        {
            Console.WriteLine("Car infor : ");
            base.display();
        }
    }
}
