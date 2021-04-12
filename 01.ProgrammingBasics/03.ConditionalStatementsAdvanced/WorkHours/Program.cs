using System;

namespace WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            string output = "";
            if (hour >= 10 && hour <= 18)
            {
                if (day == "Sunday")
                {
                    output = "closed";
                }
                else
                {
                    output = "open";
                }
            }
            else
            {
                output = "closed";
            }
            Console.WriteLine(output);
        }
    }
}
