using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];

            for (int i = 0; i < n; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}\n{1}",
                string.Join(' ', train) ,train.Sum());
        }
    }
}
