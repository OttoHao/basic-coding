namespace BasicCoding
{
    //todo how to update ret
    public class MajorElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            var votes = 0;
            var ret = 0;
            foreach (var num in nums)
            {
                if (votes == 0) ret = num;
                votes += num == ret ? +1 : -1;
            }

            return ret;
        }
    }
}