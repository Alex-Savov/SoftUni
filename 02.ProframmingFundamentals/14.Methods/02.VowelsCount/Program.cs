using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelsNumber = CountVowels(text);
            Console.WriteLine(vowelsNumber);
        }
        static int CountVowels (string text)
        {
            text = text.ToLower();
            int count = 0;
            string vowels = "aeiou";

            foreach (var letter in text)
            {
                foreach (var vowel in vowels)
                {
                    if (letter == vowel)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
