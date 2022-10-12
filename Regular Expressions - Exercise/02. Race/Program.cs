using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ");
            string namePattern = @"(?<name>[A-Za-z]+)";
            string distancePattern = @"[\d]+";
            
            Dictionary<string, int> runners = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection nameMatch = Regex.Matches(input, namePattern);
                string name = string.Join("", nameMatch);
                MatchCollection distanceMatch = Regex.Matches(input, distancePattern);
                string distanceString = string.Join("", distanceMatch);
                int currentDistance = 0;
                for (int i = 0; i < distanceString.Length; i++)
                {
                    currentDistance += int.Parse(distanceString[i].ToString());
                }

                if (participants.Contains(name))
                {
                    if (!runners.ContainsKey(name))
                    {
                        runners.Add(name, 0);
                    }

                    runners[name] += currentDistance;
                }
                input = Console.ReadLine();
            }

            Dictionary<string, int> orderedRunners = runners.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            int counter = 0;

            foreach (var runner in orderedRunners)
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {runner.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {runner.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {runner.Key}");
                    break;
                }
            }
        }

    }
}
