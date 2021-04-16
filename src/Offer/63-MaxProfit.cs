namespace BasicCoding
{
    public class MaxProfitSolution
    {
        
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 0) return 0;
            var dp = 0;
            var maxDp = 0;
            var preMin = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                dp = prices[i] - preMin;
                maxDp = dp > maxDp ? dp : maxDp;
                preMin = prices[i] < preMin ? prices[i] : preMin;
            }

            return maxDp;
        }
    }
}