using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int number = int.Parse(input);
                Console.WriteLine(IsPalindrome(number));
                input = Console.ReadLine();
            }
        }
        static bool IsPalindrome (int number)
        {
            string num = number.ToString();

            bool isValid = true;

            for (int i = 0; i < num.Length / 2; i++)
            {
                int leftNum = int.Parse(num[i].ToString());
                int rightNum = int.Parse(num[num.Length - 1 - i].ToString());
                if (leftNum != rightNum)
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }
    }
}
