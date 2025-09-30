using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
     public interface IAnimal
    {
        void Sleep();
        void Eat();
    }

    public abstract class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void makeSound();

        public void displayInfo(string name)
        {
            Console.WriteLine("Name : " +name);
        }

       }

    public class Bird : Animal, IAnimal
    {
        public override void makeSound()
        {
            Console.WriteLine("Chik");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird b = new Bird();
            b.Name = "Birddd"; ;

            b.displayInfo()
            
        }
    }
}
