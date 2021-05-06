using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot100
{

    public class LRUCache
    {
        public class LRUNode
        {
            public int Key { get; set; }
            public int Value { get; set; }
            public LRUNode Left { get; set; }
            public LRUNode Right { get; set; }
            public LRUNode(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }
        private Dictionary<int, LRUNode> _cache; // good value
        private LRUNode _head;
        private LRUNode _tail;
        private int _capacity = 0;
        private int _count = 0;
        public LRUCache(int capacity)
        {
            _cache = new Dictionary<int, LRUNode>(capacity);
            _capacity = capacity;
            _head = new LRUNode(-1, -1);
            _tail = new LRUNode(-1, -1);
            _head.Right = _tail;
            _tail.Left = _head;
        }

        public int Get(int key)
        {
            if (_cache.TryGetValue(key, out var node))
            {
                MoveToHead(node);
                return node.Value;
            }
            return -1;
        }


        public void Put(int key, int value)
        {
            if (_cache.ContainsKey(key))
            {
                _cache[key].Value = value;
                MoveToHead(_cache[key]);
                return;
            }

            if (_count == _capacity)
            {
                _cache.Remove(_tail.Left.Key);
                RemoveNode(_tail.Left);
                _count--;
            }

            var node = new LRUNode(key, value);
            _cache.Add(key, node);
            AddToHead(node);
            _count++;
        }

        private void RemoveNode(LRUNode node)
        {
            node.Left.Right = node.Right;
            node.Right.Left = node.Left;
        }


        private void AddToHead(LRUNode node)
        {
            node.Left = _head;
            node.Right = _head.Right;
            _head.Right.Left = node;
            _head.Right = node;
        }

        private void MoveToHead(LRUNode node)
        {
            RemoveNode(node);
            AddToHead(node);
        }
    }
}