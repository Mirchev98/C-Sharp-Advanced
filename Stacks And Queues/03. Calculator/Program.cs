using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();

            Stack<string> stack = new Stack<string>(input);
            
            int result = 0;
            result += int.Parse(stack.Pop());
            
            while (stack.Count > 0)
            {
                string operant = stack.Pop();

                if (operant == "+")
                {
                    result += int.Parse(stack.Pop());
                }
                else
                {
                    result -= int.Parse(stack.Pop());
                }
            }

            Console.WriteLine(result);
        }
    }
}
