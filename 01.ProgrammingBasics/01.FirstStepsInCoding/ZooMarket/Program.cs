using System;

namespace ZooMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int others = int.Parse(Console.ReadLine());

            double finalSum = (dogs * 2.5) + (others * 4);

            Console.WriteLine($"{finalSum} lv.");
        }
    }
}
