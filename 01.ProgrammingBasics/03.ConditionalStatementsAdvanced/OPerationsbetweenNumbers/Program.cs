using System;

namespace OPerationsbetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operat = Console.ReadLine();

            double result = 0;

            if (operat == "+")
            {
                result = n1 + n2;
                string evenOrOdd = "odd";
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                Console.WriteLine($"{n1} {operat} {n2} = {result} - {evenOrOdd}");
            }
            else if (operat == "-")
            {
                result = n1 - n2;
                string evenOrOdd = "odd";
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                Console.WriteLine($"{n1} {operat} {n2} = {result} - {evenOrOdd}");
            }
            else if (operat == "*")
            {
                result = n1 * n2;
                string evenOrOdd = "odd";
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                Console.WriteLine($"{n1} {operat} {n2} = {result} - {evenOrOdd}");
            }
            else if (operat == "/" && n2 != 0)
            {
                result = n1 / (n2 * 1.0);
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            else if (operat == "%" && n2 != 0)
            {
                result = n1 % n2;
                Console.WriteLine($"{n1} % {n2} = {result}");
            }
            else if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
        }
    }
}
