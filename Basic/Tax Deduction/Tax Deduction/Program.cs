using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name : ");
            string name = Console.ReadLine();

            Console.Write("Enter age : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Salary : ");
            int salary = int.Parse(Console.ReadLine());

            if(age >= 18)
            {
                salary = salary - (salary * 15/100);
            }

            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Salary : " + salary);


            Console.ReadKey();
        }
    }
}
