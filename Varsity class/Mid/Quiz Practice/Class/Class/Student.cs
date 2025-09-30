using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Student:Person
    {
        private int id;
        private int cgpa;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public Student() : base()
        {

        }

        public Student(string name, int age,int id,int cgpa):base(name,age)
        {
            this.id = id;
            this.cgpa = cgpa;
        }

        public override void showDeails()
        {
            base.showDeails();
            Console.WriteLine("ID :" + id);
            Console.WriteLine("cgpa : " + cgpa);
        }
    }
}
