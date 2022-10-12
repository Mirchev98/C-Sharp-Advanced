using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split(" ");
            int burn = int.Parse(Console.ReadLine());

            Queue<string> game = new Queue<string>(kids);
            int count = 0;
            while (game.Count > 1)
            {
                count++;
                if (count == burn)
                {
                    Console.WriteLine($"Removed {game.Dequeue()}");
                    count = 0;
                    continue;
                }
                string currentKid = game.Dequeue();
                game.Enqueue(currentKid);

            }

            Console.WriteLine($"Last is {game.Dequeue()}");
        }
    }
}
