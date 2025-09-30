using System;

namespace LabTask
{
    public abstract class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void makeSound();

        public void showDetails()
        {
            Console.WriteLine("Name : " + name);
            
        }
    }

    public interface IMove
    {
        void move();
    }

    public class Dog : Animal, IMove
    {
        public Dog(string name) : base(name)
        {
        }

        public override void makeSound()
        {
            Console.WriteLine("Ghew");
        }

        public void move()
        {
            Console.WriteLine("Moving");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog("Sadib");
            dog.showDetails();
            dog.makeSound();
            dog.move();
        }
    }
}
