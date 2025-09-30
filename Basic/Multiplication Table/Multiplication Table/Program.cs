using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit to generate its multiplication table:");
            int digit=int.Parse(Console.ReadLine());

            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "*" + digit + " = " + (i * digit));
            }

            while (i <= 10)
            {
                Console.WriteLine(i + "*" + digit + " = " + (i * digit));
                i++;
            }

            do
            {
                Console.WriteLine(i + "*" + digit + " = " + (i * digit));
                i++;
            }
            while (i <= 10);

        }
    }
}
