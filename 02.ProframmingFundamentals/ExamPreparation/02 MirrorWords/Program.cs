using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02_MirrorWords
{
    class MirrorWords
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }
        public override string ToString()
        {
            return $"{FirstWord} <=> {SecondWord}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#]{1})(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";
            Regex pairsRgx = new Regex(pattern);
            string text = Console.ReadLine();
            MatchCollection matches = pairsRgx.Matches(text);
            List<MirrorWords> mirrorWords = new List<MirrorWords>();

            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["firstWord"].Value;
                string seconWord = match.Groups["secondWord"].Value;

                if (MirrorWordsValidator(firstWord, seconWord))
                {
                    mirrorWords.Add(new MirrorWords { FirstWord = firstWord, SecondWord = seconWord });
                }
            }

            if (mirrorWords.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords.Select(x => x.ToString())));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }

        }
        public static bool MirrorWordsValidator (string firstWord, string secondWord)
        {
            bool isMirror = true;

            if (firstWord.Length != secondWord.Length)
            {
                return false;
            }

            for (int i = 0; i < firstWord.Length; i++)
            {
                if (!(firstWord[i] == secondWord[secondWord.Length - 1 - i]))
                {
                    isMirror = false;
                    break;
                }
            }

            return isMirror;
        }
    }
}
