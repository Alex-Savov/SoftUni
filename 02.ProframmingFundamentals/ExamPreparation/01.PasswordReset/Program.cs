using System;
using System.Text;

namespace _01.PasswordReset
{
    class Program
    {
        public static object Stringbuilder { get; private set; }

        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (true)
            {
                string action = Console.ReadLine();

                if (action == "Done")
                {
                    break;
                }

                string[] tokens = action
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                switch (command)
                {
                    case "TakeOdd":

                        StringBuilder odds = new StringBuilder();

                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i % 2 == 1)
                            {
                                odds.Append(password[i].ToString()); 
                            }
                        }

                        password = odds.ToString();
                        Console.WriteLine(password);

                        break;
                    case "Cut":

                        int index = int.Parse(tokens[1]);
                        int length = int.Parse(tokens[2]);
                        password = password.Remove(index, length);

                        Console.WriteLine(password);

                        break;
                    case "Substitute":

                        string substring = tokens[1];
                        string substitude = tokens[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitude);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
