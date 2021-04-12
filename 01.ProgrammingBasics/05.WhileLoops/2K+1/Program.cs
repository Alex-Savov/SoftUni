using System;

namespace _2K_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sumNumber = 1;
            while (sumNumber <= num)
            {
                //    Console.WriteLine(sumNumber);
                //    sumNumber = (sumNumber * 2) + 1;
                Console.WriteLine(sumNumber);
                if (sumNumber >= num)
                {
                    break;
                }
                sumNumber = (sumNumber * 2) + 1;
            }
        }
    }
}
