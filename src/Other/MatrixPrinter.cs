namespace BasicCoding
{
    public class MatrixPrinter
    {
        public static void PrintMatrix(int[,] inputs)
        {
            var rows = inputs.GetUpperBound(0) + 1;
            var cols = inputs.GetLength(1);

            var start = 0;
            PrintMatrix(inputs, rows, cols, start);
        }

        private static void PrintMatrix(int[,] inputs, int rows, int cols, int start)
        {
            if (rows < start * 2 || cols < start * 2)
            {
                return;
            }

            for (int i = start; i < cols - start; i++)
            {
                System.Console.WriteLine(inputs[start, i]);
            }

            if (start < rows - start - 1)
            {
                for (int j = start + 1; j < rows - start; j++)
                {
                    System.Console.WriteLine(inputs[j, cols - start - 1]);
                }
            }

            if (start < cols - start - 1 && start < rows - start - 1)
            {
                for (int k = cols - start - 2; k >= start; k--)
                {
                    System.Console.WriteLine(inputs[rows - start - 1, k]);
                }
            }

            if (start < rows - start - 2 && start < cols - start - 1)
            {
                for (int l = rows - start - 2; l > start; l--)
                {
                    System.Console.WriteLine(inputs[l, start]);
                }
            }


            PrintMatrix(inputs, rows, cols, start + 1);
        }
    }

}