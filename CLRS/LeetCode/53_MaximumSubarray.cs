namespace CLRS.LeetCode;

// problem #53: Maximum Subarray
public partial class Solution
{
    public int MaxSubarray(int[] nums)
    {
        int maxSum = nums[0];
        int currSum = nums[0];

        for (int i = 1; i < nums.Count(); ++i)
        {
            currSum = Math.Max(nums[i], currSum + nums[i]);
            maxSum = Math.Max(maxSum, currSum);
        }

        return maxSum;
    }
}
