using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
            private int id;
            private string name;
            private int quantity;

            // Default Constructor
            public Product()
            {
                id = 0;
                name = "Unknown";
                quantity = 0;
            }

            // Parameterized Constructor
            public Product(int id, string name, int quantity)
            {
                this.id = id;
                this.name = name;
                this.quantity = quantity;
            }

            // Properties
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }

            // Method to add quantity
            public void AddQuantity(int amount)
            {
                quantity += amount;
                Console.WriteLine(amount + " units added.");
            }

            // Method to sell quantity
            public void SellQuantity(int amount)
            {
                if (amount <= quantity)
                {
                    quantity -= amount;
                    Console.WriteLine(amount + " units sold.");
                }
                else
                {
                    Console.WriteLine("Not enough stock to sell.");
                }
            }

            // Display method
            public void Display()
            {
                Console.WriteLine("ID: " + id + " Name: " + name + " Quantity: " + quantity);
            }
        }
    }


