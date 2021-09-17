using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        Dictionary<int, int> coinsUsed = new Dictionary<int, int>();
        int numberOfCoins = 0;
        int coinIndex = coins.Count - 1;
        int currentCoin = coins[coinIndex];

        while (targetSum < 0)
        {
            if (targetSum > currentCoin)
            {
                numberOfCoins = targetSum / currentCoin;
                coinsUsed.Add(currentCoin, numberOfCoins);
                targetSum = targetSum % currentCoin;
                coinIndex--;
            }
        }

        return coinsUsed;
    }
}