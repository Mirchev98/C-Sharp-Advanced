using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(input);

            int fullRacks = 0;
            int counter = 0;

            while (clothes.Any())
            {
                int currentClothing = clothes.Peek();

                if (counter + currentClothing <= rackCapacity)
                {
                    counter += currentClothing;
                    clothes.Pop();
                    if (counter == rackCapacity || !clothes.Any())
                    {
                        fullRacks++;
                        counter = 0;
                    }
                }
                else
                {
                    fullRacks ++;
                    counter = 0;
                }
            }

            Console.WriteLine(fullRacks);
        }
    }
}
