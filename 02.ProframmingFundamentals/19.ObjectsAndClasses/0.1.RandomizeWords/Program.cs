using System;
using System.Collections.Generic;

namespace _0._1.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int possition = rnd.Next(words.Length);

                string temp = words[i];
                words[i] = words[possition];
                words[possition] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
