using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class TopKFrequentSolution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i])){
                    dic[nums[i]] ++;
                }
                else{
                    dic.Add(nums[i], 1);
                }
            }

            return dic.OrderByDescending(item => item.Value).Take(k).Select(item => item.Key).ToArray();
        }
    }
}