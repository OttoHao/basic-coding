using System;

namespace Hot100
{
    public class FindDuplicateSolution
    {
        public int FindDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] != i + 1)
                {
                    if (nums[i] == nums[nums[i] - 1]) return nums[i];
                    Swap(nums, i, nums[i] - 1);
                }
            }
            return -1;
        }

        private void Swap(int[] nums, int a, int b)
        {
            var temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}