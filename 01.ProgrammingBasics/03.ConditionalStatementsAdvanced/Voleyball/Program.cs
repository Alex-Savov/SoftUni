using System;

namespace Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNot = Console.ReadLine();
            int hollidays = int.Parse(Console.ReadLine());
            int weekendshome = int.Parse(Console.ReadLine());

            double weekendsPlaysInSofia = (48 - weekendshome) * (3.0 / 4.0) ;
            double playsHollydays = hollidays * (2.0 / 3.0);
            double playsInSofia = weekendsPlaysInSofia + playsHollydays;
            double allGames = playsInSofia + weekendshome;

            if (leapOrNot == "leap")
            {
                allGames *= 1.15;
            }

            allGames = Math.Floor(allGames);

            Console.WriteLine(allGames);
        }
    }
}
