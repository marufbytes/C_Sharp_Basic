using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Gym_Membership
{
    internal class Member
    {
        private string name;
        private int id;
        private string membershipType;
        private int monthlyFee;

        public Member() { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string memberShipType
        {
            get { return membershipType; }
            set { membershipType = value; }
        }

        public int MonthlyFee
        {
            get { return monthlyFee;}
            set { monthlyFee = value; }
        }

        public void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Membership Type : " + membershipType);
            Console.WriteLine("Monthly Fee: " + monthlyFee);
            Console.WriteLine();
        }
    }
}