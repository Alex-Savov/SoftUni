using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = Math.Abs(int.Parse(Console.ReadLine()));
            int n2 = Math.Abs(int.Parse(Console.ReadLine()));
            double result = DivideFactorials(n1, n2);
            Console.WriteLine("{0:f2}", result);
           
        }
        static double DivideFactorials (int first, int second)
        {
            int firstFact = FactorialNumber(first);
            int secondFact = FactorialNumber(second);
            double result = firstFact / (double)secondFact;
            return result;
        }
        static int FactorialNumber (int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                int factorial = number;
                for (int i = number - 1; i > 0; i--)
                {
                    factorial *= i;
                }
                return factorial;
            }

        }
    }
}
