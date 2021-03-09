using System;
using System.Collections.Generic;

namespace BasicCoding
{
    public static class MergeSort
    {
        public static void Sort(IList<int> nums)
        {
            Sort(nums, 0, nums.Count - 1);
        }

        private static void Sort(IList<int> nums, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var middle = (left + right) / 2;
            Sort(nums, left, middle);
            Sort(nums, middle + 1, right);

            Merge(nums, left, right, middle);

        }

        private static void Merge(IList<int> nums, int left, int right, int middle)
        {
            var i = left;
            var j = middle + 1;
            var temp = new List<int>();

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
        }
    }
}