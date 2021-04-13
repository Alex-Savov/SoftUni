using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
          List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .Where(x => x > 0)
                .ToList();

            Console.WriteLine(numbers.Count == 0 ? "empty" : string.Join(' ', numbers));
        }
    }
}
