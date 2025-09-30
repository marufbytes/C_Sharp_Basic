using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1;
            Book b2;
            Book b3;

            b1 = new Book(3434, "Fora", "dadsf", 3453);
            b2 = new Book(3353, "adfgsg", "dfasd", 35353);
            b3 = new Book(434, "dfa", "dfad", 34343);

            Console.WriteLine("Book 1 info : ");
            b1.display();

            Console.WriteLine("Book 2 info : ");
            b2.display();

            Console.WriteLine("Book 3 info : ");
            b3.display();

            Console.ReadKey();

        }
    }
}
