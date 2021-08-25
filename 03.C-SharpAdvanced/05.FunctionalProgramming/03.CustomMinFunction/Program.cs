using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallestNumberFinder = (numbers) =>
            {
                int numMin = int.MaxValue;

                foreach (var number in numbers)
                {
                    if (number < numMin)
                    {
                        numMin = number;
                    }
                }

                return numMin;
            };

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(smallestNumberFinder(numbers));
        }
    }
}
