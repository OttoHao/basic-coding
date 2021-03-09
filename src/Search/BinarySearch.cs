using System.Collections.Generic;


namespace BasicCoding
{
    public static class BinarySearchUtility
    {
        public static int BinarySearch(IList<int> numbers, int target)
        {
            var start = 0;
            var end = numbers.Count - 1;
            int middle;
            while (start <= end)
            {
                middle = (start + end) / 2;
                if (target == numbers[middle])
                    return middle;
                if (target < numbers[middle])
                    end = middle;
                else
                    start = middle;
            }

            return -1;
        }

        public static int BinarySearchRecursively(IList<int> numbers, int start, int end, int target)
        {
            if (start >= end)
            {
                return -1;
            }

            var middle = (start + end) / 2;
            if (target == numbers[middle])
            {
                return middle;
            }

            if (target > numbers[middle])
            {
                return BinarySearchRecursively(numbers, middle, end, target);
            }
            else
            {
                return BinarySearchRecursively(numbers, start, middle, target);
            }

        }
    }
}