
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pracrive_911
{
    public abstract class Vehicle
    {
        public string name;

        public Vehicle(string name)
        {
            this.name = name;
        }

        public abstract void Start();

        public void showInfo()
        {
            Console.WriteLine("Name : " + name);
        }
    }

    public interface IFuel
    {
        void Refule(double amount);
    }

    public class Car : Vehicle, IFuel
    {
        private double fuel;
        public Car(string name, double fuel) : base(name)
        {
            this.fuel = fuel;
        }

        public override void Start()
        {
            if (fuel > 0)
                Console.WriteLine(name + " starts with engine sound!");
            else
                Console.WriteLine(name + " cannot start. No fuel!");
        }
        public void Refule(double amount)
        {
            fuel = fuel + amount;
            Console.WriteLine(name + " refueled. Current fuel: " + fuel);

        }

        public void showDetails()
        {
            base.showInfo();
            car.Start();
        }

    }

  
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota",45.34);

            car.showDetails();

        }
    }
}
