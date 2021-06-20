using System;

namespace Hot100
{
    public class CountBitsSolution
    {
        public int[] CountBits(int n)
        {
            var ret = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                ret[i] = ret[i & (i - 1)] + 1;
            }
            return ret;
        }

        private int CountBitsForOne(int n)
        {
            var count = 1;
            n = n & (n - 1);
            while (n != 0)
            {
                n = n & (n - 1);
                count++;
            }
            return count;
        }
    }
}