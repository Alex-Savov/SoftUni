using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int[] secArray = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            bool isIdentical = false;
            int diffIndex = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secArray[i])
                {
                    isIdentical = false;
                    diffIndex = i;
                    break;
                }
                else
                {
                    isIdentical = true;
                }
            }

            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {firstArray.Sum()}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {diffIndex} index");
            }
        }
    }
}
