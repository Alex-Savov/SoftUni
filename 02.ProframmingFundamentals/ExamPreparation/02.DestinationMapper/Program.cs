using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=\/])(?<destination>[A-Za-z]{3,})\1";
            Regex destinationRgx = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = destinationRgx.Matches(input);

            int points = 0;

            foreach (Match match in matches)
            {
                points += match.Groups["destination"].Value.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", matches.Select(x => x.Groups["destination"].Value))}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
