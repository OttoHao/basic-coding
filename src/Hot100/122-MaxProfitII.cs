using System;

namespace Hot100
{
    public class MaxProfitIISolution
    {
        // dp[i][0] = max(dp[i-1][1] + price[i], dp[i-1][0])
        // dp[i][1] = max(dp[i-1][0] - price[i], dp[i-1][1])
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 1) return 0;

            var dp0 = 0;
            var dp1 = -prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                var newDp0 = Math.Max(dp1 + prices[i], dp0);
                var newDp1 = Math.Max(dp0 - prices[i], dp1);

                dp0 = newDp0;
                dp1 = newDp1;
            }
            return dp0;
        }
    }
}