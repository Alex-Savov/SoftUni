using System;

namespace InchToCentimetersConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());

            double convertToCentimeters = inches * 2.54;
            Console.WriteLine(convertToCentimeters);
        }
    }
}
