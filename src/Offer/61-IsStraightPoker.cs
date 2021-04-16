using System.Collections.Generic;

namespace BasicCoding
{
    public class IsStraightPokerSolution
    {
        public bool IsStraight(int[] nums)
        {
            var set = new HashSet<int>();
            var min = 13;
            var max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    min = nums[i] < min ? nums[i] : min;
                    max = nums[i] > max ? nums[i] : max;

                    if (set.Contains(nums[i])) return false;

                    set.Add(nums[i]);
                }
            }
            return max - min < 5;
        }
    }
}