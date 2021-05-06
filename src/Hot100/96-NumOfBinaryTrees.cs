namespace Hot100
{
    // good
    // f(1) = 1, f(0) = 1
    // f(2) = f(0)*f(1) + f(1)* f(0) = 2
    // f(3) = f(0)*f(2) + f(1)*f(1) + f(2)*f(0)
    // f(4) = f(0)*f(3) + f(1)*f(2) + f(2)*f(1) + f(3)*f(0)
    public class NumOfBinaryTreesSolution
    {
        public int NumTrees(int n)
        {
            var dp = new int[n + 1];
            dp[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                var sum = 0;
                for (int j = 0; j < i; j++)
                {
                    sum += dp[j] * dp[i - j - 1];
                }
                dp[i] = sum;
            }

            return dp[n];
        }
    }
}