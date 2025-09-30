using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] Jagged= new int[4][];
            Jagged[0] = new int[] { 5, 56, 4, 6, 8 };
            Jagged[1] = new int[] { 3 };
            Jagged[2] = new int[] { 4, 56, 7, 5 };
            Jagged[3] = new int[] { 5, 6 };

            int i, j;
            for ( i = 0; i < Jagged.Length; i++)
            {
                for ( j = 0; j < Jagged[i].Length; j++)
                {
                    Console.Write(Jagged[i][j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Updated Array: ");
        
            for ( i= 0; i < Jagged.Length; i++)
            {
                int sum = 0;
                for ( j = 0; j < Jagged[i].Length; j++)
                {
                    sum +=Jagged[i][j];
                }
                Console.Write(sum);
                Console.WriteLine() ;
            }


            Console.ReadKey();
        }
    }
}
