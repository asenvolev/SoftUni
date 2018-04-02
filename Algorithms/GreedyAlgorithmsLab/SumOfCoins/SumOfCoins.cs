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
        var result = new Dictionary<int, int>();
        var currentSum = 0;
        int restSum = targetSum - currentSum;

        foreach (var coin in coins.OrderByDescending(c => c))
        {
            if (currentSum == targetSum)
                break;

            int currentCoinCount = restSum / coin;

            if (currentCoinCount != 0)
            {
                currentSum += coin * currentCoinCount;
                result[coin] = currentCoinCount;
                restSum = targetSum - currentSum;
            }
        }

        if (currentSum != targetSum)
            throw new InvalidOperationException();

        return result;
    }
}