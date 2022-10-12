using System;
using System.Collections;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> integers = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    integers.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = integers.Pop();
                    string sub = input.Substring(start, i - start + 1);
                    Console.WriteLine(sub);
                }
            }
        }
    }
}
