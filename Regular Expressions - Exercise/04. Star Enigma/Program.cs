using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            string pattern = @"@(?<planet>[A-z]+)[^@\-!:>]*?:(?<population>[\d]+)[^@\-!:>]*?!(?<attack>[A, D])![^@\-!:>]*?->(?<soldiers>[\d]+)[^@\-!:>]*?";
            
            List<string> destroyedPlanets = new List<string>();
            List<string> attackedPlanets = new List<string>();
            
            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();
                int charCount = 0;
                string lowerText = text.ToLower();
                
                foreach (var character in lowerText)
                {
                    if (character == 's' || character == 't' || character == 'a' || character == 'r')
                    {
                        charCount++;
                    }
                }

                string decrypted = "";
                foreach (var symbol in text)
                {
                    decrypted += (char)(symbol - charCount);
                }
                
                Match match = Regex.Match(decrypted, pattern, RegexOptions.IgnoreCase);
                
                if (match.Success)
                {
                    string planetStatus = match.Groups["attack"].Value;
                    if (planetStatus == "A")
                    {
                        attackedPlanets.Add(match.Groups["planet"].ToString());
                    }
                    else
                    {
                        destroyedPlanets.Add(match.Groups["planet"].ToString());
                    }
                }
            }
            attackedPlanets.Sort();
            destroyedPlanets.Sort();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

        }
    }
}
