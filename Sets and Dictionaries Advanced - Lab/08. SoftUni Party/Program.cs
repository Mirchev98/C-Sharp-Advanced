using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regulars = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "PARTY")
            {
                if (command[0] >= 48 && command[0] <= 57)
                {
                    vip.Add(command);
                }
                else
                {
                    regulars.Add(command);
                }
                command = Console.ReadLine();
            }

            string nextCommand = Console.ReadLine();

            while (nextCommand != "END")
            {
                if (vip.Contains(nextCommand))
                {
                    vip.Remove(nextCommand);
                }
                else
                {
                    regulars.Remove(nextCommand);
                }
                nextCommand = Console.ReadLine();
            }

            Console.WriteLine($"{vip.Count + regulars.Count}");

            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regulars)
            {
                Console.WriteLine(guest);
            }
        }
    }
}