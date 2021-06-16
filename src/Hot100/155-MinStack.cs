using System.Collections.Generic;

namespace Hot100
{
    public class MinStack
    {

        /** initialize your data structure here. */
        private Stack<int> _a = new Stack<int>();
        private Stack<int> _b = new Stack<int>();
        public MinStack()
        {

        }

        public void Push(int val)
        {
            _a.Push(val);
            if (!_b.TryPeek(out var min) || min >= val)
                _b.Push(val);
        }

        public void Pop()
        {
            var val = _a.Pop();
            if (_b.Peek() == val)
                _b.Pop();
        }

        public int Top()
        {
            return _a.Peek();
        }

        public int GetMin()
        {
            return _b.Peek();
        }
    }
}