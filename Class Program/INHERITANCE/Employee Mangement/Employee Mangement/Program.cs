using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Mangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];

            emp[0] = new FullTime("Maruf ", 34343, 21,50000);
            emp[1] = new PartTime("Sadib", 4443, 21, 40000);
            emp[2] = new Intern("Sajid", 4434, 21, 30000);

            foreach(Employee e in emp)
            {
                e.display();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
