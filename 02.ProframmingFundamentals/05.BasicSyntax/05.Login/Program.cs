using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = "";

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

           
            bool isCorrect = false;

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    isCorrect = true;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }

            if (isCorrect)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
            else
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }
}
