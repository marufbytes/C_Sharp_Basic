using System;

namespace ConstructorDestructorExample
{  

    class Program
    {
        class Book
        {
            private string title;
            private string author;
            private double price;

            public Book()
            { }

            ~Book()
            {
                Console.WriteLine("Destructor called: Book object is being destroyed.");
            }

            public void DisplayInfo()
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Price: $" + price);
                Console.WriteLine();
            }

            public void SetBook(string t, string a, double p)
            {
                title = t;
                author = a;
                price = p;
            }
        }
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetBook("Clean Code", "Robert C. Martin", 45.99);
            book1.DisplayInfo();

            Book book2 = new Book();
            book2.SetBook("The Pragmatic Programmer", "Andrew Hunt", 39.99);
            book2.DisplayInfo();

            Console.ReadKey();

        }
    }
}
