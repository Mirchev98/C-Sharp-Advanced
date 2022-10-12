using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string currentName = Console.ReadLine();
                names.Add(currentName);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
