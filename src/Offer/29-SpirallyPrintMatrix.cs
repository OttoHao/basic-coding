using System.Collections.Generic;

namespace BasicCoding
{
    public class SpirallyPrintMatrixSolution
    {
        public int[] SpiralOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return new int[0];

            var rows = matrix.Length - 1;
            var columns = matrix[0].Length - 1;

            var ret = new List<int>();
            for (int i = 0; i <= rows / 2 + 1; i++)
            {
                ret.AddRange(SpiralOrder(matrix, i, rows, columns));
            }

            return ret.ToArray();
        }

        private IList<int> SpiralOrder(int[][] matrix, int start, int rows, int columns)
        {
            var ret = new List<int>();

            if (columns - start < start || rows - start < start)
            {
                return ret;
            }

            if (columns - start >= start)
            {
                for (int i = start; i <= columns - start; i++)
                {
                    ret.Add(matrix[start][i]);
                }
            }

            if (rows - start >= start + 1)
            {
                for (int i = start + 1; i <= rows - start; i++)
                {
                    ret.Add(matrix[i][columns - start]);
                }
            }

            if (columns - start - 1 >= start && rows - start >= start + 1)
            {
                for (int i = columns - start - 1; i >= start; i--)
                {
                    ret.Add(matrix[rows - start][i]);
                }
            }

            if (rows - start - 1 >= start + 1 && columns - start - 1 >= start)
            {
                for (int i = rows - start - 1; i >= start + 1; i--)
                {
                    ret.Add(matrix[i][start]);
                }
            }


            return ret;
        }
    }
}