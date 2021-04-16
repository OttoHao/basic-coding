using System.Collections.Generic;

namespace BasicCoding
{
    public class MaxQueue
    {
        private Queue<int> _first;
        private LinkedList<int> _second;

        public MaxQueue()
        {
            _first = new Queue<int>();
            _second = new LinkedList<int>();
        }

        public int Max_value()
        {
            if (_second.First == null) return -1;
            return _second.First.Value;
        }

        public void Push_back(int value)
        {
            _first.Enqueue(value);
            while (_second.Last?.Value < value)
            {
                _second.RemoveLast();
            }
            _second.AddLast(value);
        }

        public int Pop_front()
        {
            if (!_first.TryDequeue(out var value)) return -1;

            if (value == _second.First?.Value)
            {
                _second.RemoveFirst();
            }

            return value;
        }
    }
}