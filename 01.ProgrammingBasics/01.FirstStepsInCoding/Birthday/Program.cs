using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = rent * 0.2;
            double bavarages = cake * 0.55;
            double animator = rent / 3;

            double finalPrice = rent + cake + bavarages + animator;
            Console.WriteLine(finalPrice);

            Console.WriteLine("test changes");
        }
    }
}
