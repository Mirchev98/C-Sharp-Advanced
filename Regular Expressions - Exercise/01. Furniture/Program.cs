using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>[\d]+[\.\d]+)!(?<quantity>[\d]+)";
            string input = Console.ReadLine();
            double price = 0;
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    Console.WriteLine(match.Groups["name"]);
                    double currPrice = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    price += currPrice * quantity;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {price:f2}");
            

        }
    }
}
