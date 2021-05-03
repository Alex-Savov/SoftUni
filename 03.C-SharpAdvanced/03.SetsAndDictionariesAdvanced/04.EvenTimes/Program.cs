using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for (int i = 0; i < lines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!pairs.ContainsKey(number))
                {
                    pairs.Add(number, 0);
                }

                pairs[number]++;
            }

            foreach (var pair in pairs)
            {
                if (pair.Value % 2 == 0)
                {
                    Console.WriteLine(pair.Key);
                    break;
                }
            }
        }
    }
}
