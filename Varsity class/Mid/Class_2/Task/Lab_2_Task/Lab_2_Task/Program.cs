using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Task
{
    internal class Program
    {
        struct Employee
        {
            public int id;
            public int sal;
        }
        static void Main(string[] args)
        {
            Employee e;

            Console.Write("Enter your ID : ");
            e.id = int.Parse(Console.ReadLine());
            Console.WriteLine("ID : " + e.id);

            Console.WriteLine("Enter salary : ");
            e.sal = int.Parse(Console.ReadLine());
            Console.WriteLine("Salary : " + e.sal);

            Console.ReadKey();

        }
    }
}
