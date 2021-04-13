using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine()) * 60;
            int minutes = int.Parse(Console.ReadLine());
            int timePlus30Minutes = hours + minutes + 30;
            int newHours = timePlus30Minutes / 60;
            int newMinutes = timePlus30Minutes % 60;

            if (newHours == 24)
            {
                newHours = 0;
            }

            Console.WriteLine($"{newHours}:{newMinutes:d2}");
        }
    }
}
