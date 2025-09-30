using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
                // First product using parameterized constructor
                Console.Write("Enter ID for product 1: ");
                int id1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Name for product 1: ");
                string name1 = Console.ReadLine();
                Console.Write("Enter Quantity for product 1: ");
                int qty1 = int.Parse(Console.ReadLine());

                Product p1 = new Product(id1, name1, qty1);

                // Second product using default constructor
                Product p2 = new Product();
                Console.Write("Enter ID for product 2: ");
                p2.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Name for product 2: ");
                p2.Name = Console.ReadLine();
                Console.Write("Enter Quantity for product 2: ");
                p2.Quantity = int.Parse(Console.ReadLine());

                // Operations on product 1
                Console.WriteLine("\n--- Product 1 Operations ---");
                p1.Display();
                p1.AddQuantity(10);
                p1.Display();
                p1.SellQuantity(5);
                p1.Display();

                // Operations on product 2
                Console.WriteLine("\n--- Product 2 Operations ---");
                p2.Display();
                p2.AddQuantity(20);
                p2.Display();
                p2.SellQuantity(8);
                p2.Display();
            }
        }
    }

