using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Population: {Population} citizens, Gold: {Gold} kg";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "sail")
                {
                    break;
                }

                string[] citiesData = input
                    .Split("||", StringSplitOptions.RemoveEmptyEntries);

                string name = citiesData[0];
                int population = int.Parse(citiesData[1]);
                int gold = int.Parse(citiesData[2]);

                if (!cities.Any(x => x.Name == name))
                {
                    cities.Add(new City
                    {
                        Name = name
                    });
                }

                int index = cities.FindIndex(x => x.Name == name);
                cities[index].Population += population;
                cities[index].Gold += gold;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    break;
                }

                string[] commandArgs = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                string town = commandArgs[1];
                
                if (!cities.Any(x => x.Name == town))
                {
                    continue;
                }

                int index = cities.FindIndex(x => x.Name == town);

                if (command.ToLower() == "plunder")
                {
                    int people = int.Parse(commandArgs[2]);
                    int gold = int.Parse(commandArgs[3]);

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    cities[index].Population -= people;
                    cities[index].Gold -= gold;

                    if (cities[index].Population <= 0 || cities[index].Gold <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        cities.RemoveAt(index);
                    }
                }
                else if (command.ToLower() == "prosper")
                {
                    int gold = int.Parse(commandArgs[2]);

                    if (gold <= 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    cities[index].Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[index].Gold} gold.");
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                
                cities = cities
               .OrderByDescending(c => c.Gold)
               .ThenBy(c => c.Name)
               .ToList();

                foreach (var city in cities)
                {
                    Console.WriteLine(city.ToString());
                }
            }
        }
    }
}
