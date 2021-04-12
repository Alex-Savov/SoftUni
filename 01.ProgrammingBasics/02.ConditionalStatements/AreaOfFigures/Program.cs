using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double output = 0;
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                output = side * side;
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                output = sideA * sideB;
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                output = (Math.PI * r * r);
            }

            // triangle
            else
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                output = side * h / 2;
            }

            Console.WriteLine($"{output:f3}");
        }
    }
}
