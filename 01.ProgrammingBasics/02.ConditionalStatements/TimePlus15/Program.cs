using System;

namespace TimePlus15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursInMinutes = hours * 60;

            if (hours == 23 && minutes + 15 > 59)
            {
                hours = 0;
                minutes = (minutes + 15) - 60;
            }
            else if (minutes + 15 > 59)
            {
                hours++;
                minutes = (minutes + 15) - 60;
            }
            else 
            {
                minutes += 15;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");

           
        }
    }
}
