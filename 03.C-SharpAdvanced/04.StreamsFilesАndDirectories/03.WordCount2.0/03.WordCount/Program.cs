using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = {'\\','/','’','(',')','{','}','[',']',':',';','”','!', ',','?','-','_','.',' '};
            string[] words = File.ReadAllLines("./words.txt")
                .Select(x => x.ToLower())
                .ToArray();
            string[] text = File.ReadAllText("./text.txt")
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToArray();
            Dictionary<string, int> wordsToCount = new Dictionary<string, int>();

            foreach (var keyWord in words)
            {
                foreach (var word in text)
                {
                    if (word == keyWord)
                    {
                        if (!wordsToCount.ContainsKey(word))
                        {
                            wordsToCount.Add(word, 0);
                        }
                        wordsToCount[word]++;
                    }
                }
            }

            wordsToCount = wordsToCount
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            using (StreamWriter wrtr = new StreamWriter("../../../output.txt"))
            {
                foreach (var item in wordsToCount)
                {
                    wrtr.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
