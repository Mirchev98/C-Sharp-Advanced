using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continent =
                new Dictionary<string, Dictionary<string, List<string>>>();

            int inputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputs; i++)
            {
                string[] currentInput = Console.ReadLine().Split(' ');

                string currentContinent = currentInput[0];
                string country = currentInput[1];
                string city = currentInput[2];
                
                if (!continent.ContainsKey(currentContinent))
                {
                    continent.Add(currentContinent, new Dictionary<string, List<string>>());
                }

                if (!continent[currentContinent].ContainsKey(country))
                {
                    continent[currentContinent].Add(country, new List<string>());
                }

                continent[currentContinent][country].Add(city);
            }

            foreach (var currContinent in continent)
            {
                Console.WriteLine($"{currContinent.Key}:");
                foreach (var country in currContinent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
