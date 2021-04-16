namespace BasicCoding
{
    public class LastRemainingInCircleSolution
    {
        // f(n, m) = (f(n-1, m) + m)%n
        public int LastRemaining(int n, int m)
        {
            var x = 0;
            for (int i = 1; i <= n; i++)
            {
                x = (x + m) % i;
            }
            return x;
        }
    }
}