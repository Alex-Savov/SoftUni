using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int result = SubtractAndAdd(n1, n2, n3);
            Console.WriteLine(result);
        }
        static int SubtractAndAdd (int first, int second, int third)
        {
            int result = (Sum(first, second) - third);
            return result;
        }
        static int Sum(int first, int second)
        {
            int result = first + second;
            return result;
        }
    }
}
