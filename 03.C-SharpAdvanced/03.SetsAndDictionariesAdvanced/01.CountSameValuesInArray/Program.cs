using System;
using System.Collections.Generic;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> count = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!count.ContainsKey(arr[i]))
                {
                    count.Add(arr[i], 0);
                }

                count[arr[i]]++;
            }

            foreach (var number in count)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
