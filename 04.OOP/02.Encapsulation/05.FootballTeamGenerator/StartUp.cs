using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FootballTeamGenerator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> ligue = new List<Team>();

            while (true)
            {
                string[] lineInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                string command = lineInput[0];

                if (command == "END")
                {
                    break;
                }

                string teamName = lineInput[1];
                try
                {
                    if (command == "Team")
                    {
                        ligue.Add(new Team(teamName));
                    }
                    else if (command == "Add")
                    {
                        TeamValidator(teamName, ligue);

                        string playerName = lineInput[2];
                        int endurance = int.Parse(lineInput[3]);
                        int sprint = int.Parse(lineInput[4]);
                        int driblle = int.Parse(lineInput[5]);
                        int passing = int.Parse(lineInput[6]);
                        int shooting = int.Parse(lineInput[7]);

                        Player currentPlayer = new Player(playerName
                            , endurance
                            , sprint
                            , driblle
                            , passing
                            , shooting);

                        ligue.FirstOrDefault(t => t.Name == teamName).AddPlayer(currentPlayer);

                    }
                    else if (command == "Remove")
                    {
                        string playerToRemove = lineInput[2];

                        ligue.FirstOrDefault(t => t.Name == teamName).RemovePlayer(playerToRemove);
                    }
                    else if (command == "Rating")
                    {
                        TeamValidator(teamName, ligue);

                        double teamRate = ligue.FirstOrDefault(t => t.Name == teamName).GetTeamRate();
                        Console.WriteLine($"{teamName} - {Math.Round(teamRate, 0, MidpointRounding.AwayFromZero)}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private static void TeamValidator(string teamName, List<Team> ligue)
        {
            if (!ligue.Any(t => t.Name == teamName))
            {
                throw new MissingMemberException($"Team {teamName} does not exist.");
            }
        }
    }
}
