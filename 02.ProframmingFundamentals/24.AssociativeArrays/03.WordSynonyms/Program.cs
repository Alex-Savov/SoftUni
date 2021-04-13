﻿using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < lines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonyms.ContainsKey(word))
                {
                    synonyms[word].Add(synonym);
                }
                else
                {
                    synonyms.Add(word, new List<string>() { synonym });
                }
            }

            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
