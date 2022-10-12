using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            
            for (int i = 0; i < iterations; i++)
            {
                int[] cmd = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int currentCommand = cmd[0];

                switch (currentCommand)
                {
                    case 1:
                        stack.Push(cmd[1]);
                        break;
                    
                    case 2:
                        stack.Pop();
                        break;
                    
                    case 3:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    
                    case 4:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
