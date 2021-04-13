using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToList();
            int maxIterations = numbers.Count / 2;

            for (int i = 0; i < maxIterations; i++)
            {
                numbers[i] += numbers.Last();
                numbers.Remove(numbers.Last());
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
