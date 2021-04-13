using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            List<int> bomb = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int specialNumber = bomb[0];
            int bombRange = bomb[1];

            while (numbers.Contains(specialNumber))
            {
                for (int i = 0; i < bombRange; i++)
                {
                    int bombIndex = numbers.FindIndex(x => x == specialNumber);

                    if (bombIndex < numbers.Count - 1)
                    {
                        numbers.RemoveAt(bombIndex + 1);
                    }

                    if (bombIndex >= 1)
                    {
                        numbers.RemoveAt(bombIndex - 1);
                    }
                }
                numbers.Remove(specialNumber);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
