using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Maruf", "Sadib", "Sajid", "Tofayet", "Sultan" };

            Console.Write("Enter a name to search: ");
            string searchName = Console.ReadLine();

            int i;

            for (i = 0; i < names.Length; i++)
            {
                if (searchName == names[i])
                {
                    break;
                }
            }


            if (i < names.Length)
            {
                Console.WriteLine("Founded in : " + i);
            }
            else
            {
                Console.WriteLine("Not Found");
            }


            Console.ReadKey();
        }
    }
}
