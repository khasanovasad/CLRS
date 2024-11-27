namespace CLRS.LeetCode;

// problem #1413: Minimum Value to Get Positive Step by Step Sum
public partial class Solution
{
    public int MinStartValue(int[] nums)
    {
        int[] prefix = new int[nums.Length];
        prefix[0] = nums[0];

        int smallest = nums[0];

        for (int i = 1; i < nums.Length; ++i)
        {
            prefix[i] = prefix[i - 1] + nums[i];

            smallest = Math.Min(prefix[i], smallest);
        }

        return smallest > 0 ? 1 : Math.Abs(smallest) + 1;
    }
}