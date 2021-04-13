using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            SortedDictionary<int, int> filteredNumbers = new SortedDictionary<int, int>();


            foreach (var number in numbers)
            {
                if (!filteredNumbers.Any(x => x.Key == number))
                {
                    filteredNumbers.Add(number, 1);
                }
                else
                {
                    filteredNumbers[number]++;
                }
            }

            foreach (var item in filteredNumbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
