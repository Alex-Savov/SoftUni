using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.PokemonTrainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (command != "Tournament")
            {
                string[] trainerData = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = trainerData[0];
                string pokemonName = trainerData[1];
                string pokemonElement = trainerData[2];
                int pokemonHealth = int.Parse(trainerData[3]);
                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                

                if (!trainers.Any(t => t.Name == name))
                {
                    trainers.Add(new Trainer(name));
                }
                trainers.FirstOrDefault(t => t.Name == name).Pokemons.Add(currentPokemon);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == command))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);

                        if (trainer.Pokemons.Any(p => p.Health <= 0))
                        {
                            trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(t => t.Badges).ToList();

            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer.ToString());
            }
        }
    }
}
