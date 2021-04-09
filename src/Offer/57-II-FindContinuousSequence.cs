using System.Collections.Generic;

namespace BasicCoding
{
    public class FindContinuousSequenceSolution
    {
        public int[][] FindContinuousSequence(int target)
        {
            var start = 1;
            var end = 2;
            var sum = start + end;
            var ret = new List<int[]>();
            while (start <= target >> 1)
            {
                if (target > sum)
                {
                    end++;
                    sum += end;
                }
                else if (target < sum)
                {
                    sum -= start;
                    start++;
                }
                else
                {
                    var temp = new List<int>();
                    for (int i = start; i <= end; i++)
                    {
                        temp.Add(i);
                    }
                    ret.Add(temp.ToArray());

                    start++;
                    end = start + 1;
                    sum = start + end;
                }
            }

            return ret.ToArray();
        }
    }
}