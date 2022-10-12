using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                int currentSum = 0;

                for (int col = 0; col < cols - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] 
                        + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
