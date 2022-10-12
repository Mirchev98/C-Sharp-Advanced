using System;
using System.Collections.Generic;

namespace _08._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            bool isValid = true;

            for (int i = 0; i < input.Length / 2; i++)
            {
                stack.Push(input[i]);
            }

            int start = input.Length / 2;

            for (int i = start; i < input.Length; i++)
            {
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }
                char element = input[i];
                char currElement = stack.Pop();
                switch (element)
                {
                    case ')':
                        if (currElement != '(')
                        {
                            isValid = false;
                            break;
                        }
                        break;
                    case '}':
                        if (currElement != '{')
                        {
                            isValid = false;
                            break;
                        }
                        break;
                    case ']':
                        if (currElement != '[')
                        {
                            isValid = false;
                            break;
                        }
                        break;
                    case '(':
                        if (currElement != ')')
                        {
                            isValid = false;
                            break;
                        }
                        break;
                    case '{':
                        if (currElement != '}')
                        {
                            isValid = false;
                            break;
                        }
                        break;
                    case '[':
                        if (currElement != ']')
                        {
                            isValid = false;
                            break;
                        }
                        break;
                }

            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}