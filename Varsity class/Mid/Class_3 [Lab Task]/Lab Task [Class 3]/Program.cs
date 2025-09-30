using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_Task__Class_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1

            Console.WriteLine("Enter a digit: ");

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even ");
            }



            else if (num == 0)
            {
                Console.WriteLine("Zero");
            }

            else
            {
                Console.WriteLine("Invalid");
            }


            //2

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + "  ");
            }

            Console.WriteLine("secona array: ");
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "  ");
                }
            }

            //3

            int count = 0;
            for (int i = 101; i <= 201; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Tottal count : " + count);


            //4
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //5

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("XOXOX");
                Console.WriteLine("OXOXO");
            }



            //6

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }


            for (int i = 5; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //7
            Console.Write("Enter a digit for factorial; ");
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; 1 <= num; i++)
            {
                result += i;
            }

            Console.WriteLine();

        }
    }
}
