using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct Rectangle
    {
        public double height;
        public double weidth;

        public Rectangle(double height, double weidth)
        {
            this.height = height;
            this.weidth = weidth;
        }

        // Now it returns the area
        public double Area()
        {
            return weidth * height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Rectangle r = new Rectangle(length, width);

            double area = r.Area();
            Console.WriteLine("Area: " + area);


            Console.ReadKey();
        }
    }
}
