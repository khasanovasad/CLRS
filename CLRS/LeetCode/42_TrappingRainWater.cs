namespace CLRS.LeetCode;

// problem #42: Trapping Rain Water

// explanation: just run through the code manually to see the trick
// basically, if the left is less than or equal to right, that means we can
// trap water in between cells
// this is the most optimal solution with O (n) time and O (1) space

// DP version has O (n) time and O (n) space as it
// precalculates the rightMax and leftMax for each index of the array
public partial class Solution
{
    public int Trap(int[] height)
    {
        int answer = 0;

        int left = 0;
        int right = height.Length - 1;
        int leftMax = 0;
        int rightMax = height.Length - 1;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= height[leftMax])
                {
                    leftMax = left;
                }
                else
                {
                    answer += height[leftMax] - height[left];
                }

                ++left;
            }
            else
            {
                if (height[right] >= height[rightMax])
                {
                    rightMax = right;
                }
                else
                {
                    answer += height[rightMax] - height[right];
                }

                --right;
            }
        }

        return answer;
    }
}
