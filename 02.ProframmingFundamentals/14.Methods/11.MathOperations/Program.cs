using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftNumber = int.Parse(Console.ReadLine());
            string operat = Console.ReadLine();
            int rightNumber = int.Parse(Console.ReadLine());
            double result = Calculator(leftNumber, rightNumber, operat);
            Console.WriteLine(Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }
        static double Calculator(int first, int second, string operat)
        {
            double result = 0;

            switch (operat)
            {
                case "+": 
                    result = first + second;
                    break;
                case "-": 
                    result = first - second;
                    break;
                case "*": 
                    result = first * second;
                    break;
                case "/":
                    result = first / (double)second;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
