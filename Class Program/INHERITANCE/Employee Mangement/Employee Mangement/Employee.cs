using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Mangement
{
    internal class Employee
    {
        public string employeeName;
        public int employeeId;
        public int age;

        public Employee(string employeeName, int employeeId, int age)
        {
            Console.WriteLine("Employee constructor called ! ");
            this.employeeId = employeeId;
            this.employeeId = employeeId;
            this.age = age;
            Console.WriteLine();
        }

        public virtual void display()
        {
            Console.WriteLine();
            Console.WriteLine("Employee name : " + employeeName);
            Console.WriteLine("Employee Id : " + employeeId);
            Console.WriteLine("Employee's age : " + age);
        }

    }
}
