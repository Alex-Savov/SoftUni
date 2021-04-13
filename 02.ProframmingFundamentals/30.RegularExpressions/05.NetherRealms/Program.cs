using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05.NetherRealms
{
    class Program
    {
        class Demon
        {
            public string Name { get; set; }
            public int Helth { get; set; }
            public double Damage { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Helth} health, {Damage:f2} damage";
            }
        }
        static void Main(string[] args)
        {
            List<Demon> demons = new List<Demon>();

            string healthPattern = @"[^+\-\*/\.\d]";
            Regex healthRgx = new Regex(healthPattern);
            string digitsPattern = @"[+-]?\d+(\.\d+)?";
            Regex digitsRgx = new Regex(digitsPattern);
            string alteringsPattern = @"[\*\/]";
            Regex alteringRgx = new Regex(alteringsPattern);

            string[] demonsNames = Console.ReadLine()
                .Split(new[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var demonsName in demonsNames)
            {
                MatchCollection healthMatches = healthRgx.Matches(demonsName);
                int health = 0;

                foreach (Match item in healthMatches)
                {
                    health += Convert.ToChar(item.Value);
                }

                MatchCollection digitMatches = digitsRgx.Matches(demonsName);
                double damage = 0.0;

                foreach (Match item in digitMatches)
                {
                    damage += double.Parse(item.Value);
                }

                MatchCollection alteringMatches = alteringRgx.Matches(demonsName);

                foreach (Match item in alteringMatches)
                {
                    if (item.Value == "*")
                    {
                        damage *= 2;
                    }
                    else if (item.Value == "/")
                    {
                        damage /= 2;
                    }
                }

                demons.Add(new Demon
                {
                    Name = demonsName,
                    Helth = health,
                    Damage = damage
                });
            }

            demons = demons.OrderBy(x => x.Name).ToList();

            foreach (var demon in demons)
            {
                Console.WriteLine(demon.ToString());
            };
        }
    }
}
