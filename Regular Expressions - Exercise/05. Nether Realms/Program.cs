using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string separator = @"[,\s]+";
            string health = @"[^\+\-\*\/\.,0-9]";
            string damage = @"-?\d+\.?\d*";
            string multiplyer = @"[\*\/]";
            
            string[] demons = Regex.Split(text, separator).OrderBy(x => x).ToArray();
            
            foreach (var demon in demons)
            {
                MatchCollection healthMatches = Regex.Matches(demon, health);
                int currHealth = 0;
                foreach (Match healthMatch in healthMatches)
                {
                    char currChar = char.Parse(healthMatch.Value);
                    currHealth += currChar;
                }

                MatchCollection dmgMatch = Regex.Matches(demon, damage);
                double currDamage = 0;
                foreach (Match dmg in dmgMatch)
                {
                    double damagge = double.Parse(dmg.ToString());
                    currDamage += damagge;
                }

                MatchCollection multMatch = Regex.Matches(demon, multiplyer);
                foreach (Match mult in multMatch)
                {
                    char multiplayer = char.Parse(mult.ToString());
                    if (multiplayer == '*')
                    {
                        currDamage *= 2;
                    }
                    else
                    {
                        currDamage /= 2;
                    }
                }

                Console.WriteLine($"{demon} - {currHealth} health, {currDamage:f2} damage");
            }
        }
    }
}
