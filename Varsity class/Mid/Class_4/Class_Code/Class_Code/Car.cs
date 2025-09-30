using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Class_Code
{
    internal class Car
    {
        private int lid;
        private string model;
        private int cc;

        public void setLid(int lid)
        {
            this.lid = lid;
        }
        public void setModel(string name)
        {
            this.model = name;
        }
        public void setCc(int cc)
        {
            this.cc = cc;
        }

        public int getLid()
        {
            return lid;
        }
        public string getModel()
        {
            return model;
        }
        public int getCc()
        {
            return cc;
        }

        static void Main(string[] args)
        {
            Car c1 = new Car();

            c1.setLid(101);
            c1.setModel("BMW");
            c1.setCc(40044);

            Console.WriteLine("Car ID : " + c1.getLid());
            Console.WriteLine("Car Model :" + c1.getModel());
            Console.WriteLine("Car Cc : " + c1.getCc());

            Console.ReadKey();
        }
    }
}
