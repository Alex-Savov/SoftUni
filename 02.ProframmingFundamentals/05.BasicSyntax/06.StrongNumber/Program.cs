using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int saveNumber = num;
            int factorial = 0;
            while (num != 0)
            {
                int getLestDigit = num % 10;
                int temp = getLestDigit;

                if (temp == 0)
                {
                    temp = 1;
                }

                for (int i = getLestDigit; i > 1; i--)
                {
                    temp *= (i - 1);
                }

                factorial += temp;
                num /= 10;
            }

            if (saveNumber == factorial)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
