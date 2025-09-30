using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Advance
{
    internal class boat:vehicle
    {
        public boat(string name, int wheel, int speed): base(name, wheel, speed)
        {
            Console.WriteLine("Boat constructor called!");
        }

        public override void go()
        {
            Console.WriteLine(name + " is sailing on the river!");
        }

        public override void display()
        {
            Console.WriteLine("Boat info: ");
            base.display();
        }
        


    }
}
