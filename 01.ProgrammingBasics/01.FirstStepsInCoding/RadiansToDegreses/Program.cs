using System;

namespace RadiansToDegreses
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());

            double radToDeg = radians * 180 / Math.PI;
            Console.WriteLine(Math.Round(radToDeg));
        }
    }
}
