using System.Collections.Generic;

namespace BasicCoding
{
    public class MinStack
    {

        /** initialize your data structure here. */

        private Stack<int> _firstStack = new Stack<int>();
        private Stack<int> _secondStack = new Stack<int>();
        public MinStack()
        {

        }

        public void Push(int x)
        {
            _firstStack.Push(x);

            if (!_secondStack.TryPeek(out var any) || _secondStack.Peek() >= x)
            {
                _secondStack.Push(x);
            }
        }

        public void Pop()
        {
            if (_firstStack.Pop() == _secondStack.Peek())
            {
                _secondStack.Pop();
            }
        }

        public int Top()
        {
            return _firstStack.Peek();
        }

        public int Min()
        {
            return _secondStack.Peek();
        }
    }
}