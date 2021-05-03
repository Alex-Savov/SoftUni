using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] elementsTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var token in elementsTokens)
                {
                    elements.Add(token);
                }
            }

            Console.WriteLine(string.Join(' ', elements));
        }
    }
}
