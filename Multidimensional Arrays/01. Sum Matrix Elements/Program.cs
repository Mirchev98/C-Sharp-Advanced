using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            int totalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colArray = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                totalSum += colArray.Sum();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colArray[col];
                }
            }
            
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(totalSum);

        }
    }
}
