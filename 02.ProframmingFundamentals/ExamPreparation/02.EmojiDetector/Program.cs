using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";
            Regex rgxEmoji = new Regex(emojiPattern);
            string digitsPattern = @"\d";
            Regex rgxDigit = new Regex(digitsPattern);

            string text = Console.ReadLine();
            MatchCollection digitMatches = rgxDigit.Matches(text);

            BigInteger treshhold = new BigInteger(1);

            foreach (Match match in digitMatches)
            {
                treshhold *= int.Parse(match.Value);
            }

            Console.WriteLine($"Cool threshold: {treshhold}");

            MatchCollection emojiMatches = rgxEmoji.Matches(text);

            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in emojiMatches)
            { 
                int coolnes = match.Value
                    .Where(x => char.IsLetter(x))
                    .Select(Convert.ToInt32)
                    .Sum();

                if (coolnes > treshhold)
                {
                    Console.WriteLine(match.Value); ;
                }
            }
        }
    }
}
