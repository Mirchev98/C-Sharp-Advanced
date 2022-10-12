using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> charTimesOccurance = new SortedDictionary<char, int>();

            string input = Console.ReadLine();

            foreach (var character in input)
            {
                if (!charTimesOccurance.ContainsKey(character))
                {
                    charTimesOccurance.Add(character, 0);
                }

                charTimesOccurance[character] += 1;
            }

            foreach (var character in charTimesOccurance)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
