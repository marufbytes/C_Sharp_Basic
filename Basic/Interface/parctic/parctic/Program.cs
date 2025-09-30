using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parctic
{
    interface Book
    {
        void addQuantity(int amount);
        void sellQuantity(int amount);
    }

    abstract class BookShop
    {
        private string location;
        private string author;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public abstract void showDetails();
        
    }

    public class TextBook:BookShop,Book
    {
        TextBook Tb;


    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
