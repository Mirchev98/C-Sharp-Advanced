using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();
            
            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            string commands = Console.ReadLine().ToLower();

            while (commands != "end")
            {
                string[] cmd = commands.Split(' ');

                if (cmd[0] == "add")
                {
                    int numOne = int.Parse(cmd[1]);
                    int numTwo = int.Parse(cmd[2]);
                    stack.Push(numOne);
                    stack.Push(numTwo);
                }
                else if (cmd[0] == "remove")
                {
                    int count = int.Parse(cmd[1]);
                    if (stack.Count <= count)
                    {
                        commands = Console.ReadLine().ToLower();
                        continue;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        stack.Pop();
                    }
                }
                commands = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
