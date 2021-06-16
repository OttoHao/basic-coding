using System;

namespace Hot100
{
    public class LengthOfLISSolution
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            var lens = new int[nums.Length];

            var len = 1;
            var maxLen = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] > nums[j])
                    {
                        len = Math.Max(lens[j] + 1, len);
                    }
                }

                lens[i] = len;
                maxLen = Math.Max(len, maxLen);
                len = 1;
            }

            return maxLen;
        }
    }
}