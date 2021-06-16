namespace Hot100
{
    public class ProductExceptSelfSolution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var ret = new int[nums.Length];
            ret[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                ret[i] = ret[i + 1] * nums[i];
            }

            var left = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                left = i >= 1 ? left * nums[i-1] : 1;
                var right = i < nums.Length - 1 ? ret[i + 1] : 1;
                ret[i] = left * right;
            }
            return ret;
        }
    }
}