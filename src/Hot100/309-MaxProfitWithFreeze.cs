using System;

namespace Hot100
{
    public class MaxProfitWithFreezeSolution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 1) return 0;
            var len = prices.Length;
            var dp = new int[3];


            dp[0] = -prices[0];
            dp[1] = 0;
            dp[2] = 0;

            for (int i = 1; i < len; i++)
            {
                var dp0 = Math.Max(dp[0], dp[2] - prices[i]);
                var dp1 = dp[0] + prices[i];
                var dp2 = Math.Max(dp[1], dp[2]);

                dp[0] = dp0;
                dp[1] = dp1;
                dp[2] = dp2;
            }

            return Math.Max(dp[1], dp[2]);
        }
    }
}