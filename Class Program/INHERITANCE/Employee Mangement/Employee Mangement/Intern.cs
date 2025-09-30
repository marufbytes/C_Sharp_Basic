using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Mangement
{
    internal class Intern:Employee
    {
        public int salary;

        public Intern(string name, int id, int age, int saraly) : base(name, id, age)
        {
            Console.WriteLine("Intern constructor called ! ");
            this.salary = salary;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Salary : " + salary);
        }

    }
}
