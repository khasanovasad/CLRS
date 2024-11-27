namespace CLRS.LeetCode;

// problem #1480: Running Sum Of 1D Array
public partial class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int[] prefix = new int[nums.Length];
        prefix[0] = nums[0];
        for (int i = 1; i < nums.Length; ++i)
        {
            prefix[i] = prefix[i - 1] + nums[i];
        }

        return prefix;
    }
}