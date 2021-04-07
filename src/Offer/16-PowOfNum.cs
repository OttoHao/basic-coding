namespace BasicCoding
{
    //todo line 20 - 22
    public class PowOfNumSolution
    {
        public double MyPow(double x, int n)
        {
            if (x == 0) return 0;

            long b = n;
            if (n < 0)
            {
                x = 1 / x;
                b = -b;
            }

            double ret = 1;
            while (b > 0)
            {
                if ((b & 1) == 1) ret *= x;
                b >>= 1;
                x *= x;
            }
            return ret;
        }
    }
}