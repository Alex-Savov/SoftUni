using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tickrtType = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int allSeats = r * c;
            double finalSum = 0;
            if (tickrtType == "Premiere")
            {
                finalSum = allSeats * 12.0;
            }
            else if (tickrtType == "Normal")
            {
                finalSum = allSeats * 7.5;
            }
            else
            {
                finalSum = allSeats * 5.0;
            }

            Console.WriteLine($"{finalSum:f2} leva");
        }
        
    }
}
