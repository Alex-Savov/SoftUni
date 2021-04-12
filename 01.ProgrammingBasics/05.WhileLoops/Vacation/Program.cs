using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());

            int daysInARow = 0;
            int days = 0;

            while (moneyAvailable < moneyNeeded)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                days++;

                if (sum > moneyAvailable && action == "spend")
                {
                    moneyAvailable = 0;
                }
                else if (action == "spend")
                {
                    daysInARow++;
                    moneyAvailable -= sum;
                }
                else
                {
                    daysInARow = 0;
                    moneyAvailable += sum;
                }

                if (daysInARow == 5)
                {
                    break;
                }
            }

            if (daysInARow == 5)
            {
                Console.WriteLine($"You can't save the money.\n{days}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
