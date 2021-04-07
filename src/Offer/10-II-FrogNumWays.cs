namespace BasicCoding
{
    public class FrogNumWaysSolution
    {
        public int NumWays(int n)
        {
            var a = 1;
            var b = 2;

            var ret = 0;
            for (int i = 1; i < n; i++)
            {
                ret = (a + b) % 1000000007;
                a = b; 
                b = ret;
            }

            return a;
        }
    }
}