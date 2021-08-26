using System;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxN = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int, bool> divideBySequenceOfNumbers = (dividers, divided) =>
            {
                foreach (var item in dividers)
                {
                    if (divided % item != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            //for (int i = 1; i <= maxN; i++)
            //{
            //    if (divideBySequenceOfNumbers(dividers, i))
            //    {
            //        Console.Write(i);
            //        if (i != maxN)
            //        {
            //            Console.Write(' ');
            //        }
            //    }
            //}

            int[] filteredNumbers = Enumerable.Range(1, maxN)
                .Where(n => divideBySequenceOfNumbers(dividers, n))
                .ToArray();

            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}
