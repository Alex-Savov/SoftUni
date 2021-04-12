using System;

namespace Literature
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int dueDAys = int.Parse(Console.ReadLine());

            double hoursPerBook = pages / pagesPerHour;
            double hoursPerDay = hoursPerBook / dueDAys;

            Console.WriteLine(hoursPerDay);
        }
    }
}
