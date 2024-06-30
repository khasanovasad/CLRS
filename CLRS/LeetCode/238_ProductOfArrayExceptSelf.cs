namespace CLRS.LeetCode;

// problem #238: Product Of Array Except Self
public partial class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Count()];

        result[0] = 1;

        for (int i = 1; i < nums.Count(); ++i)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        int right = 1;
        for (int i = nums.Count() - 1; i >= 0; --i)
        {
            result[i] = right * result[i];
            right = right * nums[i];
        }

        return result;
    }
}
