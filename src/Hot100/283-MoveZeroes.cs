namespace Hot100
{
    public class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums)
        {
            var numOfZeroes = 0;
            var index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    numOfZeroes++;
                    continue;
                }

                Swap(nums, i, index);
                index++;

                if (index + numOfZeroes >= nums.Length) return;
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