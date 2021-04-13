using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects
{
    // create class Team
    class Team
    {
        // prop TeamName
        public string TeamName { get; set; }

        // prop TeamCreator
        public string TeamCreator { get; set; }

        // generate List of users

        public List<string> Members { get; set;}

        public Team()
        {
            Members = new List<string>();
        }

        // override toString

        public override string ToString()
        {
            // "{teamName}:
            // - {creator}
            //-- { member}
            StringBuilder output = new StringBuilder();

            output.AppendLine(TeamName);
            output.AppendLine($"- {TeamCreator}");
            output.Append($"-- {string.Join($"\n-- ", Members)}");

            return output.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create list with teams
            List<Team> teams = new List<Team>();

            // take the lines 
            int lines = int.Parse(Console.ReadLine());

            // generate for loop to lines
            for (int i = 0; i < lines; i++)
            {
                // take the user data as array splited by "-"
                string[] userData = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);
                string userName = userData[0];
                string teamName = userData[1];

                // check if
                // If а user tries to create a team more than once,
                // a message should be displayed:
                // "Team {teamName} was already created!"

                if (!teams.Exists(x => x.TeamName == teamName))  
                {
                    // A creator of a team cannot create another team 
                    // – the following message should be thrown: 
                    // "{user} cannot create another team!"

                    if (!teams.Exists(x => x.TeamCreator == userName))
                    {
                        teams.Add(new Team
                        {
                            TeamCreator = userName,
                            TeamName = teamName
                        });

                        // print "Team {teamName} has been created by {user}!"
                        Console.WriteLine($"Team {teamName} has been created by {userName}!");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            };

            // take next mamber data like string
            string member = Console.ReadLine();

            // generate while loop until "end of assignment"
            while (member != "end of assignment")
            {
                // split user data in array by ->
                string[] memberData = member
                   .Split("->", StringSplitOptions.RemoveEmptyEntries);
                string memberName = memberData[0];
                string desiredTeam = memberData[1];

                // check if
                // If а user tries to join a non-existent team,
                // a message should be displayed:
                // "Team {teamName} does not exist!"

                if (teams.Exists(x => x.TeamName == desiredTeam))
                {
                    // A member of a team cannot join another team –
                    // the following message should be thrown:
                    // "Member {user} cannot join team {team Name}
                   
                    if (!teams.Any(x => x.Members.Contains(memberName))
                        && !teams.Any(x=> x.TeamCreator == memberName))
                    {
                        // add user to a team

                        teams.Find(x => x.TeamName == desiredTeam).Members
                             .Add(memberName);
                    }
                    else
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {desiredTeam}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {desiredTeam} does not exist!");
                }

                member = Console.ReadLine();
            }

            // chek if any team has members and 
            // order in descending the teams by members count
            // then by name in ascending

            foreach (var team in teams
                    .Where(x => x.Members.Count > 0)
                    .OrderByDescending(x => x.Members.Count)
                    .ThenBy(x => x.TeamName))
            {
                Console.WriteLine(team.ToString());
            }

            // teams with no members are disbanded
            // print the teams name ordered in ascending by name

            Console.WriteLine("Teams to disband:");

            foreach (var team in teams
                    .Where(x => x.Members.Count == 0)
                    .OrderBy(x => x.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
