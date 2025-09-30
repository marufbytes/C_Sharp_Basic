using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lirbrary
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Console.Write("How many books : ");
            int numOfBooks = int.Parse(Console.ReadLine());

            for(int i = 0; i < numOfBooks; i++)
            {
                Console.Write("Write title : ");
                string title = Console.ReadLine();

                Console.Write("Write author name : ");
                string author = Console.ReadLine();

                Console.Write("Write isbn : ");
                int isbn = int.Parse(Console.ReadLine());

                Console.Write("Enter genres : ");
                string genreInput = Console.ReadLine();
                string [] genres = genreInput.Split(',');        

                Book b = new Book(title, author, isbn, genres);

                b.display();

                Console.Write("......................................");
            }

            Console.ReadKey();
        }
    }
}
