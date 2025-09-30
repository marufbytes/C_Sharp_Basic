using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    interface IAnimal
    {
        void Eat();
        void Sleep();
    }

    abstract class Animal
    {
        public string name { get; set; }
        public abstract void makeSound();
        public void displayInfo()
        {
            Console.WriteLine("Name: " + name);
        }
    }

    class Cat : Animal,IAnimal
    {
        public override void makeSound()
        {
            Console.WriteLine("Mewo");
        }
        public void Eat()
        {
            Console.WriteLine("Milk");
        }
        public void Sleep()
        {
            Console.WriteLine("Cat is sleeping.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.makeSound();

            c.name = "Meow";
            c.displayInfo();
            c.Eat();
            c.Sleep();
            
        }
    }
}
