using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPumps = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < totalPumps; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                pumps.Enqueue(input);
            }

            int startPump = 0;

            while (true)
            {
                int fuel = 0;

                bool rightPump = true;

                foreach (var inputs in pumps)
                {
                    fuel += inputs[0];

                    if (fuel - inputs[1] >= 0)
                    {
                        fuel -= inputs[1];
                    }
                    else
                    {
                        rightPump = false;
                        break;
                    }
                }

                if (rightPump)
                {
                    Console.WriteLine(startPump);
                    break;
                }
                else
                {
                    pumps.Enqueue(pumps.Dequeue());
                    startPump ++;
                }
            }
        }
    }
}
