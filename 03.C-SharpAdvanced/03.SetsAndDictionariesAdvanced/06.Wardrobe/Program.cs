using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var closet = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = tokens[0];
                string[] clothes = tokens[1]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!closet.ContainsKey(color))
                {
                    closet.Add(color, new Dictionary<string, int>());
                }

                foreach (var cloth in clothes)
                {
                    if (!closet[color].ContainsKey(cloth))
                    {
                        closet[color].Add(cloth, 0);
                    }

                    closet[color][cloth]++;
                }
            }

            string[] lookUp = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in closet)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in color.Value)
                {
                    Stopwatch timer = Stopwatch.StartNew();

                    if (cloth.Key == lookUp[1] && color.Key == lookUp[0])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                    timer.Stop();
                    Console.WriteLine(timer.ElapsedMilliseconds);
                }
            }
        }
    }
}
