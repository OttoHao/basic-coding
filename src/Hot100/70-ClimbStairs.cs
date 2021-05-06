namespace Hot100
{
    public class ClimbStairsSolution
    {
        // 1 2 3 5 8
        public int ClimbStairs(int n)
        {
            var a = 1;
            var b = 2;

            for (int i = 1; i < n; i++)
            {
                var ret = a + b;
                a = b;
                b = ret;
            }

            return a;
        }
    }
}