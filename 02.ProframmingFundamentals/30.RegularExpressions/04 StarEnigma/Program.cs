using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04_StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            int lines = int.Parse(Console.ReadLine());
            string decryptPattern = @"[STARstar]";

            for (int i = 0; i < lines; i++)
            {
                string message = Console.ReadLine();
                MatchCollection matches = Regex.Matches(message, decryptPattern);

                StringBuilder decryptedMessage = new StringBuilder();
                int decryptionKey = matches.Count;

                foreach (char ch in message)
                {
                    string character = char.ConvertFromUtf32(ch - decryptionKey);
                    decryptedMessage.Append(character);
                }

                string messagePattern = @"@([A-z]*)[^@\-!:>\\]*:([\d]+)!([AD])![^@\-!:>\\]*->([\d]+)";
                Regex regx = new Regex(messagePattern);
                Match match = regx.Match(decryptedMessage.ToString());

                if (!match.Success)
                {
                    continue;
                }

                string planet = match.Groups[1].Value;
                string actionSymbol = match.Groups[3].Value;

                if (actionSymbol == "A")
                {
                    attackedPlanets.Add(planet);
                }
                else
                {
                    destroyedPlanets.Add(planet);
                }
            }

            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                Console.WriteLine($"-> {string.Join("\n-> ", attackedPlanets)}");
            }
            
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                Console.WriteLine($"-> {string.Join("\n-> ", destroyedPlanets)}");
            }
        }
    }
}
