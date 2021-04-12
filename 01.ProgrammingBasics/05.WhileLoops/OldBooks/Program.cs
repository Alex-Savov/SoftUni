using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string bookSearch = Console.ReadLine();
            bool isFound = true;
            int bookCounter = 0;

            while (book != bookSearch)
            {
                if (bookSearch == "No More Books")
                {
                    isFound = false;
                    break;
                }

                bookCounter++;
                bookSearch = Console.ReadLine();
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
        }
    }
}
