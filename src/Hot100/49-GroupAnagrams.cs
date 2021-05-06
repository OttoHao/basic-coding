using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class GroupAnagramsSolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var str = strs[i];
                var temp = new string(str.OrderBy(x => x).ToArray());
                if (dic.ContainsKey(temp))
                {
                    dic[temp].Add(str);
                }
                else
                {
                    dic.Add(temp, new List<string>() { str });
                }
            }
            return dic.Values.ToList();
        }
    }
}