using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> color = new Dictionary<string, Dictionary<string, int>>();

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string[] cmd = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 1; j < cmd.Length; j++)
                {
                    if (!color.ContainsKey(cmd[0]))
                    {
                        color.Add(cmd[0], new Dictionary<string, int>());
                    }

                    if (!color[cmd[0]].ContainsKey(cmd[j]))
                    {
                        color[cmd[0]].Add(cmd[j], 0);
                    }

                    color[cmd[0]][cmd[j]] += 1;
                }
            }

            string[] toFind = Console.ReadLine().Split(" ");

            foreach (var currentColor in color)
            {
                Console.WriteLine($"{currentColor.Key} clothes:");
                foreach (var currentClothing in currentColor.Value)
                {
                    if (currentColor.Key == toFind[0] && currentClothing.Key == toFind[1])
                    {
                        Console.WriteLine($"* {currentClothing.Key} - {currentClothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {currentClothing.Key} - {currentClothing.Value}");
                    }
                }
            }
        }
    }
}
