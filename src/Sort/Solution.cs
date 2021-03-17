using System;
using System.Collections.Generic;

namespace BasicCoding
{
    public class Solution
    {
        public void FindMaxK(int[] nums, int k)
        {
            var length = nums.Length;
            BuildMaxHeap(nums);
            for (int i = nums.Length - 1; i >= nums.Length - k; i--)
            {
                Swap(nums, 0, length - 1);
                System.Console.WriteLine(nums[i]);
                length--;
                MaxHeapily(nums, 0, length);
            }
        }
        public void HeapSort(int[] nums)
        {
            var length = nums.Length;
            BuildMaxHeap(nums);
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Swap(nums, 0, length - 1);
                length--;
                MaxHeapily(nums, 0, length);
            }
        }

        private void BuildMaxHeap(int[] nums)
        {
            for (int i = (nums.Length - 1) / 2; i >= 0; i--)
            {
                MaxHeapily(nums, i, nums.Length);
            }
        }

        private void MaxHeapily(int[] nums, int i, int length)
        {
            var left = 2 * i + 1;
            var right = 2 * i + 2;
            var maxIndex = i;

            if (left < length && nums[left] > nums[maxIndex])
            {
                maxIndex = left;
            }

            if (right < length && nums[right] > nums[maxIndex])
            {
                maxIndex = right;
            }

            if (maxIndex != i)
            {
                Swap(nums, i, maxIndex);
                MaxHeapily(nums, maxIndex, length);
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}