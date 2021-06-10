using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0._2.LineNumbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] lines = await File.ReadAllLinesAsync("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string letterPattern = @"\w";
                string punctPatterm = @"[\/’\(\){}\[\]:;”!\?\-_\.,']";
                MatchCollection lettersMatches = Regex.Matches(lines[i], letterPattern);
                MatchCollection punctMayches = Regex.Matches(lines[i], punctPatterm);
                lines[i] = $"Line {i + 1}: {lines[i]} ({lettersMatches.Count})({punctMayches.Count})";
            }

            await File.WriteAllLinesAsync("../../../output.txt", lines);
        }
    }
}
