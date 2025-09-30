using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Advance
{
    internal class bicycle:vehicle
    {
        public bicycle(string name, int wheel, int speed) : base(name, wheel, speed)
        {
            Console.WriteLine("Bicycle constructor called !");
        }

        public override void go()
        {
            Console.WriteLine(name + "Is pedaling on the steet!");
        }

        public override void display()
        {
            Console.WriteLine("Bycyle info : ");
            base.display();
        }
    }
}
