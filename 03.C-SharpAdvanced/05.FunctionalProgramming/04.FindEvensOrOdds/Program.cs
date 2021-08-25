using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Predicate<int> predicate = Console.ReadLine() == "even"
                ? num => num % 2 == 0
                : new Predicate<int>(num => num % 2 != 0);

            List<int> result = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
