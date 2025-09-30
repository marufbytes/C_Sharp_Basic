using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    public abstract class PaymentMethod
    {
        public string name;

        public PaymentMethod(string name)
        {
            this.name = name;
        }

        public abstract void pay(double amount);
        

        public void showInfo()
        {
            Console.WriteLine("name: " + name);
        }      
    }
    public interface Irefundable
    {
        void Refund(double amount);
    }


    public class CreditCard : PaymentMethod, Irefundable
    {
        private string CardLast4;
        private double AvailableLimit;
        public CreditCard(string name,string CardLast4, double AvailableLimit):base(name)
        {
            this.CardLast4 = CardLast4;
            this.AvailableLimit = AvailableLimit;
        }
    }

    public override void pay(double amount)
        {
            
        }
}

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
