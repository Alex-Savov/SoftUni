using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            int sumSteps = 0;

            while (sumSteps < 10000)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int stepsBackHome = int.Parse(Console.ReadLine());
                    sumSteps += stepsBackHome;
                    break;
                }

                int steps = int.Parse(input);
                sumSteps += steps;
            }

            int stepsDiff = Math.Abs(sumSteps - 10000);

            if (sumSteps < 10000)
            {
                Console.WriteLine($"{stepsDiff} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine($"Goal reached! Good job!\n" +
                                     $"{stepsDiff} steps over the goal!");
            }
        }
    }
}
