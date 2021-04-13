using System;
using System.Collections.Generic;
using System.Text;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> topNumbers = TopNum(number);
            foreach (var item in topNumbers)
            {
                Console.WriteLine(item);
            }
        }
        static List<int> TopNum (int num)
        {
            List<int> topNums = new List<int>();

            for (int i = 10; i <= num; i++)
            {
                int currentNum = i;
                int digitsSum = 0;
                bool isContainsOdd = false;

                while (currentNum > 0)
                {
                    int lastDigit = currentNum % 10;

                    if (lastDigit % 2 != 0)
                    {
                        isContainsOdd = true;
                    }

                    digitsSum += lastDigit;
                    currentNum /= 10;
                }

                bool isDivisible = digitsSum % 8 == 0;

                if (isContainsOdd && isDivisible)
                {
                    topNums.Add(i);
                }
            }

            return topNums;
        }
    }
}
