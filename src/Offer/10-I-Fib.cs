namespace BasicCoding
{
    public class FibSolution
    {
        public int Fib(int n)
        {
            var a = 0;
            var b = 1;

            var ret = 0;
            for (int i = 0; i < n; i++)
            {
                ret = (a + b) % 1000000007;
                a = b;
                b = ret;
            }

            return a;
        }
    }
}