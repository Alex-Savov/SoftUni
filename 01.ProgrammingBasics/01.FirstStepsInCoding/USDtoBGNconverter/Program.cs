using System;

namespace USDtoBGNconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            double USDToBGN = input * 1.79549;
            Console.WriteLine(USDToBGN);
        }
    }
}
