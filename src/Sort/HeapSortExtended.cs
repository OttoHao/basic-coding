using System;
using System.Collections.Generic;

namespace BasicCoding
{
    public static class HeapSortExtended
    {
        public static IList<int> FindMaxs(IList<int> nums, int k)
        {
            if (k < 0 || k > nums.Count){
                throw new ArgumentException($"input k should between 0 and {nums.Count}");
            }

            var ret = new List<int>();

            var length = nums.Count;
            var start = length - 1;
            var end = length - k;

            HeapSort.BuildMaxHeap(nums, length);

            for (int i = start; i >= end; i--)
            {
                ret.Add(nums[0]);
                HeapSort.Swap(nums, i, 0);
                length--;
                HeapSort.Heapify(nums, 0, length);
            }

            return ret;
        }
    }
}