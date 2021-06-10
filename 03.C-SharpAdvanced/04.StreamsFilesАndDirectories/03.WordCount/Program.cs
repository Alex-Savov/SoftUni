using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.WordCount
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader inputRdr = new StreamReader("input.txt"))
            {
                string text = await inputRdr.ReadToEndAsync();

                using (StreamReader wordsRdr = new StreamReader("words.txt"))
                {
                    string words = await wordsRdr.ReadToEndAsync();
                    string[] wordsArr = words
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    Dictionary<string, int> wordsToFrequency = new Dictionary<string, int>();

                    foreach (var word in wordsArr)
                    {
                        Regex rgx = new Regex($@"\W{word}\W", RegexOptions.IgnoreCase);
                        MatchCollection matches = rgx.Matches(text);
                        wordsToFrequency.Add(word, matches.Count);
                    }

                    wordsToFrequency = wordsToFrequency
                        .OrderByDescending(x => x.Value)
                        .ToDictionary(x => x.Key, y => y.Value);

                    using (StreamWriter outputWriter = new StreamWriter("output.txt"))
                    {
                        foreach (var item in wordsToFrequency)
                        {
                            await outputWriter.WriteLineAsync($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
