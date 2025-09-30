using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class Shape
    {
        public string name;

        public Shape(string Name)
        {
            name = Name;
        }

        public abstract double getArea();

        public void Display()
        {
            Console.WriteLine("Name: " + name);
        }
    }

    public interface IColor
    {
        void selectColor(string color);
    }

    public class Rectangle : Shape,IColor
    {
        private double width;
        private double length;
        private string color;

       
        public Rectangle(string name, double width, double length) : base(name)
        {
            this.width = width;
            this.length = length;
        }

        public override double getArea()
        {
            return width * length;
        }
        public void selectColor(string name)
        {
            color = color;
        }
        public void ShowDetails()
        {
            Display();
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Height: " + length);
            Console.WriteLine("Area: " + getArea());
            Console.WriteLine("Color: " + color);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle("Rectangle", 10, 5);
            rect.selectColor("Red");
            rect.ShowDetails();

            Console.ReadLine();
        }
    }
}
