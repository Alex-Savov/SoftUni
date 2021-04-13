using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.SoftuniExamResults
{
    class UsersAndPoints
    {
        public UsersAndPoints(string user, int points)
        {
            User = user;
            Points = points;
        }

        public string User { get; set; }
        public int Points { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<UsersAndPoints>> userResults = new Dictionary<string, List<UsersAndPoints>>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] dataArgs = input
                  .Split('-', StringSplitOptions.RemoveEmptyEntries);
                string userName = dataArgs[0];
                string language = dataArgs[1];

                if (language == "banned")
                {
                    if (userResults.Any(x => x.Value.Any(x => x.User == userName)))
                    {
                        foreach (var result in userResults)
                        {
                            result.Value.RemoveAll(x => x.User == userName);
                        }
                    }
                   
                    continue;
                }
                

                if (!submissions.ContainsKey(language))
                {
                    submissions.Add(language, 0);
                }
                submissions[language]++;

                int points = int.Parse(dataArgs[2]);

                if (!userResults.ContainsKey(language))
                {
                    userResults.Add(language, new List<UsersAndPoints>
                    {
                        { new UsersAndPoints(userName, points) } 
                    });
                }
                else
                {
                    if (userResults[language].Any(x => x.User == userName))
                    {
                        int currentPts = userResults[language]
                            .Find(x => x.User == userName).Points;

                        foreach (var user in userResults[language])
                        {
                            if (user.User == userName)
                            {
                                user.Points = currentPts < points ? points : currentPts;
                            }
                        }
                    }
                    else
                    {
                        userResults[language].Add(new UsersAndPoints(userName, points));
                    }
                }
            }

            List<UsersAndPoints> sortedUsers = new List<UsersAndPoints>();

            foreach (var result in userResults)
            {
                foreach (var user in result.Value)
                {
                    sortedUsers.Add(user);
                }
            }

            sortedUsers = sortedUsers
                .OrderByDescending(x => x.Points)
                .ThenBy(x => x.User)
                .ToList();

            submissions = submissions
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");
            foreach (var user in sortedUsers)
            {
                Console.WriteLine($"{user.User} | {user.Points}");
            }

            Console.WriteLine("Submissions:");
            foreach (var sumnission in submissions)
            {
                Console.WriteLine($"{sumnission.Key} - {sumnission.Value}");
            }
        }
    }
}
