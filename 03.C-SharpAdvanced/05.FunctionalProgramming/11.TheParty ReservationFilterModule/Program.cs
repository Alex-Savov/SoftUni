using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.TheParty_ReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList(); ;

            string command = Console.ReadLine();
            List<string> filters = new List<string>();

            while (command.ToLower() != "print")
            {
                int commandEndIndex = command.IndexOf(';');
                string action = command.Substring(0, command.Length - (command.Length - commandEndIndex));
                string filter = command.Substring(commandEndIndex + 1);

                if (action.ToLower().Contains("add"))
                {
                    if (!filters.Contains(filter))
                    {
                        filters.Add(filter);
                    }
                }
                else if (action.ToLower().Contains("remove"))
                {
                    if (filters.Contains(filter))
                    {
                        filters.Remove(filter);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                string[] filterTokens = filter
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);
                string criteria = filterTokens[0];
                string comparer = filterTokens[1];

                names = ListManipulator(names, criteria, comparer);
            }

            Console.WriteLine(string.Join(' ', names));
        }

        static Func<string, string, bool> FunctionsPool(string criteria)
        {
            Func<string, string, bool> startsWith = (name, startString) =>
            name.Substring(0, startString.Length) == startString;

            Func<string, string, bool> endsWith = (name, endString) =>
            name.Substring(name.Length - endString.Length) == endString;

            Func<string, string, bool> isLenghtEqual = (name, lenght) =>
            name.Length == int.Parse(lenght);

            Func<string, string, bool> contains = (name, containsString) =>
            name.Contains(containsString);

            switch (criteria.ToLower())
            {
                case "starts with": return startsWith;
                case "ends with": return endsWith;
                case "length": return isLenghtEqual;
                case "contains": return contains;
                default: return null;

            }
        }

        static List<string> ListManipulator(List<string> names, string criteria, string comparer)
        {
            List<string> temp = new List<string>();

            foreach (var name in names)
            {
                if (!FunctionsPool(criteria)(name, comparer))
                {
                    temp.Add(name);
                }
            }

            return temp;
        }
    }
}
