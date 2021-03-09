using System.Collections.Generic;

namespace BasicCoding
{
    public class FindNumbersAppearedOnce
    {
        private static void FindTwoNumbersAppearedOnce(IList<int> nums)
        {
            int ret = GetNumberAppearedOnce(nums);

            var lastOneIndex = FindLastOneIndex(ret);

            var firstGroup = new List<int>();
            var secondGroup = new List<int>();

            foreach (var item in nums)
            {
                if (IsOneAtIndex(item, lastOneIndex))
                {
                    firstGroup.Add(item);
                }
                else
                {
                    secondGroup.Add(item);
                }
            }

            var first = GetNumberAppearedOnce(firstGroup);
            var second = GetNumberAppearedOnce(secondGroup);

            System.Console.WriteLine(first);
            System.Console.WriteLine(second);
        }

        private static int GetNumberAppearedOnce(IEnumerable<int> nums)
        {
            int ret = 0;
            foreach (var item in nums)
            {
                ret = ret ^ item;
            }

            return ret;
        }

        private static bool IsOneAtIndex(int value, int index)
        {
            for (int i = 0; i < index; i++)
            {
                value = value >> 1;
            }

            return value % 2 == 1;
        }

        private static int FindLastOneIndex(int value)
        {
            int index = 0;
            while (value % 2 == 0)
            {
                value = value >> 1;
                index++;
            }

            return index;
        }
    }
}