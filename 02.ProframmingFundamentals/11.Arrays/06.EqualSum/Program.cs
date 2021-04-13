using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            bool isExist = false;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int sumLeft = 0;
                for (int j = i; j >= 0; j--)
                {
                    sumLeft += arr[j];
                }

                int sumRight = 0;
                for (int k = i; k < arr.Length; k++)
                {
                    sumRight += arr[k];
                }

                if (sumRight == sumLeft)
                {
                    isExist = true;
                    Console.WriteLine(i);
                }
            }

           if(!isExist)
            {
                Console.WriteLine("no");
            }
        }
    }
}
