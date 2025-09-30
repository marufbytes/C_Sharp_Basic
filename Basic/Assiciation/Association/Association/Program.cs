using System;
using System.Collections.Generic;

namespace LabTask.AssociationDemo
{
    class Teacher
    {
        public string Name { get; set; }
        public Department Dept { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }
    }

    class Department
    {
        public string DeptName { get; set; }
        private List<Teacher> teachers;

        public Department(string name)
        {
            DeptName = name;
            teachers = new List<Teacher>();
        }

        public void AddTeacher(Teacher t)
        {
            teachers.Add(t);
            t.Dept = this; // back-reference
        }

        public void ShowTeachers()
        {
            Console.WriteLine("Department: " + DeptName);
            foreach (Teacher t in teachers)
            {
                Console.WriteLine("Teacher: " + t.Name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department("Computer Science");

            Teacher t1 = new Teacher("Alice");
            Teacher t2 = new Teacher("Bob");

            d.AddTeacher(t1);
            d.AddTeacher(t2);

            d.ShowTeachers();
        }
    }
}
