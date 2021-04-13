using System;

namespace _0._1.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = SignValidator(n);
            Console.WriteLine(result);
        }
        static string SignValidator (int number)
        {
            string result = string.Empty;

            if (number > 0)
            {
                result = $"The number {number} is positive.";
            }
            else if (number < 0)
            {
                result = $"The number {number} is negative.";
            }
            else
            {
                result = $"The number {number} is zero.";
            }

            return result;
        }
    }
}
