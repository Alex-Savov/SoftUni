using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSmallest(n1, n2, n3));
        }
        static int GetSmallest(int first, int second, int third)
        {
            int temp = 0;
            if (first < third)
            {
                temp = first;
                first = third;
                third = temp;
            }

            if (first < second)
            {
                temp = first;
                first = second;
                second = temp;
            }

            if (second < third)
            {
                temp = second;
                second = third;
                third = temp;
            }

            return third;
        }
    }
}
