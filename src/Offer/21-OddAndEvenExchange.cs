namespace BasicCoding
{
    public class OddAndEvenExchangeSolution
    {
        public int[] Exchange(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            var length = nums.Length;
            while (left < right)
            {
                while (left < length &&  (nums[left] & 1) == 1)
                {
                    left++;
                }

                while (right >= 0 && (nums[right] & 1) == 0)
                {
                    right--;
                }

                if (left < right)
                {
                    Swap(nums, left, right);    
                }
            }

            return nums;
        }

        private void Swap(int[] nums, int left, int right)
        {
            var temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }
    }
}