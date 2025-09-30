using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person() { }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void showDeails()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
        }

        ~Person()
        {
            Console.WriteLine("Persob distructed .");
        }

    }
}
