using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                sum += matrix[row, row];
            }

            Console.WriteLine(sum);
        }
    }
}
