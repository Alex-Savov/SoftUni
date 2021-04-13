using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+([3][5][9])(\s|-)[2]\3[0-9]{3}\3[0-9]{4})\b";
            string input = Console.ReadLine();

            Regex reg = new Regex(pattern);

            MatchCollection matches = reg.Matches(input);

            //string[] phoneMatches = matches
            //    .Cast<Match>()
            //    .Select(a => a.Value.Trim())
            //    .ToArray();

            //Console.WriteLine(string.Join(", ", phoneMatches));
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
