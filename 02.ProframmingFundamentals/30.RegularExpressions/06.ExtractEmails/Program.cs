using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Za-z0-9])+[\._\-]?[A-Za-z0-9]+@([A-Za-z]+\-*[A-Za-z]+)(\.[A-Za-z]+\-*[A-Za-z]+)+\b";
            Regex rgx = new Regex(pattern);
            string text = Console.ReadLine();
            MatchCollection matches = rgx.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
