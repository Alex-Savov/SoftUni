using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.EvenLines
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] lines = await File.ReadAllLinesAsync("text.txt");
            Regex rgx = new Regex(@"[-,.!?]");

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 == 0)
                {
                    string line = string
                        .Join(" ", lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
                    line = rgx.Replace(line, "@");

                    Console.WriteLine(line);
                }
            }
        }
    }
}
