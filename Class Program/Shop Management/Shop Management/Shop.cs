using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management
{
    internal class Shop
    {
        private string shopName;
        private int shopId;
        private string[] productName;
        private int[] productPrice;

        public string ShopName
        {
            set { shopName = value; }
            get { return shopName; }
        }

        public int ShopId
        {
            set { shopId = value; }
            get { return shopId; }
        }

        public string[] ProductName
        {
            set { productName = value; }
            get { return productName; }
        }

        public int[] ProductPrice
        {
            set { productPrice = value; }
            get { return productPrice; }
        }

        public void Display()
        {
            Console.WriteLine("Shop name : " + ShopName);
            Console.WriteLine("Shop id ; " + ShopId);
            Console.WriteLine("Item's price : ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ProductName[i] + " : " + ProductPrice[i]);
            }
        }

    }
}
