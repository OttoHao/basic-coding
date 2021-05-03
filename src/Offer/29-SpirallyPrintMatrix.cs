using System.Collections.Generic;

namespace BasicCoding
{
    public class SpirallyPrintMatrixSolution
    {
        public int[] SpiralOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return new int[0];

            var left = 0;
            var right = matrix[0].Length - 1;
            var top = 0;
            var bottom = matrix.Length - 1;

            var ret = new List<int>();
            while (true)
            {
                for (int i = left; i <= right; i++)
                {
                    ret.Add(matrix[top][i]);
                }

                top++;
                if (top > bottom) break;

                for (int i = top; i <= bottom; i++)
                {
                    ret.Add(matrix[i][right]);    
                }

                right--;
                if (right < left) break;

                for (int i = right; i >= left; i--)
                {
                    ret.Add(matrix[bottom][i]);
                }

                bottom--;
                if (bottom < top) break;

                for (int i = bottom; i >= top; i--)
                {
                    ret.Add(matrix[i][left]);
                }

                left++;
                if(left > right) break;

            }

            return ret.ToArray();
        }

        
    }
}