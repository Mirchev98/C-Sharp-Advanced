using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();

            int inputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputs; i++)
            {
                string[] currentInput = Console.ReadLine().Split(' ');

                foreach (var currentElement in currentInput)
                {
                    elements.Add(currentElement);
                }
            }

            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
