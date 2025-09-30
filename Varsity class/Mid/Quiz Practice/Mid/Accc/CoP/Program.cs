using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoP
{
    class X2
    {
        string x1;
        public double x2;
        internal byte x3;
        protected internal byte x4;
    }

    public class Y2 : AcccO.X1
    {
        string p1;
        protected int q1;
        public void F10() { 
        }
    }

    class Program2 : Y2
    {
        public void F20()
        {
            X2 obj2 = new X2();
            
        }
    }
}
