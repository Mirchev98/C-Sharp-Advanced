using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
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

            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int num = 0; num < jagged[row].Length; num++)
                    {
                        jagged[row][num] *= 2;
                        jagged[row + 1][num] *= 2;
                    }
                }
                else
                {
                    for (int num = 0; num < jagged[row].Length; num++)
                    {
                        jagged[row][num] /= 2;
                    }
                    for (int num = 0; num < jagged[row + 1].Length; num++)
                    {
                        jagged[row + 1][num] /= 2;
                    }
                }
            }

            string[] commands = Console.ReadLine().Split(" ");

            while (commands[0] != "End")
            {
                int rowFirst = int.Parse(commands[1]);
                int colFirst = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if (IsValid(rowFirst, colFirst, jagged))
                {
                    switch (commands[0])
                    {
                        case "Add":
                            jagged[rowFirst][colFirst] += value;
                            break;
                        case "Subtract":
                            jagged[rowFirst][colFirst] -= value;
                            break;
                    }
                }

                commands = Console.ReadLine().Split(" ");
            }

            foreach (var arr in jagged)
            {
                Console.WriteLine(String.Join(" ", arr));
            }
        }

        static bool IsValid(int rowFirst, int colFirst, int[][] jagged)
        {
            if (rowFirst >= 0 && colFirst < jagged[rowFirst].Length)
            {
                return true;
            }

            return false;
        }
    }
}
