using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Car
    {
        private int lid;

        public int Lid
        {
            set {  lid = value; }
            get { return lid; }
        }

        public string model { get; set; }


        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.lid = 101;
            Console.WriteLine("Car id : "+c1.lid);

            Car c2 = new Car();
            c2.model = "Phantom";
            Console.WriteLine("Car Model : "+c2.model);

            Console.ReadKey();
        }
    }
}
