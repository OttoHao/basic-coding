namespace BasicCoding
{
    public class MinOfRotateArraySolution
    {
        public int MinArray(int[] numbers)
        {
            var left = 0;
            var right = numbers.Length - 1;
            while (left < right)
            {
                var middle = left + (right - left) / 2;
                if ( numbers[middle] < numbers[right])
                {
                    right = middle;
                }
                else if ( numbers[middle] > numbers[right])
                {
                    left = middle + 1;
                }
                else
                {
                    right--;
                }
            }

            return numbers[left];
        }
    }
}