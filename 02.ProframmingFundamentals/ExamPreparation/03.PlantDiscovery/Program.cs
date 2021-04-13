using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Plant
    {
        public string Name { get; set; }
        public int Rairity { get; set; }

        public List<double> Rating { get; set; }
        public Plant()
        {
            Rating = new List<double>();
        }

        public double AverageRating
        {
            get
            {
                if (Rating.Count == 0 || Rating.Sum() == 0)
                {
                    return 0.0;
                }
                else
                {
                    return Rating.Sum() / Rating.Count();
                }
               
            }
        }

        public override string ToString()
        {
            return $"- {Name}; Rarity: {Rairity}; Rating: {AverageRating:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < n; i++)
            {
                string[] inputPlant = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = inputPlant[0];
                int rairity = int.Parse(inputPlant[1]);

                if (!plants.Any(p => p.Name == plant))
                {
                    plants.Add(new Plant { Name = plant });
                }

                plants[plants.FindIndex(p => p.Name == plant)].Rairity += rairity;
            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "Exhibition")
            {
                string[] tokensCommand = inputCommand
                    .Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);

                string command = tokensCommand[0];
                string plant = tokensCommand[1];

                if (!plants.Any(p => p.Name == plant))
                {
                    Console.WriteLine("error");
                    inputCommand = Console.ReadLine();
                    continue;
                }

                int indexPlant = plants.FindIndex(p => p.Name == plant);

                switch (command)
                {
                    case "Rate":
                        int rating = int.Parse(tokensCommand[2]);
                        plants[indexPlant].Rating.Add(rating);
                        break;

                    case "Update":
                        int newRairity = int.Parse(tokensCommand[2]);
                        plants[indexPlant].Rairity = newRairity;
                        break;

                    case "Reset":
                        plants[indexPlant].Rating.Clear();
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }

                inputCommand = Console.ReadLine();
            }

            plants = plants
                .OrderByDescending(p => p.Rairity)
                .ThenByDescending(p => p.AverageRating)
                .ToList();

            Console.WriteLine("Plants for the exhibition:");
            Console.WriteLine(string.Join("\n", plants.Select(p => p.ToString())));
        }
    }
}
