using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Store
{
    internal class Product
    {
        private int id;
        private string name;
        private double price;

        public Product() { }

        public int Id
        {
            get { return id; }
            set { id=value; }
        }

        public string Name
        {
            get { return name; }
            set { name=value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(int Id, string Name, double Price)
        {
            this.id = Id;
            this.name = Name;
            this.price = Price;
        }

        public virtual void display()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Price : " + price);
        }

        public void applyDiscount()
        {
            price -= price * 0.05;
            Console.WriteLine("5% discount applied. ");
        }

        public void applyDiscout(double perchantage)
        {
            price -= price * (perchantage/100);
            Console.WriteLine("Custom discount applied.");
        }

        ~Product()
        {
            Console.WriteLine("Product, Id: " + id + " Has been destroyed .");
        }
            
    }
}
