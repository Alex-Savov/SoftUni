using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (true)
            {
                bool isStop = false;
                if (input == "stop")
                {
                    isStop = true;
                    break;
                }
                int number = int.Parse(input);

                while (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    if (input == "stop")
                    {
                        isStop = true;
                        break;
                    }
                    number = int.Parse(input);
                }

                if (isStop)
                {
                    break;
                }

                bool isNotPrime = false;
                for (int i = 2; i < number; i++)
                {
                   
                    if (number % i == 0)
                    {
                        isNotPrime = true;
                        break;
                    }
                }

                if (isNotPrime)
                {
                    sumNonPrime += number;
                }
                else
                {
                    sumPrime += number;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
