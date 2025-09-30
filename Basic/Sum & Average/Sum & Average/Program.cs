using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum___Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers:");

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array : ");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(i+" ");
            }
           Console.WriteLine();

            int sum = numbers.Sum();
            double average = numbers.Average();

            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Average : " + average);


        }
    }
}
