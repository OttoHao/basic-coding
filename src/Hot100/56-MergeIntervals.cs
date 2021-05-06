using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class MergeIntervalsSolution
    {
        public int[][] Merge(int[][] intervals)
        {
            var ret = new int[intervals.Length][];
            var index = 0;
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

            for (int i = 0; i < intervals.Length; i++)
            {
                if (CanMerge(ret[index], intervals[i]))
                {
                    ret[index] = Merge(ret[index], intervals[i]);
                }
                else
                {
                    index++;
                    ret[index] = intervals[i];
                }
            }

            return ret[0..(index+1)];
        }

        private int[] Merge(int[] left, int[] right)
        {
            if (left == null) return right;
            return new int[] { left[0], Math.Max(left[1], right[1])};
        }

        private bool CanMerge(int[] left, int[] right)
        {
            if (left == null) return true;
            return left[1] >= right[0];
        }
    }
}