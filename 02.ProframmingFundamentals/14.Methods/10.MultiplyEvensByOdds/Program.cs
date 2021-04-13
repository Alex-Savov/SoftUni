using System;
using System.Linq;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }
        static int GetSumOfOdds (int num)
        {

            string number = num.ToString();
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int n = int.Parse(number[i].ToString());
                if (n % 2 != 0)
                {
                    result += int.Parse(number[i].ToString());
                }
            }
            return result;
        }

        static int GetSumOfEvens (int num)
        {
            string number = num.ToString();
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int n = int.Parse(number[i].ToString());
                if (n % 2 == 0)
                {
                    result += int.Parse(number[i].ToString());
                }
            }
            return result;
        }
        static int GetMultipleOfEvenAndOdds(int num)
        {
            int result = (GetSumOfEvens(num) * GetSumOfOdds(num));
            return result;
        }
    }
}
