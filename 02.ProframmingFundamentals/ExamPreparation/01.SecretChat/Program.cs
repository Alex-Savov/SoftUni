using System;
using System.Linq;
using System.Text;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] tokens = input
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(tokens[1]);
                        message = message.Insert(index, " ");
                        Console.WriteLine(message);
                        break;

                    case "Reverse":
                        string reverseSubstr = tokens[1];
                        if (message.Contains(reverseSubstr))
                        {
                            message = message.Replace(reverseSubstr, "");
                            message += string.Join("", reverseSubstr.Reverse().ToArray());
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "ChangeAll":
                        string changeSubstr = tokens[1];
                        string replaceSubstr = tokens[2];
                        message = message.Replace(changeSubstr, replaceSubstr);
                        Console.WriteLine(message);

                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
