using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class Trie
    {
        private TreeNode _root;
        /** Initialize your data structure here. */
        public Trie()
        {
            _root = new TreeNode(' ');
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            var node = _root;
            foreach (var item in word)
            {
                var child = node.Children.FirstOrDefault(x => x.Value == item);
                if (child == null)
                {
                    child = new TreeNode(item);
                    node.Children.Add(child);
                }
                node = child;
            }
            node.WordEnd = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var node = _root;
            foreach (var item in word)
            {
                var child = node.Children.FirstOrDefault(x => x.Value == item);
                if (child == null) return false;
                node = child;
            }
            return node.WordEnd;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            var node = _root;
            foreach (var item in prefix)
            {
                var child = node.Children.FirstOrDefault(x => x.Value == item);
                if (child == null) return false;
                node = child;
            }
            return true;
        }


        public class TreeNode
        {
            public char Value { get; set; }
            public IList<TreeNode> Children { get; set; }
            public bool WordEnd { get; set; }
            public TreeNode(char value)
            {
                Value = value;
                Children = new List<TreeNode>();
            }
        }
    }
}