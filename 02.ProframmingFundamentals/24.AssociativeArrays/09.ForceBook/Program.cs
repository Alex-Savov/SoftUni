using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.initiate dictionary string => List<string>
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();

            //2.get the input as string
            string input = Console.ReadLine();

            //3.while loop >> input != "Lumpawaroo"
            while (input != "Lumpawaroo")
            {
                //  3.0 split the input by 
                string separator = input.Contains('|') ? " | " : " -> ";

                string[] commandArgs = input
                    .Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string forceSide = "";
                string userName = "";

                if (separator == " | ")
                {
                    forceSide = commandArgs[0];
                    userName = commandArgs[1];
                }
                else
                {
                    forceSide = commandArgs[1];
                    userName = commandArgs[0];
                }
                

                //  3.1 check if side exist, if not add it
                if (!forceSides.ContainsKey(forceSide))
                {
                    forceSides.Add(forceSide, new List<string>());
                }
               
                //  3.2 check if sepataror is "->" and if some side contains
                //      the user, if true move user from existing to the new
                //      side;
                //      continue

                if (separator == " -> ")
                {
                    if (forceSides.Any(x => x.Value.Contains(userName)))
                    {
                        foreach (var force in forceSides)
                        {
                            if (force.Value.Contains(userName))
                            {
                                force.Value.Remove(userName);
                            }
                        }
                    }
                    
                    forceSides[forceSide].Add(userName);
                    Console.WriteLine($"{userName} joins the {forceSide} side!");
                    input = Console.ReadLine();
                    continue;
                }
                //  3.3 add user to forceside

                if (!forceSides.Any(x => x.Value.Contains(userName)))
                {
                    forceSides[forceSide].Add(userName);
                }
               
                input = Console.ReadLine();
            }
            //4.sort the dictionary and the list according the document
            forceSides = forceSides
                .OrderByDescending(f => f.Value.Count)
                .ThenBy(f => f.Key)
                .ToDictionary(f => f.Key, f => f.Value);

            //5.print the data
            foreach (var forceSide in forceSides)
            {
                forceSide.Value.Sort();

                if (forceSide.Value.Count == 0)
                {
                    continue;
                }

                Console.WriteLine($"Side: {forceSide.Key}, Members: {forceSide.Value.Count}");
                Console.WriteLine($"! {string.Join("\n! ", forceSide.Value)}");
            }
        }
    }
}
