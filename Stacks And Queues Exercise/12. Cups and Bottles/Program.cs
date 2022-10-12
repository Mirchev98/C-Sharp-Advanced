using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputCups = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] inputBottles = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(inputCups);
            Stack<int> bottles = new Stack<int>(inputBottles);

            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                int currentCup = 0;
                if (currentCup <= 0)
                {
                    currentCup = cups.Dequeue();
                }
                int currentBottle = bottles.Pop();

                if (currentBottle >= currentCup)
                {
                    wastedWater += currentBottle - currentCup;
                    currentCup = 0;
                }
                else if (currentCup > currentBottle)
                {
                    while (currentCup > 0)
                    {
                        if (currentBottle >= currentCup)
                        {
                            wastedWater += currentBottle - currentCup;
                            currentCup = 0;
                        }
                        else
                        {
                            currentCup -= currentBottle;
                        }
                        if (currentCup > 0)
                        {
                            currentBottle = bottles.Pop();
                        }


                    }
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
