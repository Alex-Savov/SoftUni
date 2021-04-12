using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cakeArea = width * length;

            while (cakeArea > 0)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }

                int pieces = int.Parse(input);
                cakeArea -= pieces;
            }

            if (cakeArea > 0)
            {
                Console.WriteLine($"{cakeArea} pieces are left.");
            }
            else
            {
                cakeArea = Math.Abs(cakeArea);
                Console.WriteLine($"No more cake left! You need {cakeArea} pieces more.");
            }
        }
    }
}
