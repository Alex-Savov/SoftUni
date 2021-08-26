using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandInput = Console.ReadLine();


            while (commandInput.ToLower() != "party!")
            {
                string[] tokens = commandInput
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];
                string criteria = tokens[1];
                string comparer = tokens[2];

                names = ListManipulator(names, action, criteria, comparer);

                commandInput = Console.ReadLine();
            }

            if (names.Count > 0)
            {
                Console.Write($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Func<string, string, bool> FunctionsPool(string criteria)
        {
            Func<string, string, bool> startWith = (name, startString) =>
            name.Substring(0, startString.Length) == startString;

            Func<string, string, bool> endWith = (name, startString) =>
            name.Substring(name.Length - startString.Length) == startString;

            Func<string, string, bool> isLenghtEquale = (name, lenght) =>
            name.Length == int.Parse(lenght);

            switch (criteria.ToLower())
            {
                case "startswith": return startWith;
                case "endswith": return endWith;
                case "length": return isLenghtEquale;
                default:
                    return null;
            }
        }

        static List<string> ListManipulator(List<string> names, string action, string criteria, string comparer)
        {
            List<string> result = new List<string>();
            
            switch (action.ToLower())
            {
                case "double":
                    foreach (var name in names)
                    {
                        if (FunctionsPool(criteria)(name, comparer))
                        {
                            result.Add(name);
                        }
                        result.Add(name);
                    }
                    break;

                case "remove":

                    foreach (var name in names)
                    {
                        if (FunctionsPool(criteria)(name, comparer))
                        {
                            continue;
                        }
                        result.Add(name);
                    }
                    break;
                    
                default:
                    return names;
            }

            return result;
        }
    }
}
