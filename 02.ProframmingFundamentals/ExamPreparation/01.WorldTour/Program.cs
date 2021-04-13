using System;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string route = Console.ReadLine();
            string inputCommand = Console.ReadLine();

            while (inputCommand != "Travel")
            {
                string[] tokens = inputCommand
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(tokens[1]);
                    string destination = tokens[2];

                    if (index >= 0 && index < route.Length)
                    {
                        route = route.Insert(index, destination);
                    }

                    Console.WriteLine(route);
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if((startIndex >= 0 && startIndex < route.Length)
                        && (endIndex >= 0 && endIndex < route.Length))
                    {
                        route = route.Remove(startIndex, (endIndex - startIndex + 1));
                    }

                    Console.WriteLine(route);
                }
                else if (command == "Switch")
                {
                    string oldSubstr = tokens[1];
                    string newSubstr = tokens[2];

                    if (route.Contains(oldSubstr))
                    {
                        route = route.Replace(oldSubstr, newSubstr);
                    }

                    Console.WriteLine(route);
                }

                inputCommand = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {route}");
        }
    }
}
