using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*?<(?<product>[\w]+)>[^|$%.]*?\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[0-9]+.?[\d]+)\$";
            double totalIncome = 0;
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    int quantity = int.Parse(match.Groups["count"].ToString());
                    double price = double.Parse(match.Groups["price"].ToString());
                    double totalPrice = quantity * price;
                    Console.WriteLine($"{match.Groups["customer"]}: {match.Groups["product"]} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                    
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
