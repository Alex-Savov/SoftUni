using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                int inpitLenght = input.Length;
                int mainDigit = int.Parse(input) % 10;
                int index = 0;

                if (mainDigit == 0)
                {
                    message += " ";
                    continue;
                }
                if (mainDigit == 8 || mainDigit == 9)
                {
                    index = ((mainDigit - 2) * 3) + (inpitLenght);
                }
                else
                {
                    index = ((mainDigit - 2) * 3) + (inpitLenght - 1);
                }

                char letter = Convert.ToChar(97 + index);
                message += letter;
            }

            Console.WriteLine(message);
        }
    }
}
