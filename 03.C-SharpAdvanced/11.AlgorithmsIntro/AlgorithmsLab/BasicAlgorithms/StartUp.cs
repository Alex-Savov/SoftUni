using System;
using System.Linq;


namespace BasicAlgorithms
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var inputCoins = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] inputSum = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int[] availableCoins = inputCoins
                .Skip(1)
                .Select(int.Parse)
                .ToArray();

            int targetSum = int.Parse(inputSum[1]);

            var selectedCoins = new GreedyAlgorithms().ChooseCoins(availableCoins, targetSum);

            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (var selectedCoin in selectedCoins)
            {
                Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
            }


            //    //====== recursive factorial test ========

            //    int n = int.Parse(Console.ReadLine());
            //    Console.WriteLine(new Recursion().RecursiveFactorial(n));

            //    //====== recursive array sum test =========

            //    //int[] numbers = Console.ReadLine()
            //    //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    //    .Select(int.Parse)
            //    //    .ToArray();

            //    //Console.WriteLine(Sum(numbers, numbers.Length - 1));
        }
    }
}
