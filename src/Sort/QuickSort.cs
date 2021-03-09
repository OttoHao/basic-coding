using System.Collections.Generic;

namespace BasicCoding
{
    public static class QuickSort
    {
        public static void Sort(IList<int> nums)
        {
            Sort(nums, 0, nums.Count - 1);
        }
        
        public static void Sort(IList<int> nums, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var pivotIndex = Partition(nums, start, end);
            Sort(nums, start, pivotIndex - 1);
            Sort(nums, pivotIndex + 1, end);
        }

        private static int Partition(IList<int> nums, int start, int end)
        {
            var pivot = nums[start];
            var pivotIndex = start;

            for (int i = pivotIndex + 1; i < end; i++)
            {
                if (nums[i] < pivot)
                {
                    Swap(nums, i, pivotIndex + 1);
                    pivotIndex++;
                }
            }

            Swap(nums, start, pivotIndex);
            return pivotIndex;

        }

        private static void Swap(IList<int> nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}