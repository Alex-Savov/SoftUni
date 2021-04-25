using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            Stack<int> bulets = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Queue<int> locks = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int intelligenceValue = int.Parse(Console.ReadLine());
            int shotsCounter = 0;

            while (bulets.Count > 0 && locks.Count > 0)
            {
                int currentLock = locks.Peek();

                if (currentLock >= bulets.Pop())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                intelligenceValue -= bulletPrice;
                shotsCounter++;

                if (shotsCounter == gunBarrelSize && bulets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    shotsCounter = 0;
                }
            }

            if (bulets.Count == 0 && locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{bulets.Count} bullets left. Earned ${intelligenceValue}");
            }
        }
    }
}
