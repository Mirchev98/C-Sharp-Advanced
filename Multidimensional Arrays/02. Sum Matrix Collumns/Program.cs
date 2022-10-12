using System;
using System.Linq;

namespace _02._Sum_Matrix_Collumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colArray[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int collumnSum = 0;

                for (int row = 0; row < rows; row++)
                {
                    collumnSum += matrix[row, col];
                }

                Console.WriteLine(collumnSum);
            }
        }
    }
}
