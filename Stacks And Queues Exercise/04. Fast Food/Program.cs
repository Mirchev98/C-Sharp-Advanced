using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodTotal = int.Parse(Console.ReadLine());

            int[] ordersInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(ordersInput);
            Console.WriteLine(orders.Max());
            
            bool serving = true;
            
            while (orders.Any())
            {
                int currentOrder = orders.Peek();

                if (foodTotal - currentOrder >= 0)
                {
                    orders.Dequeue();
                    foodTotal -= currentOrder;
                }
                else
                {
                    serving = false;
                    break;
                }
            }

            if (serving)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
            }
        }
    }
}
