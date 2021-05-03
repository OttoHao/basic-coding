using System;

namespace Hot100
{
    public class MaxAreaSolution
    {
        public int MaxArea(int[] height)
        {
            var area = 0;
            var maxArea = area;

            var left = 0;
            var right = height.Length - 1;

            while (left < right)
            {
                area = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right]) left++;
                else right--;
            }

            return maxArea;
        }
    }
}