using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string inputCommand = Console.ReadLine();

            while (inputCommand != "Decode")
            {
                string[] tokensCommand = inputCommand
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string command = tokensCommand[0];

                if (command == "Move")
                {
                    int letCount = int.Parse(tokensCommand[1]);
                    string substring = message.Substring(0, letCount);
                    message = (message.Remove(0, letCount)) + substring;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokensCommand[1]);
                    string value = tokensCommand[2];
                    message = message.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string substring = tokensCommand[1];
                    string substitute = tokensCommand[2];
                    message = message.Replace(substring, substitute);
                }

                inputCommand = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
