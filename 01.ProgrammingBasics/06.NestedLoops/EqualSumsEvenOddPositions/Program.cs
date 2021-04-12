using System;

namespace EqualSumsEvenOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            

            for (int i = num1; i <= num2; i++)
            {
                int evenSum = 0;
                int oddSum = 0;
                string symbol = Convert.ToString(i);

                for (int j = 0; j < symbol.Length; j++)
                {

                    int digit = int.Parse(Convert.ToString(symbol[j]));

                    if ((j + 1) % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
