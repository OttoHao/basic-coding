namespace Hot100
{
    public class SingleNumberSolution
    {
        public int SingleNumber(int[] nums)
        {
            var ret = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ret ^= nums[i];
            }
            return ret;
        }
    }
}