using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            if (!isLengthApropriate(pass))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isContainsLettersAndDigits(pass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isContainsTwoDigits(pass))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLengthApropriate(pass)
                && isContainsLettersAndDigits(pass)
                && isContainsTwoDigits(pass))
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool isLengthApropriate(string text)
        {
            bool isValid = text.Length >= 6
                        && text.Length <= 10;

            return isValid;
        }

        static bool isContainsLettersAndDigits(string text)
        {
            bool isValid = true;

            foreach (var item in text)
            {
                if (!char.IsDigit(item) 
                    && !char.IsLetter(item))
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        static bool isContainsTwoDigits (string text)
        {
            int digitCount = 0;
            bool isValid = false;
            foreach (var item in text)
            {
                if (char.IsDigit(item))
                {
                    digitCount++;
                }
                if (digitCount == 2)
                {
                    isValid = true;
                }
            }

            return isValid;
        }
    }
}
