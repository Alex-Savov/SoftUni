using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentREcord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMetter = double.Parse(Console.ReadLine());

            double delay = Math.Floor((distance / 15)) * 12.5;

            double finalTime = distance * timePerMetter + delay;

            if (finalTime < currentREcord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                double timeDiff = finalTime - currentREcord;
                Console.WriteLine($"No, he failed! He was {timeDiff:f2} seconds slower.");
            }
        }
    }
}
