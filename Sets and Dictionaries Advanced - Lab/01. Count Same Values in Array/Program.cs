using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> numbers = new Dictionary<double, int>();

            double[] input = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            foreach (var currentNumber in input)
            {
                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(currentNumber, 0);
                }

                numbers[currentNumber]++;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
