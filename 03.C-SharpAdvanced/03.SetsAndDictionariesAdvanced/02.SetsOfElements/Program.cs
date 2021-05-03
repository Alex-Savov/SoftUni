using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setLenght = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> first = new HashSet<int>(setLenght[0]);
            HashSet<int> second = new HashSet<int>(setLenght[1]);

            for (int i = 1; i <= setLenght[0] + setLenght[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i <= setLenght[0])
                {
                    first.Add(num);
                }
                else
                {
                    second.Add(num);
                }
            }

            foreach (var num in first)
            {
                foreach (var number in second)
                {
                    if (num == number)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
        }
    }
}
