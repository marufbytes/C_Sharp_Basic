using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine("Maruf Ahammed");

            int a = 9;
            float b = 6.6f;
            double c = 7.7;
            string d = "Hi there !";

            Console.WriteLine("Index value :{1}{0}{2} ", a, b, c);
            Console.WriteLine("Index value :{0}{1}{2} ", a, b, c);
            Console.WriteLine("Index value :{0}", b);

            //input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Name : " + name);

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age : " + age);

            Console.WriteLine("Enter your salary in float : ");
            float salary = float.Parse(Console.ReadLine());
            Console.WriteLine("Salary : " + salary);

            Console.WriteLine("Enter salary in double : ");
            double salary2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Salary2 : " + salary2);

            //loop

            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 15);


            Console.ReadKey();

        }
    }
}
