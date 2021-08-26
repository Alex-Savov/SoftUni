using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Predicate<string> stringLenght = name => name.Length <= n;
            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(n => stringLenght(n))
                .ToList()
                .ForEach(n => Console.WriteLine(n));
        }
    }
}
