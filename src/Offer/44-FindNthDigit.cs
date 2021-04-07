using System;

namespace BasicCoding
{
    // 0, 1 * 9, 2 * 90, 3 * 900, 4 * 9000, 5 * 90000
    public class FindNthDigitSolution
    {
        public int FindNthDigit(int n)
        {
            if (n <= 0) return n;
            long input = n;
            var i = 1;
            while (input > 0)
            {
                long count = i * 9 * (long)Math.Pow(10, i - 1);
                if (input <= count) break;
                input -= count;
                i++;
            }

            long start = (long)Math.Pow(10, i - 1);
            var a = input / i;
            var b = input % i;

            return FindBthDigitInNumber((int)start + a, b);
        }

        private int FindBthDigitInNumber(long num, long b)
        {
            if (b == 0) return (int)(num-1) % 10;
            var str = num.ToString();
            var c = str[(int)b-1];
            return int.Parse(c.ToString());
        }
    }
}