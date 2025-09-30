using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Mangement
{
    internal class PartTime : Employee
    {
        public int salary;
        public PartTime(string name,int id, int age, int salary) : base(name, id, age)
        {
            Console.WriteLine("Part time constuctor called ! ");

            this.salary = salary;
        }

        public override void display()
        {
            Console.WriteLine("Part time employee details : ");
            base.display();
            Console.WriteLine("Salary : " + salary);
        }
    }
}
