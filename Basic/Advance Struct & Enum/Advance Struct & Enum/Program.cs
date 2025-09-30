using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Struct___Enum
{
    internal class Program
    {
        struct Student
        {
            public string name;
            public int age;
            public double cg;
        }

        static void Main(string[] args)
        {
            Student[] s = new Student[3];

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write("Enter name : ");
                s[i].name = Console.ReadLine();

                Console.Write("Enter age : ");
                s[i].age = int.Parse(Console.ReadLine());

                Console.Write("Enter cgpa : ");
                s[i].cg = double.Parse(Console.ReadLine());

            }

            
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i].age >= 20)
                {
                    Console.WriteLine("Name for student " + i + " : " + s[i].name);
                    Console.WriteLine("Age for student " + i + " : " + s[i].age);
                    Console.WriteLine("Cgpa for student " + i + " : " + s[i].cg);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid age " );
                }
              
            }
           
         Console.ReadKey();

        }
    }
}
