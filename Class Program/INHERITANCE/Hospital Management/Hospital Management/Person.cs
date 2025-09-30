using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { string name; }
        }

        public int Age
        {
            get { return age; }
            set { int age; }
        }

        public Person()
        {
            Console.WriteLine("Default constructor called !");
        }

        public Person(string name, int age)
        {
            Console.WriteLine("Parameterised constructor called !");
            this.name = name;
            this.age = age;            
        }

        public virtual void displty()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
        }
        ~Person()
        {
            Console.WriteLine("Destructor called!");
        }
    }
}
