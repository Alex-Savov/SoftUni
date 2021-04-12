using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            bool isFound = false;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    combination++;
                    if (i + j == magicNumber)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNumber})");
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
