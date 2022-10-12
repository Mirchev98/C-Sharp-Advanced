using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pricePerBullet = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int payOff = int.Parse(Console.ReadLine());

            int shotBullets = 0;

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> lockQueue = new Queue<int>(locks);

            while (lockQueue.Any() && bulletsStack.Any())
            {
                for (int i = 0; i < barrelSize; i++)
                {
                    if (!bulletsStack.Any() || !lockQueue.Any())
                    {
                        break;
                    }
                    int currentBullet = bulletsStack.Pop();
                    int currentLock = lockQueue.Peek();
                    shotBullets++;
                    if (currentBullet <= currentLock)
                    {
                        Console.WriteLine("Bang!");
                        lockQueue.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                }

                if (!bulletsStack.Any() || !lockQueue.Any())
                {
                    if (bulletsStack.Any())
                    {
                        Console.WriteLine("Reloading!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Reloading!");
                }
            }

            int totalEarnings = payOff - (pricePerBullet * shotBullets);

            if (!lockQueue.Any())
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${totalEarnings}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {lockQueue.Count}");
            }
        }
    }
}
