using System;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] commandArgs = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "Contains")
                {
                    string substring = commandArgs[1];

                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
            {
                string upperOrLower = commandArgs[1];
                int startIndex = int.Parse(commandArgs[2]);
                int endIndex = int.Parse(commandArgs[3]);
                string substring = activationKey.Substring(startIndex, (endIndex - startIndex));

                if (upperOrLower == "Upper")
                {
                    activationKey = activationKey.Replace(substring, substring.ToUpper());
                }
                else
                {
                    activationKey = activationKey.Replace(substring, substring.ToLower());
                }

                Console.WriteLine(activationKey);
            }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    activationKey = activationKey.Remove(startIndex, (endIndex - startIndex));

                    Console.WriteLine(activationKey);
                }

                command = Console.ReadLine();
        }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
