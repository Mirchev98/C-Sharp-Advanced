using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }

            string[] cmd = Console.ReadLine().Split(" ");

            while (cmd[0] != "END")
            {
                int currentRow = int.Parse(cmd[1]);
                int currentCollumn = int.Parse(cmd[2]);
                int number = int.Parse(cmd[3]);

                if (currentRow >= 0 && currentRow < jagged.GetLength(0) &&  currentCollumn < jagged[currentRow].Length && currentCollumn >= 0)
                {
                    if (cmd[0] == "Add")
                    {
                        jagged[currentRow][currentCollumn] += number;
                    }
                    else if (cmd[0] == "Subtract")
                    {
                        jagged[currentRow][currentCollumn] -= number;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                cmd = Console.ReadLine().Split(" ");
            }

            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                Console.WriteLine(String.Join(" ", jagged[row]));
            }
        }
    }
}
