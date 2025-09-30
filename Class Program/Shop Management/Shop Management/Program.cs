using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Shop s = new Shop();

            s.ShopName = "Maruf Traders";
            s.ShopId = 34343;
            s.ProductName = new string[]{ "Rice", "Potato","Oil"};
            s.ProductPrice = new int[] { 34, 53, 54 };

            s.Display();

            Console.ReadKey();


        }
    }
}
