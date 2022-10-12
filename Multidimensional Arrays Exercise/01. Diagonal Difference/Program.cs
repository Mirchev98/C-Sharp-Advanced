using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] collumns = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = collumns[col];
                }
            }

            int diagonalOne = 0;
            int diagonalTwo = 0;

            for (int row = 0; row < size; row++)
            {
                diagonalOne += matrix[row, row];
                diagonalTwo += matrix[size - row - 1, row];
            }

            Console.WriteLine(Math.Abs(diagonalOne - diagonalTwo));
        }
    }
}
