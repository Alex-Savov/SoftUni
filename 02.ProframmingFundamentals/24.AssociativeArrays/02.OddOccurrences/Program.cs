using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToArray();

            Dictionary<string, int> elementsOccurance = new Dictionary<string, int>();

            foreach (string element in elements)
            {
                if (elementsOccurance.ContainsKey(element))
                {
                    elementsOccurance[element]++;
                }
                else
                {
                    elementsOccurance.Add(element, 1);
                }
            }

            Console.WriteLine(string.Join(' ', elementsOccurance
                .Where(x => x.Value % 2 != 0)
                .Select(x => x.Key)));
        }
    }
}
