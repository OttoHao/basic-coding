using System;

namespace Hot100
{
    public class MaxProfitSolution
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;
            var min = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                profit = Math.Max(profit, prices[i] - min);
                min = Math.Min(min, prices[i]);
            }
            return profit;
        }
    }
}