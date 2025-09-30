using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many electronic product : ");
            int n = int.Parse(Console.ReadLine());

            ElectronicProduct[] products = new ElectronicProduct[n];
            
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter product id : ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter name : ");
                string name = Console.ReadLine();
                Console.Write("Enter price : ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Enter warrenty : ");
                int warrenty = int.Parse(Console.ReadLine());


                products[i] = new ElectronicProduct(id, name, price, warrenty);

            }

            for(int i = 0; i < n; i++)
            {

                ((Product)products[i]).display();

                products[i].display();

                products[i].applyDiscount();
                products[i].display();

                products[i].applyDiscout(32);
                products[i].display();



            }
            Console.ReadKey();

        }
    }
}
