using System;
using System.Collections.Generic;
using System.Linq;


namespace _10.SoftUniExamResults
{
    class LangAndPoints
    {
        public string Langauage { get; set; }
        public int Points { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1.dictionary user => points
            Dictionary<string, Dictionary<string, int>> userByPtAndLang = new Dictionary<string, Dictionary<string, int>>();

            //2.dictionary language => submissions
            Dictionary<string, int> languageBySubmission = new Dictionary<string, int>();

            //3.while loop >> true
            while (true)
            {
                //3.1.get input
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                //  3.2 split input by "-"
                string[] dataArgs = input
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);
                string userName = dataArgs[0];
                string language = dataArgs[1];

                //  3.3 if "banned" recieved, remove user
                if (language == "banned")
                {
                    userByPtAndLang.Remove(userName);
                    continue;
                }

                //  3.4 if user doesn't exist > add them
                int points = int.Parse(dataArgs[2]);

                if (!userByPtAndLang.ContainsKey(userName))
                {
                    userByPtAndLang.Add(userName, new Dictionary<string, int> { { language, points } });
                }
                else
                {
                    if (userByPtAndLang[userName].ContainsKey(language))
                    {
                       Dictionary <string, int> temp = userByPtAndLang[userName]
                            .Where(x => x.Key.Contains(language))
                            .ToDictionary(x => x.Key, x => x.Value);

                        int currentPoints = temp[language];

                        temp[language] = currentPoints < points ? points : currentPoints;

                        userByPtAndLang[userName] = temp;

                        //= currentPoints < points ? points : currentPoints;
                    }
                    else
                    {
                        userByPtAndLang[userName] = new Dictionary<string, int> 
                        { 
                            { language, points }
                        };
                    }
                    //int currentPoints = userBuPtAndLang[userName].;
                    
                }

                //  3.5 if language doesn't exist, add it
                if (!languageBySubmission.ContainsKey(language))
                {
                    languageBySubmission.Add(language, 0);
                }

                //  3.6 increase language submissions by one
                languageBySubmission[language]++;
            }
            //4.sort and print the data

            userByPtAndLang = userByPtAndLang
                .Select(x => x.Value.OrderByDescending(x => x.Value))
                .ToDictionary(x => x.);

            userByPtAndLang = userByPtAndLang
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(l => l.Key, l => l.Value);

            //userByPtAndLang = userByPtAndLang
            //    .OrderByDescending(u => u.Value)
            //    .ThenBy(u => u.Key)
            //    .ToDictionary(u => u.Key, u => u.Value);

            languageBySubmission = languageBySubmission
                .OrderByDescending(l => l.Value)
                .ToDictionary(l => l.Key, l => l.Value);

            Console.WriteLine("Results:");
            foreach (var user in userByPtAndLang)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var lang in languageBySubmission)
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}
