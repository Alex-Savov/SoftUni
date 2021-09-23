using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private readonly List<Person> firstTeam;
        private readonly List<Person> reserveTeam;
        private readonly string name;
        public Team(string name)
        {
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
            this.name = name;
        }

        public IReadOnlyList<Person> FirstTeam { get => firstTeam.AsReadOnly(); }
        public IReadOnlyList<Person> ReserveTeam { get => reserveTeam.AsReadOnly(); }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }
    }
}
