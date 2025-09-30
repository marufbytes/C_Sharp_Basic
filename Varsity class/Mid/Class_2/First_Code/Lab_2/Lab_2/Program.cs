using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[5];
            for (int i = 0; i < 5; i++)
            {
                student[i] = Console.ReadLine();
            }

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Student : " + student[i]);
            }

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Student using Length : " + student[i]);
            }

            foreach (string s in student)
            {
                Console.WriteLine("Student using foreach : " + s);
            }

            foreach (var s in student)
            {
                Console.WriteLine("student using var : " + s);

            }

            //var

            var a = 2;
            var b = 3.4;
            var c = "Maruf";

            Console.WriteLine("Intiger a = " + a);
            Console.WriteLine("Float b = " + b);
            Console.WriteLine("String c = " + c);

            // Jagged Array

            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 6, 7, 8 };
            jaggedArray[2] = new int[] { 9, 10 };
            jaggedArray[3] = new int[] { 115 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j] + "  ");
                }
                Console.WriteLine();
            }

            // convert
            Console.Write("Enter age : ");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age : " + age);

            Console.ReadKey();
        }
    }
}
