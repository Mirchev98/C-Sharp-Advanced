using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push(String.Empty);

            int iterations = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < iterations; i++)
            {
                string[] cmd = Console.ReadLine().Split(' ');

                switch (cmd[0])
                {
                    case "1":
                        sb.Append(cmd[1]);
                        stack.Push(sb.ToString());
                        break;
                    case "2":
                        int erase = int.Parse(cmd[1]);
                        sb.Remove(sb.Length - erase, erase);
                        stack.Push(sb.ToString());
                        break;
                    case "3":
                        int index = int.Parse(cmd[1]) - 1;
                        Console.WriteLine(sb[index]);
                        break;
                    case "4":
                        stack.Pop();
                        sb = new StringBuilder();
                        sb.Append(stack.Peek());
                        break;
                }
            }
        }
    }
}
