using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicate = Console.ReadLine() == "even"
               ? num => num % 2 == 0
               : new Predicate<int>(num => num % 2 != 0);

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => predicate(n))
                .ToList()
                .ForEach(n => Console.Write($"{n} "));
        }
    }
}
