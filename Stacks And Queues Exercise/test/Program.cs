using System;
using System.Collections.Generic;
using System.Linq;

namespace shunting_yard_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Determine if the expression is balanced- Done
            //2 Evaluate a postfix expression-Done
            //3 Convert from postfix to infix-In progress
            // when we reach  operator we pop from the stack two numbers. the top element goes right, the second element goes left! The operator goes to the middle
            // pecedence:
            //(1: ),},]
            //(2: *,/,%
            //(3: +,-
            //(4: (,{,[

            Dictionary<char, int> pecedence = new Dictionary<char, int>();
            pecedence['*'] = 2;
            pecedence['/'] = 2;
            pecedence['%'] = 2;
            pecedence['+'] = 1;
            pecedence['-'] = 1;
            pecedence['('] = 0;
            pecedence['{'] = 0;
            pecedence['['] = 0;

            string expression = Console.ReadLine();
            Queue<char> queue = new Queue<char>();
            Stack<char> stack = new Stack<char>();
            bool isBalancedExpression = isBalanced(expression);
            char[] array = expression.ToCharArray();
            if (isBalancedExpression)
            {

                EvaluatePostfixMethоd(pecedence, queue, stack, array);
                if (stack.Any())
                {
                    while (stack.Count > 0)
                    {
                        char current = stack.Pop();
                        queue.Enqueue(current);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid expression. Please try again.");
                return;
            }
            Console.WriteLine($"Result after Evaluate Postfix: {string.Join(", ", queue)}");
            Stack<int> results = new Stack<int>();
            while (queue.Any())
            {
                char current = queue.Dequeue();
                if (char.IsDigit(current))
                {
                    results.Push(current - 48);
                    continue;
                }
                else
                {
                    if (results.Count >= 2)
                    {
                        char symbol = current;
                        int secondNumber = results.Pop();
                        int firstNumber = results.Pop();
                        int result = SumResult(firstNumber, secondNumber, symbol);
                        results.Push(result);

                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine($"Final result is: {String.Join("", results)}");
        }

        static int SumResult(int secondNumber, int firstNumber, char symbol)
        {
            int result = 0;
            if (symbol == '+')
            {
                result = secondNumber + firstNumber;
            }
            else if (symbol == '-')
            {
                result = secondNumber - firstNumber;
            }
            else if (symbol == '*')
            {
                result = secondNumber * firstNumber;
            }
            else if (symbol == '/')
            {
                result = secondNumber / firstNumber;
            }
            return result;
        }

        private static void EvaluatePostfixMethоd(Dictionary<char, int> advantages, Queue<char> queue, Stack<char> stack, char[] array)
        {
            foreach (char symbol in array)
            {
                if (char.IsDigit(symbol))
                {
                    queue.Enqueue(symbol);
                    continue;
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(symbol);
                        continue;
                    }
                    else if (symbol == ')' || symbol == '}' || symbol == ']')
                    {
                        char bracket = symbol;
                        char bracketToSearch = ' ';
                        if (bracket == ']')
                        {
                            bracketToSearch = '[';
                        }
                        else if (bracket == '}')
                        {
                            bracketToSearch = '{';
                        }
                        else if (bracket == ')')
                        {
                            bracketToSearch = '(';
                        }
                        char current = stack.Pop();
                        if (bracketToSearch != current)
                        {
                            while (true)
                            {
                                if (current == bracketToSearch)
                                {
                                    break;
                                }
                                queue.Enqueue(current);

                                current = stack.Pop();
                            }
                        }

                    }
                    else
                    {
                        char currentStackElement = stack.Peek();
                        if ((advantages[symbol] > advantages[currentStackElement]) && (symbol != '(' && symbol != '{' && symbol != '['))
                        {
                            stack.Push(symbol);
                        }
                        else if (symbol == '(' || symbol == '[' && symbol == '{')
                        {
                            stack.Push(symbol);
                        }
                        else
                        {
                            char elementToPop = stack.Pop();
                            queue.Enqueue(elementToPop);
                            stack.Push(symbol);
                        }
                    }
                }
            }
        }

        static bool isBalanced(string expression)
        {
            Stack<char> brackets = new Stack<char>();
            List<char> extractedBrackets = new List<char>();
            ExtrackBrackets(expression, extractedBrackets);
            foreach (char bracket in extractedBrackets)
            {
                if (bracket == ')')
                {
                    if (brackets.Any())
                    {
                        char currentBracket = brackets.Pop();
                        if (currentBracket == '(')
                        {
                            continue;
                        }
                        brackets.Push(currentBracket);
                    }
                }
                else if (bracket == ']')
                {
                    if (brackets.Any())
                    {
                        char currentBracket = brackets.Pop();
                        if (currentBracket == '[')
                        {
                            continue;
                        }
                        brackets.Push(currentBracket);
                    }
                }
                else if (bracket == '}')
                {
                    if (brackets.Any())
                    {
                        char currentBracket = brackets.Pop();
                        if (currentBracket == '{')
                        {
                            continue;
                        }
                        brackets.Push(currentBracket);
                    }
                }
                else
                {
                    brackets.Push(bracket);
                }
            }
            if (brackets.Count > 0)
            {
                return false;
            }
            return true;
        }

        static void ExtrackBrackets(string expression, List<char> list)
        {
            foreach (char symbol in expression)
            {
                if (symbol == '(' || symbol == ')')
                {
                    list.Add(symbol);
                }
                else if (symbol == '[' || symbol == ']')
                {
                    list.Add(symbol);
                }
                else if (symbol == '{' || symbol == '}')
                {
                    list.Add(symbol);
                }
            }
        }
    }
}
