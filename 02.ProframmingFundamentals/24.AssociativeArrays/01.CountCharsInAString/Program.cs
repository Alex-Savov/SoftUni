using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char ch in text)
            {
                if (ch == ' ')
                {
                    continue;
                }

                if (result.ContainsKey(ch))
                {
                    result[ch]++;
                }
                else
                {
                    result.Add(ch, 1);
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
