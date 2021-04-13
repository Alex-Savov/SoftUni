using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double result = RectangularArea(width, length);
            Console.WriteLine(result);
        }

        static double RectangularArea(double width, double lenght)
        {
            return (width * lenght);
        }
    }
}
