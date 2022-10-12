using System;
using System.Data;
using System.Linq;

namespace _05._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = matrixInfo[0];
            int cols = matrixInfo[1];
            
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int bestSum = 0;
            int[] bestStart = new int[2];
            int[] bestEnd = new int[2];

            for (int row = 0; row < rows - 1; row++)
            {
                int tempSum = 0;

                for (int col = 0; col < cols - 1; col++)
                {
                    tempSum += matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (tempSum >= bestSum)
                    {
                        if (tempSum == bestSum)
                        {
                            if (bestStart[0] > matrix[row, col])
                            {
                                bestStart[0] = matrix[row, col];
                                bestStart[1] = matrix[row, col + 1];
                                bestEnd[0] = matrix[row + 1, col];
                                bestEnd[1] = matrix[row + 1, col + 1];
                            }
                        }
                        else
                        {
                            bestSum = tempSum;

                            bestStart[0] = matrix[row, col];
                            bestStart[1] = matrix[row, col + 1];
                            bestEnd[0] = matrix[row + 1, col];
                            bestEnd[1] = matrix[row + 1, col + 1];
                        }
                    }

                    tempSum = 0;
                }
            }

            Console.WriteLine(String.Join(" ", bestStart));
            Console.WriteLine(String.Join(" ", bestEnd));
            Console.WriteLine(bestSum);
        }
    }
}
