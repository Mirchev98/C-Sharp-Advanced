using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int numbersToPush = commands[0];
            int elementsToPop = commands[1];
            int toFind = commands[2];

            int[] inputStackToBe = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(inputStackToBe[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
                if (!stack.Any())
                {
                    Console.WriteLine(0);
                    break;
                }
            }

            if (stack.Contains(toFind) && stack.Any())
            {
                Console.WriteLine("true");
            }
            else if (stack.Any())
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
