using System;

namespace Hot100
{
    public class MaximalSquareSolution
    {
        public int MaximalSquare(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return 0;

            var rows = matrix.Length;
            var cols = matrix[0].Length;
            var dp = new int[rows + 1, cols + 1];
            var maxDp = 0;
            for (int row = 1; row <= rows; row++)
            {
                for (int col = 1; col <= cols; col++)
                {
                    if (matrix[row - 1][col - 1] == '1')
                    {
                        var min = Math.Min(dp[row - 1, col], Math.Min(dp[row, col - 1], dp[row - 1, col - 1]));
                        dp[row, col] = min + 1;
                        maxDp = Math.Max(maxDp, dp[row, col]);
                    }
                }
            }
            return maxDp * maxDp;
        }
    }
}