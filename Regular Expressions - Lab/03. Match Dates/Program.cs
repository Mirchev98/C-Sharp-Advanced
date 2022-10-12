using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<date>[0-9]{2})(?<separator>[./-])(?<month>[A-Z][a-z]{2})\<separator>(?<year>[0-9]{4})";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["date"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}
