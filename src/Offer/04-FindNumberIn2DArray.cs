namespace BasicCoding
{
    public class FindNumberIn2DArraySolution
    {
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }
            var rows = matrix.Length;
            var columns = matrix[0].Length;

            var row = 0;
            var column = columns - 1;

            while (row < rows && column >= 0)
            {
                var num = matrix[row][column];
                if (target == num)
                {
                    return true;
                }
                else if (target > num)
                {
                    row++;
                }
                else
                {
                    column--;
                }
            }

            return false;
        }
    }
}