using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class VlogerData
    {
        public int Followings { get; set; }

        public SortedSet<string> Followers { get; set; }

        public VlogerData()
        {
            Followers = new SortedSet<string>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, VlogerData> vLoger = new Dictionary<string, VlogerData>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string vloger = tokens[0];
                string command = tokens[1];

                if (command == "joined" && !vLoger.ContainsKey(vloger))
                {
                    vLoger.Add(vloger, new VlogerData());
                }
                else if (command == "followed")
                {
                    string secondVloger = tokens[2];

                    if (vLoger.ContainsKey(vloger)
                        && vLoger.ContainsKey(secondVloger)
                        && vloger != secondVloger
                        && !vLoger[secondVloger].Followers.Contains(vloger))
                    {
                        vLoger[secondVloger].Followers.Add(vloger);
                        vLoger[vloger].Followings++;
                    }
                }

                input = Console.ReadLine();
            }

            vLoger = vLoger
                .OrderByDescending(x => x.Value.Followers.Count)
                .ThenBy(x => x.Value.Followings)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"The V-Logger has a total of {vLoger.Count} vloggers in its logs.");
            int count = 1;
            foreach (var vloger in vLoger)
            {
                string name = vloger.Key;
                int followers = vloger.Value.Followers.Count;
                int followings = vloger.Value.Followings;
                Console.WriteLine($"{count}. {name} : {followers} followers, {followings} following");

                if (vLoger.First().Key == name)
                {
                    foreach (var follower in vloger.Value.Followers)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
        }
    }
}
