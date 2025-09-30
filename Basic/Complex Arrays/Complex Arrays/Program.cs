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

            int i ;

            for (i=0;i<names.Length; i++)
            {
                if (searchName==names[i] )  
                {
                    break;
                }
            }

            if (i < names.Length)
            {
                Console.WriteLine("Founded in : "+ i);
            }
            else
            {
                Console.WriteLine("Not Found");
            }


            // vowel count
            int count = 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach(char c in searchName.ToLower())
            {
                if(vowels.Contains(c))
                {
                    count++;
                }
            }

            Console.WriteLine("Number of vowels in the name: " + count);


            //Replace name
            Console.Write("Enter the index to replace: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < names.Length)
            {
                Console.Write("Enter the new name: ");
                string newName = Console.ReadLine();
                names[index] = newName;
                Console.WriteLine("Updated list : ");
                
                foreach(string name in names)
                {
                    Console.Write(names + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }


            Console.ReadKey();
        }
    }
}
