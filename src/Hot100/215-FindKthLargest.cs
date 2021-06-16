namespace Hot100
{
    public class FindKthLargestSolution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var length = nums.Length;
            for (int i = length / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(nums, i, length);
            }

            for (int i = length - 1; i > length - k; i--)
            {
                Swap(nums, 0, i);
                MaxHeapify(nums, 0, i);
            }
            
            return nums[0];
        }

        private void MaxHeapify(int[] nums, int i, int length)
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
                Swap(nums, i, max);
                MaxHeapify(nums, max, length);
            }
        }

        private void Swap(int[] nums, int a, int b)
        {
            var temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}