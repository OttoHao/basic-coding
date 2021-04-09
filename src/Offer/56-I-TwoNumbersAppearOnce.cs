using System.Collections.Generic;

namespace BasicCoding
{
    public class TwoNumbersAppearOnceSolution
    {
        public int[] SingleNumbers(int[] nums)
        {
            int xor = FindOneSingleNumber(nums);

            var one = GetOne(xor);

            var first = 0;
            var second = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & one) == 0) first ^= nums[i];
                else second ^= nums[i];
            }

            return new int[] { first, second };
        }

        private static int FindOneSingleNumber(int[] nums)
        {
            var xor = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                xor ^= nums[i];
            }

            return xor;
        }

        private int GetOne(int value)
        {
            var ret = 1;
            while ((value & ret) == 0)
            {
                ret = ret << 1;
            }
            return ret;
        }
    }
}