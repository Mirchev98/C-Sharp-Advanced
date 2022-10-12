using System;
using System.Linq;

namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[,] matrix = new char[rows, rows];

            for (int row = 0; row < rows; row++)
            {
                char[] characters = Console.ReadLine().ToCharArray();

                for (int col = 0; col < rows; col++)
                {
                    matrix[row, col] = characters[col];
                }
            }

            char toFind = char.Parse(Console.ReadLine());
            bool found = false;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    if (matrix[row,col] == toFind)
                    {
                        Console.WriteLine($"({row}, {col})");
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{toFind} does not occur in the matrix");
            }
        }
    }
}
