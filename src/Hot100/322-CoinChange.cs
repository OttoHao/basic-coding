using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class CoinChangeSolution
    {
        public int CoinChange(int[] coins, int amount)
        {
            var dp = new int[amount + 1];
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                var min = int.MaxValue;
                foreach (var coin in coins)
                {
                    if (i - coin >= 0 && dp[i - coin] >= 0)
                    {
                        min = Math.Min(dp[i - coin] + 1, min);
                    }
                }
                dp[i] = min == int.MaxValue ? -1 : min;
            }
            return dp[amount];
        }

        private int dfs(int[] coins, int amount, int[] counts)
        {
            if (amount < 0)
            {
                return -1;
            }
            if (amount == 0)
            {
                return 0;
            }
            if (counts[amount - 1] != 0)
            {
                return counts[amount - 1];
            }
            var min = int.MaxValue;
            for (int i = 0; i < coins.Length; i++)
            {
                var ret = dfs(coins, amount - coins[i], counts);
                if (ret >= 0 && ret < min)
                {
                    min = ret + 1;
                }
            }
            counts[amount - 1] = min == int.MaxValue ? -1 : min;
            return counts[amount - 1];
        }
    }
}