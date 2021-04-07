using System;

namespace BasicCoding
{
    public class MaxValueInGiftsSolution
    {
        public int MaxValue(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0) return -1;

            var rows = grid.Length;
            var columns = grid[0].Length;

            var dp = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                dp[i] = new int[columns];
            }

            dp[0][0] = grid[0][0];

            for (int i = 1; i < columns; i++)
            {
                dp[0][i] = dp[0][i - 1] + grid[0][i];
            }

            for (int i = 1; i < rows; i++)
            {
                dp[i][0] = dp[i - 1][0] + grid[i][0];
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]) + grid[i][j];
                }
            }

            return dp[rows - 1][columns - 1];
        }
    }
}