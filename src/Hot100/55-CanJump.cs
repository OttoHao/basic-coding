using System;

namespace Hot100
{
    // good
    public class CanJumpSolution
    {
        public bool CanJump(int[] nums)
        {
            var end = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i <= end)
                {
                    end = Math.Max(end, i + nums[i]);
                    if (end >= nums.Length - 1) return true;
                }
            }

            return false;
        }


    }
}