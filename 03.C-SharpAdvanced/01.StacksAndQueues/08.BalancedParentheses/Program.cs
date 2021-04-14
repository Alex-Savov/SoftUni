using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stackOpen = new Stack<char>();

            Regex rgx = new Regex(@"\(\)|{}|\[\]");
            bool isBalanced = true;

            foreach (var item in input)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stackOpen.Push(item);
                }
                else
                {
                    string current = string.Empty;

                    if (stackOpen.Count > 0)
                    {
                        current = $"{stackOpen.Peek()}{item}";
                    }

                    Match match = rgx.Match(current);

                    if (match.Success)
                    {
                        stackOpen.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
