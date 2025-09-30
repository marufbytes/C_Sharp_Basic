using System;

class Program
{
    static void Main()
    {
        int[][] jagged = new int[4][];
        jagged[0] = new int[] { 2, 7, 4, 5 };
        jagged[1] = new int[] { 9, 3 };
        jagged[2] = new int[] { 1, 6, 8 };
        jagged[3] = new int[] { 10, 15, 5, 2, 1 };

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                if (jagged[i][j] % 2 == 0)
                {
                    jagged[i][j] *= (i + j + 1);
                }
                else
                {
                    jagged[i][j] += (i * j + 2);
                }

                if (jagged[i][j] % 3 == 0)
                {
                    jagged[i][j] -= i;
                }
            }
        }

        Console.WriteLine("=== Modified Jagged Array ===");

        for (int i = 0; i < jagged.Length; i++)
        {
            int sum = 0, product = 1, count = 0;

            Console.Write("Row " + i + ": ");

            if (i % 2 != 0)
            {
                int j = jagged[i].Length - 1;
                while (j >= 0)
                {
                    if (!IsPrime(jagged[i][j]))
                    {
                        Console.Write(jagged[i][j] + " ");
                        sum += jagged[i][j];
                        product *= jagged[i][j];
                        count++;
                    }
                    j--;
                }
            }
            else 
            {
                foreach (var num in jagged[i])
                {
                    if (num % 5 != 0)
                    {
                        Console.Write(num + " ");
                        sum += num;
                        product *= num;
                        count++;
                    }
                }
            }

            double average = count > 0 ? (double)sum / count : 0;
            Console.WriteLine("| Sum = " + sum + ", Product = " + product + ", Average = " + average);
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
            if (num % i == 0) return false;
        return true;
    }
}
