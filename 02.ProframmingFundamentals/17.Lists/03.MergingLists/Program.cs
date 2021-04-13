using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstArr = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList(); 

            List<int> secondArr = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();


            List<int> mergedArr = new List<int>();

            for (int i = 0; i < Math.Min(firstArr.Count, secondArr.Count); i++)
            {
                mergedArr.Add(firstArr[i]);
                mergedArr.Add(secondArr[i]);
            }

            bool isFirstBigger = firstArr.Count > secondArr.Count;

            for (int i = Math.Min(firstArr.Count, secondArr.Count);
                i < Math.Max(firstArr.Count, secondArr.Count); i++)
            {
                if (isFirstBigger)
                {
                    mergedArr.Add(firstArr[i]);
                }
                else
                {
                    mergedArr.Add(secondArr[i]);
                }
            }

            Console.WriteLine(string.Join(' ', mergedArr));
        }
    }
}
