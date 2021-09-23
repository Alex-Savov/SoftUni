using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            this.players = new List<Player>();
        }

        public string Name 
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
         public void RemovePlayer(string player)
        {
            if (!this.players.Any(p => p.Name == player))
            {
                throw new MissingMemberException($"Player {player} is not in {this.Name} team.");
            }

            Player removed = this.players.FirstOrDefault(p => p.Name == player);
            this.players.Remove(removed);
        }

        public double GetTeamRate()
        {
            double rating = this.players.Sum(p => p.GetAverageRate());
            return rating;
        }
    }
}
