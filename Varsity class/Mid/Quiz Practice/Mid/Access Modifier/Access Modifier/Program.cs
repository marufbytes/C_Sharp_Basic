using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{

    class BaseClass
    {
        public string publicVar = "Public Variable";
        private string privateVar = "Private Variable";
        protected string protectedVar = "Protected Variable";

        public void ShowVariables()
        {
            Console.WriteLine(publicVar);
            Console.WriteLine(privateVar);
            Console.WriteLine(protectedVar);
        }
    }

    class DerivedClass : BaseClass
    {
        public void ShowDerived()
        {
            Console.WriteLine(publicVar);        // Accessible
            // Console.WriteLine(privateVar);    // Not accessible - private in base
            Console.WriteLine(protectedVar);     // Accessible because protected
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            DerivedClass derivedObj = new DerivedClass();

            Console.WriteLine("BaseClass ShowVariables:");
            baseObj.ShowVariables();

            Console.WriteLine("\nDerivedClass ShowDerived:");
            derivedObj.ShowDerived();

            Console.WriteLine("\nAccess from Main:");
            Console.WriteLine(baseObj.publicVar);    // Accessible
                                                     // Console.WriteLine(baseObj.privateVar); // Not accessible
                                                     // Console.WriteLine(baseObj.protectedVar); // Not accessible

            Console.ReadKey();
        }
    }
}
