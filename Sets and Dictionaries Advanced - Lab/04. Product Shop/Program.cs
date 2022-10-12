using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> products = new Dictionary<string, Dictionary<string, double>>();

            string[] command = Console.ReadLine().Split(", ");

            while (command[0] != "Revision")
            {
                string shop = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);

                if (!products.ContainsKey(shop))
                {
                    products.Add(shop, new Dictionary<string, double>());
                }

                products[shop].Add(product, price);

                command = Console.ReadLine().Split(", ");
            }

            products = products.OrderBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);


            foreach (var shop in products)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
