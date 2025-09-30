using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Student_2
{
    internal class Student
    {
        private string name;
        private int id;
        private int age;
        private int[] marks;
        private string[] subject;

        public Student(string name, int id, int age, int[] marks, string[] subject)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.marks = marks;
            this.subject = subject;
        }

        public void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Marks for subaject: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(subject[i] + " " + marks[i]);
            }
        }
    }
}
