using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accc
{
    public class X1
    {
        private protected string p;
        public double q;
        internal byte r;
        protected internal byte s;
    }

    public class Y1 : X1
    {
        string i;
        protected int j;
        public void N0() { }
    }

    class Program1 : Y1
    {
        static void Main(string[] args)
        {
            X1 obj1 = new X1();
        }
    }
}
