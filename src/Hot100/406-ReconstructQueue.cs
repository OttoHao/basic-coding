using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Hot100
{
    // [[7,0],[4,4],[7,1],[5,0],[6,1],[5,2]]
    // 
    // 
    public class ReconstructQueueSolution
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            var ordered = people.OrderByDescending(x => x, new Comparer()).ToArray();

            var ret = new List<int[]>();
            for (int i = 0; i < ordered.Length; i++)
            {
                var index = ordered[i][1];
                ret.Insert(index, ordered[i]);
            }
            return ret.ToArray();
        }

        private class Comparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                if (x[0] > y[0]) return 1;
                if (x[0] < y[0]) return -1;
                return y[1].CompareTo(x[1]);
            }
        }
    }
}