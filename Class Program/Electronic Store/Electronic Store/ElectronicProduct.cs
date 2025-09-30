using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Electronic_Store
{
    internal class ElectronicProduct:Product
    {
        private int warraenty;

        public int warrenty
        {
            get { return warraenty; }
            set { warraenty=value; }
        }

        public ElectronicProduct():base() { }

        public ElectronicProduct(int id, string name, double price,int warrenty) : base(id, name, price)
        {
            base.display();
            this.warraenty = warraenty;
        }

        public override void display()
        {
            Console.WriteLine("Warrenty : " + warraenty);
        }
            
    }
}
