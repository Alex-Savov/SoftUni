using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //var vLoger = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            var vLoger = new Dictionary<string, SortedSet<string>>();
            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string vloger = tokens[0];
                string command = tokens[1];

                if (command == "joined" && !vLoger.ContainsKey(vloger))
                {
                    vLoger.Add(vloger, new SortedSet<string>());
                }
                else if (command == "followed")
                {
                    string followingVloger = tokens[2];

                    if (vLoger.ContainsKey(vloger)
                        && vLoger.ContainsKey(followingVloger)
                        && vloger != followingVloger)
                    {
                        string followedBy = $"*  {vloger}"; // "*  " for followed by 
                        string following = $">{followingVloger}";         // < for following

                        vLoger[followingVloger].Add(followedBy);
                        vLoger[vloger].Add(following);
                    }
                }

                input = Console.ReadLine();
            }

            vLoger = vLoger.OrderByDescending(x => x.Value.Count(x => x.Contains("*  ")))
                  .ThenBy(x => x.Value.Count(x => x.Contains(">")))
                  .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"The V-Logger has a total of {vLoger.Count} vloggers in its logs.");
            int count = 1;

            foreach (var vloger in vLoger)
            {
                string name = vloger.Key;
                int followers = vloger.Value.Count(x => x.Contains("*  "));
                int followings = vloger.Value.Count(x => x.Contains(">"));
                Console.WriteLine($"{count}. {name} : {followers} followers, {followings} following");

                if (vLoger.First().Key == name)
                {
                    foreach (var follower in vloger.Value.Where(x => x.Contains("*  ")))
                    {
                        Console.WriteLine($"{follower}");
                    }
                }
                count++;
            }

        }
    }
}
