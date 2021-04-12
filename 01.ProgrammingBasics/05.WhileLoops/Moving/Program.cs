using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int highth = int.Parse(Console.ReadLine());

            int spaceVol = width * length * highth;

            string input = Console.ReadLine();

            int boxesVol = 0;
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                boxesVol += boxes;

                if (boxesVol >= spaceVol)
                {
                    break;
                }
            }

            int volumeDiff = Math.Abs(spaceVol - boxesVol);
            if (boxesVol >= spaceVol)
            {
                Console.WriteLine($"No more free space! You need {volumeDiff} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{volumeDiff} Cubic meters left.");
            }
        }
    }
}
