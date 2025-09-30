using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Membership
{
    internal class mainApp
    {
        static void Main(string[] args)
        {
            Console.Write("How many members : ");
            int numOfMember = int.Parse(Console.ReadLine());

            List<Member> member = new List<Member>();

            for (int i = 0; i < numOfMember; i++)
            {

                Console.Write("Enter name : ");
                string name = Console.ReadLine();

                Console.Write("Enter id : ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter membership type : ");
                string membershipType = Console.ReadLine();

                Console.Write("Enter monthly fee : ");
                int monthlyFee = int.Parse(Console.ReadLine());

                Member m = new Member();

                m.Name = name;
                m.Id = id;
                m.memberShipType = membershipType;
                m.MonthlyFee = monthlyFee;

                member.Add(m);
                m.display();

            }

            


            Console.ReadKey();
        }
    }
}
