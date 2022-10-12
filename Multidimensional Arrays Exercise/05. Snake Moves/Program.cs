using System;
using System.Linq;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            string snake = Console.ReadLine();

            int counter = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                        
                        matrix[row, col] = snake[counter].ToString();
                        counter++;
                    }

                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }

                        matrix[row, col] = snake[counter].ToString();
                        counter++;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
