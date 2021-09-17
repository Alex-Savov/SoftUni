
using System.Collections.Generic;
using System.Linq;


namespace BasicAlgorithms
{
    public class GreedyAlgorithms
    {
        public Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            Dictionary<int, int> coinsUsed = new Dictionary<int, int>();
            int[] sortedCoins = coins.OrderBy(c => c).ToArray();
            int numberOfCoins = 0;
            int coinIndex = sortedCoins.Length - 1;


            while (targetSum > 0)
            {
                int currentCoin = sortedCoins[coinIndex];

                if (targetSum >= currentCoin)
                {
                    numberOfCoins = targetSum / currentCoin;
                    coinsUsed.Add(currentCoin, numberOfCoins);
                    targetSum = targetSum % currentCoin;
                }

                if (coinIndex > 0)
                {
                    coinIndex--; ;
                }
            }

            return coinsUsed;
        }
    }
}
