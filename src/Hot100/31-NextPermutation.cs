namespace Hot100
{
    public class NextPermutationSolution
    {
        // 2 3 5 4 1 => 2 4 5 3 1 => 2 4 1 3 5
        public void NextPermutation(int[] nums)
        {
            var left = -1;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i - 1] >= nums[i]) continue;
                left = i - 1;
                break;
            }

            if (left == -1)
            {
                Reverse(nums, 0, nums.Length - 1);
                return;
            }

            var right = -1;
            for (int i = nums.Length - 1; i > left; i--)
            {
                if (nums[i] > nums[left])
                {
                    right = i;
                    break;
                }
            }

            Swap(nums, left, right);
            Reverse(nums, left + 1, nums.Length - 1);
        }

        private void Swap(int[] nums, int left, int right)
        {
            var temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }

        private void Reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                Swap(nums, left, right);
                left++;
                right--;
            }
        }
    }
}