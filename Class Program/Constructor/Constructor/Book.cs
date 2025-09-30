using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Book
    {
        private int bookId;
        private string title;
        private string author;
        private double price;

        public  Book(int bookId, string title , string author, double price)
        {
            this.bookId = bookId;
            this.title = title; 
            this.author = author;
            this.price = price;
        }

         public void display()
        {
            Console.WriteLine("Book id : " + bookId);
            Console.WriteLine("Book title : "+title );
            Console.WriteLine("Book author : "+author);
            Console.WriteLine("Book price : "+price);
        }
    }
}
