using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first digit : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second digit : "); 
            int b = int.Parse(Console.ReadLine());

            Console.Write("Which operation you wanna do? (+,-,*,/");
            char c = char.Parse(Console.ReadLine());

            if(c =='+')
            {
                Console.WriteLine("Result: " + (a + b));
            }
            else if(c == '-')
            {
                Console.WriteLine("Result: " + (a - b));
            }
            else if(c == '*')
            {
                Console.WriteLine("Result: " + (a * b));
            }
            else if(c == '/')
            {
                if(b != 0)
                {
                    Console.WriteLine("Result: " + (a / b));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid operation.");
            }

            Console.ReadKey();
        }
    }
}
