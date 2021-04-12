using System;

namespace OnTimeForTheExham
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            int examSumMinutes = examHour * 60 + examMin;
            int arriveSumMinutes = arriveHour * 60 + arriveMin;
            int timeDiff = Math.Abs(examSumMinutes - arriveSumMinutes);
            int hours = timeDiff / 60;
            int min = timeDiff % 60;

            if (examSumMinutes < arriveSumMinutes) // late
            {
                if (timeDiff / 60 >= 1)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hours}:{min:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{timeDiff} minutes after the start");
                }
            }
            else if (examSumMinutes >= arriveSumMinutes && examSumMinutes - arriveSumMinutes <= 30) // on time
            {
                if (timeDiff == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (timeDiff / 60 >= 1)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{hours}:{min:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{timeDiff} minutes before the start");
                }
            }
            else // early
            {
                if (timeDiff / 60 >= 1)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hours}:{min:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{timeDiff} minutes before the start");
                }
            }
        }
    }
}
