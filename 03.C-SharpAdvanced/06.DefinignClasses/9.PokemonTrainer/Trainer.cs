using System;
using System.Collections.Generic;
using System.Text;

namespace _9.PokemonTrainer
{
    public class Trainer
    {
        private List<Pokemon> pokemons = new List<Pokemon>();

        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = pokemons;
        }
        
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count}";
        }
    }
}
