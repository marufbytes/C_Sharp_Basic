using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lirbrary
{
    internal class Book
    {
        private string title;
        private string author;
        private int isbn;
        private string[] genres;

        public Book (string title, string author,int isbn, string[] genres)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.genres = genres;
        }

        public void display()
        {
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("ISBN : " + isbn);
            Console.WriteLine("Geners : ");

            for(int i=0;i<genres.Length;i++)
            {
                Console.WriteLine(genres[i]);
            }

        }

    }
}
