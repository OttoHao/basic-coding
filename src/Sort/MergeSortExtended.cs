using System;
using System.Collections.Generic;

namespace BasicCoding
{
    public static class MergeSortExtended
    {
        public static int Sort(IList<int> nums)
        {
            return Sort(nums, 0, nums.Count - 1);
        }

        private static int Sort(IList<int> nums, int left, int right)
        {
            if (left >= right)
            {
                return 0;
            }

            var middle = (left + right) / 2;
            var leftPairs = Sort(nums, left, middle);
            var rightPairs = Sort(nums, middle + 1, right);

            var mergedPairs = Merge(nums, left, right, middle);

            return leftPairs + rightPairs + mergedPairs;

        }

        private static int Merge(IList<int> nums, int left, int right, int middle)
        {
            var i = left;
            var j = middle + 1;
            var temp = new List<int>();
            var count = 0;

            while (i <= middle && j <= right)
            {
                if (nums[i] <= nums[j])
                {
                    temp.Add(nums[i]);
                    i++;
                }
                else
                {
                    temp.Add(nums[j]);
                    j++;
                    count += (middle - i + 1);
                }
            }

            while (i <= middle)
            {
                temp.Add(nums[i]);
                i++;
            }

            while (j <= right)
            {
                temp.Add(nums[j]);
                j++;
            }


            for (int k = 0; k < temp.Count; k++)
            {
                nums[left + k] = temp[k];
            }

            return count;
        }
    }
}