using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2;

            int sumNumber = 0;
            for (int i = 0; i < num; i += num2)
            {
                num2 = int.Parse(Console.ReadLine());
                sumNumber += num2;
            }

            Console.WriteLine(sumNumber);

            //int num = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int sumNumber = 0;
            //while (true)
            //{
            //    sumNumber += num2;

            //    if (sumNumber >= num)
            //    {
            //        break;
            //    }
            //    num2 = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine(sumNumber);
        }
    }
}
