using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    public class DictionayTreeSolution
    {
        public IList<string> GetDuplicateStrings(IList<string> strs)
        {
            var root = new DictionaryTree(' ');
            var set = new HashSet<string>();

            for (int i = 0; i < strs.Count; i++)
            {
                var isDuplicate = true;
                var node = root;

                for (int j = 0; j < strs[i].Length; j++)
                {
                    var child = node.Children.FirstOrDefault(c => c.Value == strs[i][j]);
                    if (child == null)
                    {
                        child = new DictionaryTree(strs[i][j]);
                        node.Children.Add(child);
                        isDuplicate = false;
                    }
                    node = child;
                }

                if (isDuplicate && node.WordEnd)
                {
                    set.Add(strs[i]);
                }

                node.WordEnd = true;
            }

            return set.ToList();
        }
    }

    public class DictionaryTree
    {
        public char Value { get; set; }
        public IList<DictionaryTree> Children { get; set; }

        public bool WordEnd { get; set; }

        public DictionaryTree(char value)
        {
            Value = value;
            Children = new List<DictionaryTree>();
            WordEnd = false;
        }
    }
}