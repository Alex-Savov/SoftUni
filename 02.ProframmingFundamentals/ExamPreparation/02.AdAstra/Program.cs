using System;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#|\|)(?<item>[A-Za-z\s]+)\1(?<date>(?:[0-2][0-9]|3[0-1])\/(?:0[1-9]|1[0-2])\/[0-9][0-9])\1(?<calories>\d+)\1";
            Regex itemRgx = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = itemRgx.Matches(input);

            int calories = 0;

            foreach (Match match in matches)
            {
                calories += int.Parse(match.Groups["calories"].Value);
            }

            int days = calories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["item"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
