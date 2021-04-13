using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            text = StringRepeater(n, text);
            Console.WriteLine(text);
        }
        static string StringRepeater(int rep, string text)
        {
            StringBuilder repeatedText = new StringBuilder();

            for (int i = 0; i < rep; i++)
            {
                repeatedText.Append(text);
            }

            return repeatedText.ToString();
        }
    }
}
