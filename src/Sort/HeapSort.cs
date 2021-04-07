using System.Collections.Generic;

namespace BasicCoding
{
    public static class HeapSort
    {
        public static void Sort(IList<int> nums)
        {
            var length = nums.Count;
            BuildMaxHeap(nums, length);
            for (int i = length - 1; i >= 0; i--)
            {
                Swap(nums, 0, i);
                Heapify(nums, 0, i);
            }
        }

        public static void BuildMaxHeap(IList<int> nums, int length)
        {
            for (int i = length / 2; i >= 0; i--)
            {
                Heapify(nums, i, length);
            }
        }

        public static void Heapify(IList<int> nums, int i, int length)
        {
            var left = 2 * i + 1;
            var right = 2 * i + 2;
            var max = i;

            if (left < length && nums[left] > nums[max])
            {
                max = left;
            }

            if (right < length && nums[right] > nums[max])
            {
                max = right;
            }
            if (max != i)
            {
                Swap(nums, max, i);
                Heapify(nums, max, length);
            }
        }

        public static void Swap(IList<int> nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}