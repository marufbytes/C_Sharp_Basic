using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicle[] v = new vehicle[3];

            v[0] = new car("Toyota", 4, 120);
            v[1] = new bicycle("Hero", 2, 25);
            v[2] = new boat("Speed Boat ", 0, 60);

            foreach(vehicle ve in v)
            {
                ve.display();
                ve.go();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
