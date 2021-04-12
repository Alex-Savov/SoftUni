using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timePlayer1 = int.Parse(Console.ReadLine());
            int timePlayer2 = int.Parse(Console.ReadLine());
            int timePlayer3 = int.Parse(Console.ReadLine());

            int sumTimes = timePlayer1 + timePlayer2 + timePlayer3;

            int minutes = sumTimes / 60;
            int seconds = sumTimes % 60;

            //Console.WriteLine($"{minutes}:{seconds:d2}");

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
