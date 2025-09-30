using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Single_Class
{
    internal class Student
    {
        private string name;
        private int id;
        private int[] marks;
        private string[] Grade;

        public string Name
        {
            set { name  = value; }
            get { return name; }
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public int[] Marks
        {
            set {  marks = value; }
            get { return marks; }

        }
        public string[] grade
        {
            set { Grade = value; }
            get { return Grade; }
        } 

        public void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID: "+id);
            Console.WriteLine("Marks for student : " + string.Join(" ",marks));
            Console.WriteLine("Subject wise marks : ");

            for (int i = 0; i < Grade.Length; i++)
            {
                Console.WriteLine(Grade[i] +" " + marks[i]);
            }
        }


        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.name = "Maruf";
            s1.id = 1423;
            s1.marks = new int[] { 43, 55, 34 };
            s1.Grade = new string [] { "Math", "Phy", "Che" };

            s1.display();

            Console.ReadKey();


        }
    }
}
