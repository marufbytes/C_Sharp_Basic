using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public abstract class Shape
    {
        string name;

        public abstract double getArea();

        public Shape(string name)
        {
            this.name = name;
        }

        public void showInfo()
        {
            Console.WriteLine("Name: "+name);

        }
    }

    public interface IColor
    {
        void setColor(string color);
    }

    public class Circle : Shape, IColor
    {
        private double radius;
        private string color;
        public Circle(string name, double radius, string color):base(name)
        {
            this.radius = radius;
            this.color = color;

        }
        public override double getArea()
        {
            return Math.PI * radius * radius;
        }
         
        public void setColor(string color)
        {
            this.color = color;
        }

        public void showDetails()
        {
            showInfo();
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area: " + getArea());
            Console.WriteLine("Color: " + color);
            Console.WriteLine();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle",4.53,"Red");
            circle.showDetails();
        }
    }
}
