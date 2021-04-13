using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] competitors = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> results = new Dictionary<string, int>();

            foreach (var competitor in competitors)
            {
                results.Add(competitor, 0);
            }

            string namePattern = @"[\W\d]";
            string numbersPattern = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                int distance = Regex.Replace(input, numbersPattern, "")
                    .ToCharArray()
                    .Select(x => x.ToString())
                    .Select(int.Parse)
                    .ToArray()
                    .Sum();

                if (results.ContainsKey(name))
                {
                    results[name] += distance;
                }

                input = Console.ReadLine();
            }

            results = results
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            int count = 1;

            foreach (var result in results)
            {
                string sufix = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count}{sufix} place: {result.Key}");

                if (count == 3)
                {
                    break;
                }

                count++;
            }
        }
    }
}
