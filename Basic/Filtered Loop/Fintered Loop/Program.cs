using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintered_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                if (i % 11 == 0)
                {
                    break;
                }
                Console.Write(i+" ");

            }
            Console.ReadKey();
        }
    }
}
