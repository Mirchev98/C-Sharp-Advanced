using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Queue<string> customers = new Queue<string>();

            while (command != "End")
            {
                if (command == "Paid")
                {
                    while (customers.Any())
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");

        }
    }
}
