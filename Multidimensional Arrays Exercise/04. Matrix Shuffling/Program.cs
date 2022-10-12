using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            string[] commands = Console.ReadLine().Split(" ");

            while (commands[0] != "END")
            {
                if (commands[0] == "swap" && commands.Length == 5)
                {
                    int rowOne = int.Parse(commands[1]);
                    int colOne = int.Parse(commands[2]);
                    int rowTwo = int.Parse(commands[3]);
                    int colTwo = int.Parse(commands[4]);

                    if (IsValid(rowOne,colOne,rowTwo,colTwo, matrix))
                    {
                        Swap(rowOne, colOne, rowTwo, colTwo, matrix);
                        
                        Printing(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                commands = Console.ReadLine().Split(" ");
            }
        }
        private static bool IsValid(int rowOne, int colOne, int rowTwo, int colTwo, string[,] matrix)
        {
            if (rowOne >= 0 && rowOne < matrix.GetLength(0) 
                            && colOne >= 0 && colOne < matrix.GetLength(1) 
                            && rowTwo >= 0 && rowTwo < matrix.GetLength(0)
                            && colTwo >= 0 && colTwo < matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }
        private static void Swap(int rowOne, int colOne, int rowTwo, int colTwo, string[,] matrix)
        {
            string temp = matrix[rowOne,colOne];
            matrix[rowOne,colOne] = matrix[rowTwo,colTwo];
            matrix[rowTwo, colTwo] = temp;
        }
        private static void Printing(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
