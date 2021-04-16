using System;
using System.Collections.Generic;

namespace BasicCoding
{
    public class DicesProbabilitySolution
    {
        // f(n, m) = f(n-1, m-1) + f(n-1, m-2)+ f(n-1, m-3) + f(n-1, m-4)+ f(n-1, m -5) + f(n-1, m -6);

        public double[] DicesProbability(int n)
        {
            var dp = new int[n + 1, 6 * n + 1];
            for (int i = 1; i <= 6; i++)
            {
                dp[1, i] = 1;
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = i; j <= 6 * n; j++)
                {
                    dp[i, j] = dp[i - 1, j - 1];
                    if (j - 2 > 0) dp[i, j] += dp[i - 1, j - 2];
                    if (j - 4 > 0) dp[i, j] += dp[i - 1, j - 4];
                    if (j - 3 > 0) dp[i, j] += dp[i - 1, j - 3];
                    if (j - 5 > 0) dp[i, j] += dp[i - 1, j - 5];
                    if (j - 6 > 0) dp[i, j] += dp[i - 1, j - 6];
                }
            }


            var ret = new List<double>();
            var total = Math.Pow(6, n);

            for (int i = n; i <= 6 * n; i++)
            {
                var prob = dp[n, i] / total;
                ret.Add(prob);
            }

            return ret.ToArray();
        }



    }
}