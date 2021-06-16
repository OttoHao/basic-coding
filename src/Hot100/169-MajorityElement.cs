namespace Hot100
{
    public class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            var ret = nums[0];
            var count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                ret = count == 0 ? nums[i] : ret;
                count += nums[i] == ret ? +1 : -1;
            }
            return ret;
        }
    }
}