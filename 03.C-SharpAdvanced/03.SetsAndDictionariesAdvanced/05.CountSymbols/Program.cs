using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> charToCount = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!charToCount.ContainsKey(text[i]))
                {
                    charToCount.Add(text[i], 0);
                }

                charToCount[text[i]]++;
            }

            foreach (var ch in charToCount)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
