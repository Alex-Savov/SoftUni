using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stackOpen = new Stack<char>();
            Queue<char> queueClose = new Queue<char>();

            Regex rgx = new Regex(@"\(\)|{}|\[\]");


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
                        queueClose.Enqueue(item);
                    }
                }
            }


            bool isBalanced = (stackOpen.Count == 0) && (queueClose.Count == 0);
            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
