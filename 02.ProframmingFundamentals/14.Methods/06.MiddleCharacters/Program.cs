using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string midlleCharacters = GetMiddleChars(text);
            Console.WriteLine(midlleCharacters);
        }
        static string GetMiddleChars (string text)
        {
            string midChars = string.Empty;
            if (text.Length % 2 == 0)
            {
                midChars += text[(text.Length / 2) - 1];
                midChars += text[text.Length / 2];
            }
            else
            {
                midChars += text[text.Length / 2];
            }

            return midChars;
        }
    }
}
