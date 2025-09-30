using System;

namespace MyApplication
{

    class Student
    {
        protected string name = "Sheeran";
    }
  
    class Program : Student
    {
        static void Main(string[] args)
        {

           
            Program program = new Program();

            
            Console.WriteLine("Name: " + program.name);
            Console.ReadLine();
        }
    }
}