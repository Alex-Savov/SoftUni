using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;
                if (maxValue < num)
                {
                    maxValue = num;
                }
            }

            int sumNoMax = sum - maxValue;
            if (sumNoMax == maxValue)
            {
                Console.WriteLine("Yes\nSum = " + maxValue);
            }
            else
            {
                int diff = Math.Abs(sumNoMax - maxValue);
                Console.WriteLine("No\nDiff = " + diff);
            }
        }
    }
}
