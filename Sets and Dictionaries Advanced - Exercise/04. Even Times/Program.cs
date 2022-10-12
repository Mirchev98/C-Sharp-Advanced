using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());

            Dictionary<int, int> evenTimesOccurance = new Dictionary<int, int>();

            for (int i = 0; i < inputs; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (!evenTimesOccurance.ContainsKey(currentNum))
                {
                    evenTimesOccurance[currentNum] = 0;
                }
                evenTimesOccurance[currentNum]++;
            }

            foreach (var numberTime in evenTimesOccurance)
            {
                if (numberTime.Value % 2 == 0)
                {
                    Console.WriteLine(numberTime.Key);
                }
            }
        }
    }
}
