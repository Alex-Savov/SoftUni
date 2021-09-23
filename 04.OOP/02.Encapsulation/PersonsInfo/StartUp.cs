using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            Team teamSoftuni = new Team("softuni");

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                teamSoftuni.AddPlayer(person);
            }

            Console.WriteLine($"First team has {teamSoftuni.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {teamSoftuni.ReserveTeam.Count} players.");
        }
    }
}
