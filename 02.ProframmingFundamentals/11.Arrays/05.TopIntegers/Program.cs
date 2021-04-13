using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bool isBigger = true ;
                for (int j = i; j < arr.Length -1; j++)
                {
                    if (arr[i] <= arr[j + 1])
                    {
                        isBigger = false;
                    }
                }
                if (isBigger)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
    }
}
