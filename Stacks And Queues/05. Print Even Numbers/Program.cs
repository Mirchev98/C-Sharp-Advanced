using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();
            
            foreach (var currInput in input)
            {
                if (currInput % 2 == 0)
                {
                    queue.Enqueue(currInput);
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
