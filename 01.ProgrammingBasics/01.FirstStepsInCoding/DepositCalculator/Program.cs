using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double anualInterest = double.Parse(Console.ReadLine());

            double monthlyInterest = deposit * (anualInterest / 100) / 12;
            double finalSum = deposit + (monthlyInterest * period);

            Console.WriteLine(finalSum);
        }
    }
}
