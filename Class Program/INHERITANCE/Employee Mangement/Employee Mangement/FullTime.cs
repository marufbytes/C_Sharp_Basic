using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Mangement
{
    internal class FullTime:Employee
    {
        public int salary;
        public FullTime(string name, int id, int age, int salary):base( name,  id,  age)
        {
            Console.WriteLine("Full time employee's constructor called ! ");
            this.salary = salary;
        }

        public override void display()
        {
            Console.WriteLine("Full time employee details : ");
            base.display();
            Console.WriteLine("Salary : " + salary);
        }
    }
}
