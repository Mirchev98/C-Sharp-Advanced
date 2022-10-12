using System;
using System.Runtime.InteropServices;

namespace _07._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            long[][] jagged = new long[input][];

            for (int row = 0; row < input; row++)
            {
                jagged[row] = new long[row + 1];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    long sum = 0;
                    if (row - 1 >= 0 && col < jagged[row - 1].Length)
                    {
                        sum += jagged[row - 1][col];
                    }

                    if (row - 1 >= 0 && col - 1 >= 0)
                    {
                        sum += jagged[row - 1][col - 1];
                    }

                    if (sum == 0)
                    {
                        sum = 1;
                    }

                    jagged[row][col] = sum;
                }
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
