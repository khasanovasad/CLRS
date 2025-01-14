namespace CLRS.LeetCode;

// problem #11: Container With Most Water
// the idea is to move the current smalles height towords
// the center. Because, if one of the heights is smaller than the
// other, that means, no matter what, the current area is the max
// that can be built by the shorter wall as the height can't get heigher
// even if we move the heigher wall to the center and see an event higher
// wall there. Instead, the width would get smaller
public partial class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (right > left)
        {
            int width = right - left;
            maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * width);

            if (height[left] <= height[right])
            {
                left++;
            }
            else
            {
                right++;
            }
        }

        return maxArea;
    }
}
