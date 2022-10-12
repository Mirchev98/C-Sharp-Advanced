using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int numbersToPush = commands[0];
            int elementsToPop = commands[1];
            int toFind = commands[2];

            int[] inputQueueToBe = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            
            for (int i = 0; i < numbersToPush; i++)
            {
                queue.Enqueue(inputQueueToBe[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                queue.Dequeue();
                if (!queue.Any())
                {
                    Console.WriteLine(0);
                    break;
                }
            }

            if (queue.Any() && queue.Contains(toFind))
            {
                Console.WriteLine("true");
            }
            else if (!queue.Contains(toFind) && queue.Any())
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
